using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melodify.Classes;

namespace Melodify
{
    public partial class MainForm : Form
    {
        private SortedMethod _lastSortedMethod;
        private AudioFileReader _audioFileReader;
        private bool _isFileGenerateException;
        private int _currentPlayingMusicIndex;
        private List<string> _audioExtensions;
        private ShuffleState _shuffleState;
        private WaveOutEvent _waveOutEvent;
        public static List<string> Music;
        private MusicState _musicState;
        private LoopState _loopState;
        private Random _randomValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            Music = new List<string>();
            _randomValue = new Random();
            _musicState = MusicState.Pause;
            _shuffleState = ShuffleState.Off;
            _loopState = LoopState.Off;
            _currentPlayingMusicIndex = 0;
            _isFileGenerateException = false;
            _lastSortedMethod = SortedMethod.Title;

            _audioExtensions = new List<string>()
            {
                ".mp3", ".m4a", ".ogg", ".wav", ".3gp", ".flac", ".m4b", ".m4p", ".mpeg", ".mp4"
            };

            PlaybackBarControl.ChangedProgressPanel.MouseMove += ChangedProgressPanel_MouseMove;
        }

        private void OpenFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string audioFilter = "Audio Files|" + string.Join(";", _audioExtensions.Select(ext => "*" + ext)) + "|All files|*.*";

            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = audioFilter
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                AddItemsInListToTheMainList(ofd.FileNames.ToList());
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var allFilesPath = Directory.EnumerateFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);

                List<string> onlyAudioFiles = new List<string>();
                foreach (var filePath in allFilesPath)
                    if (FileIsAudio(filePath))
                        onlyAudioFiles.Add(filePath);

                AddItemsInListToTheMainList(onlyAudioFiles);
            }
        }

        private void AddMusicToFlowLayoutPanel(string musicPath)
        {
            MusicPanel musicPanel = new MusicPanel(musicPath);
            musicPanel.DoubleClick += MusicPanel_DoubleClick;
            musicPanel.Click += MusicPanel_Click;
            musicPanel.MouseClick += MusicPanel_MouseClick;
            FlowLayoutPanelMusic.Controls.Add(musicPanel);
        }

        private void MusicPanel_DoubleClick(object sender, EventArgs e)
        {
            MusicPanel clickedMusic = sender as MusicPanel;

            for (int i = 0; i < FlowLayoutPanelMusic.Controls.Count; i++)
            {
                if (FlowLayoutPanelMusic.Controls[i] == clickedMusic)
                {
                    _currentPlayingMusicIndex = i;
                    MusicInitialize(clickedMusic.MusicPath);
                }

                FlowLayoutPanelMusic.Controls[i].BackColor = Color.Transparent;
            }

            clickedMusic.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void MusicPanel_Click(object sender, EventArgs e)
        {
            MusicPanel clickedMusic = sender as MusicPanel;

            foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                musicPanel.BackColor = Color.Transparent;

            clickedMusic.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void MusicPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MusicPanel clickedMusic = sender as MusicPanel;

                //  Change the Background color of the Clicked Music Panel, and reset the others background color
                foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                    musicPanel.BackColor = Color.Transparent;
                clickedMusic.BackColor = Color.FromArgb(28, 28, 28);

                //  Show the Context Menu Strip, on the Clicked Music Panel
                Point pointLowerLeft = new Point(0, clickedMusic.Height);
                pointLowerLeft = clickedMusic.PointToScreen(pointLowerLeft);
                this.MusicPanelContextMenuStrip.Show(pointLowerLeft);
            }
        }

        private async void AddItemsInListToTheMainList(List<string> list)
        {
            //  Initialize the list and Play the first music
            foreach (string item in list)
            {
                if (FileIsAudio(item))
                {
                    Music.Add(item);
                    AddMusicToFlowLayoutPanel(item);
                }
                await Task.Delay(10);
            }
        }

        private bool FileIsAudio(string audioFilePath)
        {
            bool value = false;

            foreach (string audioExtension in _audioExtensions)
            {
                if (audioFilePath.ToLower().EndsWith(audioExtension))
                {
                    value = true;
                    break;
                }
            }
            return value;
        }

        private void MusicInitialize(string path)
        {
            if (_waveOutEvent != null)
                _waveOutEvent.Dispose();
            if (_audioFileReader != null)
                _audioFileReader.Dispose();

            try
            {
                _audioFileReader = new AudioFileReader(path);
                _waveOutEvent = new WaveOutEvent();
                _waveOutEvent.Init(_audioFileReader);
                _waveOutEvent.Play();

                if (!AppTimer.Enabled)
                    AppTimer.Start();

                _musicState = MusicState.Play;
                ButtonPlayPause.BackgroundImage = Properties.Resources.Pause;
                PlayAndPauseToolStripMenuItem.Text = "Pause";

                PlaybackBarControl.Max = Convert.ToInt32(ConvertFrom.TimeToSeconds(_audioFileReader.TotalTime));
                _audioFileReader.Volume = TrackBarVolumeState.Value / 10f;

                //  This condition is related to the (Exception) Code Part
                //  The Path Variable will be changed to the CurrentPlayingMusic, for get the original audio meatdata
                if (_isFileGenerateException)
                    path = Music[_currentPlayingMusicIndex];

                //  Change the Label Text to the Music Total Time
                //  Change the PictureBox BackgroundImage to the Music Cover
                LabelMusicEndTime.Text = _audioFileReader.TotalTime.ToString(@"mm\:ss");
                PictureBoxMusicCover.BackgroundImage = TagFile.GetCover(path);

                //  Change the Form Title to the Music Title + Artist
                this.Text = TagFile.GetArtists(path) + " - " + TagFile.GetTitle(path);

                //  Change the Current MusicPanel BackgroundColor, and reset the others
                foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                {
                    if (musicPanel.MusicPath == path)
                        musicPanel.BackColor = Color.FromArgb(28, 28, 28);
                    else
                        musicPanel.BackColor = Color.Transparent;
                }

                //  Reset the "IsFileGenerateException" value to false
                _isFileGenerateException = false;
            }
            catch
            {
                try
                {
                    //  If Audio File GenerateException, Convert it to 'wav' and save it
                    //  on a Temp File, so we can play it later
                    _audioFileReader = null;

                    using (var reader = new MediaFoundationReader(Music[_currentPlayingMusicIndex]))
                    {
                        if (!Directory.Exists("TempFiles/"))
                            Directory.CreateDirectory("TempFiles/");

                        //  Save the 'wav' audio on the Temp File
                        WaveFileWriter.CreateWaveFile("TempFiles/temp.wav", reader);
                    }

                    //  Change the "IsFileGenerateException" value to true, because the File is Generate Exception
                    _isFileGenerateException = true;

                    //  Try to play the Temp File, if isn't played alert a message to the user
                    MusicInitialize("TempFiles/temp.wav");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This song is hard for us to play it for you, Please play another one." + Environment.NewLine + "(" + ex.Message + ")",
                            "We are sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            if (Music.Count != 0)
            {
                if (_musicState == MusicState.Pause)
                {
                    if (_currentPlayingMusicIndex == 0 && _waveOutEvent == null)
                        MusicInitialize(Music[_currentPlayingMusicIndex]);
                    else
                    {
                        _waveOutEvent.Play();

                        _musicState = MusicState.Play;
                        ButtonPlayPause.BackgroundImage = Properties.Resources.Pause;
                        PlayAndPauseToolStripMenuItem.Text = "Pause";
                    }
                }
                else if (_musicState == MusicState.Play)
                {
                    _waveOutEvent.Pause();

                    _musicState = MusicState.Pause;
                    ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
                    PlayAndPauseToolStripMenuItem.Text = "Play";
                }
            }
            else
                OpenFilesToolStripMenuItem_Click(sender, e);
        }

        private void ButtonPreviousClick(object sender, EventArgs e)
        {
            //  Check if the Current Playing Music isn't the first one on list, and the list isn't clear
            if (_currentPlayingMusicIndex != 0 && Music.Count != 0)
            {
                MusicInitialize(Music[--_currentPlayingMusicIndex]);

                FlowLayoutPanelMusic.ScrollControlIntoView(FlowLayoutPanelMusic.Controls[_currentPlayingMusicIndex]);
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            //  Check if the Current Playing Music isn't the last one on list, and the list isn't clear
            //  and check if the LoopState equale All, to reaPeat the Playlist from the first
            if (_currentPlayingMusicIndex != Music.Count - 1 && Music.Count != 0)
            {
                MusicInitialize(Music[++_currentPlayingMusicIndex]);

                FlowLayoutPanelMusic.ScrollControlIntoView(FlowLayoutPanelMusic.Controls[_currentPlayingMusicIndex]);
            }
            else if (_currentPlayingMusicIndex == Music.Count - 1)
            {
                _currentPlayingMusicIndex = 0;
                MusicInitialize(Music[_currentPlayingMusicIndex]);

                if (_loopState == LoopState.Off)
                    ButtonPlayPause.PerformClick();
            }
        }

        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            if (Music.Count != 0)
            {
                if (_shuffleState == ShuffleState.On)
                {
                    _shuffleState = ShuffleState.Off;
                    ShuffleToolStripMenuItem.Checked = false;
                    ButtonShuffle.BackgroundImage = Properties.Resources.shuffleOff;

                    //  Order the list on the last SortedMethod
                    if (_lastSortedMethod == SortedMethod.Title)
                        SortByTitleToolContextMenuStriItem.PerformClick();
                    else if (_lastSortedMethod == SortedMethod.Album)
                        SortByAlbumToolContextMenuStriItem.PerformClick();
                    else if (_lastSortedMethod == SortedMethod.Artist)
                        SortByArtistToolContextMenuStriItem.PerformClick();
                }
                else if (_shuffleState == ShuffleState.Off)
                {
                    _shuffleState = ShuffleState.On;
                    ShuffleToolStripMenuItem.Checked = true;
                    ButtonShuffle.BackgroundImage = Properties.Resources.shuffleOn;

                    SortByTitleToolContextMenuStriItem.Checked = false;
                    SortByArtistToolContextMenuStriItem.Checked = false;
                    SortByAlbumToolContextMenuStriItem.Checked = false;

                    TitleToolStripMenuItem.Checked = false;
                    ArtistToolStripMenuItem.Checked = false;
                    AlbumToolStripMenuItem.Checked = false;

                    //  Shuffle the List
                    List<string> shuffledList = Music.OrderBy((item) => _randomValue.Next()).ToList();

                    // Clear the Lists and initialize the index and waveoutevent to null
                    ClearListToolStripMenuItem.PerformClick();

                    //  Initialize the list and Play the first music
                    AddItemsInListToTheMainList(shuffledList);
                }
            }
        }

        private void ButtonLoop_Click(object sender, EventArgs e)
        {
            if (_loopState == LoopState.One)
            {
                _loopState = LoopState.All;
                LoopModeAllToolStripMenuItem.Checked = true;
                LoopModeOneToolStripMenuItem.Checked = false;
                LoopModeOffToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopAll;
            }
            else if (_loopState == LoopState.All)
            {
                _loopState = LoopState.Off;
                LoopModeOffToolStripMenuItem.Checked = true;
                LoopModeOneToolStripMenuItem.Checked = false;
                LoopModeAllToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopOff;
            }
            else if (_loopState == LoopState.Off)
            {
                _loopState = LoopState.One;
                LoopModeOneToolStripMenuItem.Checked = true;
                LoopModeAllToolStripMenuItem.Checked = false;
                LoopModeOffToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopOne;
            }
        }

        private void LoopModeOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loopState = LoopState.One;
            LoopModeOneToolStripMenuItem.Checked = true;
            LoopModeAllToolStripMenuItem.Checked = false;
            LoopModeOffToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopOne;
        }

        private void LoopModeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loopState = LoopState.All;
            LoopModeAllToolStripMenuItem.Checked = true;
            LoopModeOneToolStripMenuItem.Checked = false;
            LoopModeOffToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopAll;
        }

        private void LoopModeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loopState = LoopState.Off;
            LoopModeOffToolStripMenuItem.Checked = true;
            LoopModeOneToolStripMenuItem.Checked = false;
            LoopModeAllToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopOff;
        }

        private void ChangedProgressPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_audioFileReader != null)
            {
                if (PlaybackBarControl.IsMouseDown)
                    _audioFileReader.CurrentTime = ConvertFrom.SecondsToTime(PlaybackBarControl.Val);
            }
            else
                PlaybackBarControl.Val = 0;
        }

        private void TrackBarVolumeState_Scroll(object sender, EventArgs e)
        {
            if (_audioFileReader != null)
                _audioFileReader.Volume = TrackBarVolumeState.Value / 10f;
            else
                TrackBarVolumeState.Value = 10;
        }

        private void AppTimer_Tick(object sender, EventArgs e)
        {
            if (_audioFileReader != null)
            {
                //  Change the Label Text to the Music current Time
                LabelMusicCurrentTimeState.Text = _audioFileReader.CurrentTime.ToString(@"mm\:ss");

                //  Change the PlaybackBarControl value to the Music current Time
                PlaybackBarControl.Val = Convert.ToInt32(ConvertFrom.TimeToSeconds(_audioFileReader.CurrentTime));

                //  Check if the Music end, then start the Next one or repeat it
                if (LabelMusicCurrentTimeState.Text == LabelMusicEndTime.Text)
                {
                    if (_loopState == LoopState.One)
                        _audioFileReader.Position = 0;
                    else if (_loopState == LoopState.Off || _loopState == LoopState.All)
                    {
                        _musicState = MusicState.Pause;
                        ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
                        PlayAndPauseToolStripMenuItem.Text = "Play";

                        ButtonNext.PerformClick();
                    }
                }
            }
        }

        private void StartSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
            {
                if (musicPanel.BackColor == Color.FromArgb(28, 28, 28))
                {
                    MusicPanel_DoubleClick(musicPanel, e);
                    break;
                }
            }
        }

        private void RemoveFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Search for the clicked MusicPanel and remove it
            foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
            {
                if (musicPanel.BackColor == Color.FromArgb(28, 28, 28))
                {
                    //  if the removed MusicPanel is the Playong Music, Start the next one
                    if (musicPanel.MusicPath == Music[_currentPlayingMusicIndex])
                        ButtonNext.PerformClick();

                    Music.Remove(musicPanel.MusicPath);
                    FlowLayoutPanelMusic.Controls.Remove(musicPanel);

                    if (Music.Count == 0)
                        ClearListToolStripMenuItem_Click(sender, e);

                    break;
                }
            }

            //  Initialize the CurrentPlayingMusicIndex with the correct index
            for (int i = 0; i < Music.Count; i++)
            {
                if (this.Text == (TagFile.GetArtists(Music[i]) + " - " + TagFile.GetTitle(Music[i])))
                {
                    _currentPlayingMusicIndex = i;
                    break;
                }
            }
        }

        private void ShowAndHideMusicListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FlowLayoutPanelMusic.Visible)
            {
                ShowAndHideMusicListToolStripMenuItem.Text = "Hide Music List";
                FlowLayoutPanelMusic.Visible = true;
            }
            else if (FlowLayoutPanelMusic.Visible)
            {
                ShowAndHideMusicListToolStripMenuItem.Text = "Show Music List";
                FlowLayoutPanelMusic.Visible = false;
            }
        }

        private void ShowSongLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Music.Count != 0)
            {
                LyricsForm lyricsForm = new LyricsForm(Music[_currentPlayingMusicIndex])
                {
                    Icon = this.Icon
                };
                lyricsForm.Show();
            }
        }

        private void ShowMusicLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Music.Count != 0)
            {
                for (int i = 0; i < FlowLayoutPanelMusic.Controls.Count; i++)
                {
                    if (FlowLayoutPanelMusic.Controls[i].BackColor == Color.FromArgb(28, 28, 28))
                    {
                        LyricsForm lyricsForm = new LyricsForm(Music[i])
                        {
                            Icon = this.Icon
                        };
                        lyricsForm.Show();
                        break;
                    }
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Music.Count != 0)
            {
                for (int i = 0; i < FlowLayoutPanelMusic.Controls.Count; i++)
                {
                    if (FlowLayoutPanelMusic.Controls[i].BackColor == Color.FromArgb(28, 28, 28))
                    {
                        EditForm editForm = new EditForm(i)
                        {
                            Icon = this.Icon
                        };
                        editForm.Show();
                        break;
                    }
                }
            }
        }

        private void SortByTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  I use the OrderBy function and the Linq, to sort the list on the title
            List<string> sortedList = Music.OrderBy(o => TagFile.GetTitle(o)).ToList();

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(sortedList);

            _lastSortedMethod = SortedMethod.Title;

            SortByTitleToolContextMenuStriItem.Checked = true;
            SortByArtistToolContextMenuStriItem.Checked = false;
            SortByAlbumToolContextMenuStriItem.Checked = false;

            TitleToolStripMenuItem.Checked = true;
            ArtistToolStripMenuItem.Checked = false;
            AlbumToolStripMenuItem.Checked = false;
        }

        private void SortByArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedList = Music.OrderBy(x => TagFile.GetArtists(x)).ThenBy(x => TagFile.GetAlbum(x)).ThenBy(x => TagFile.GetTrack(x)).ToList();
            // The only reason make me keep All this Code bellow on comment, is that i found a better and small way to do it (The Line upove)
            #region The Comment Code
            /*  //  I use the OrderBy function and the Linq, to sort the list on the Album
            List<string> MusicListCopy = Music.OrderBy(o => TagFile.Album(o)).ToList();
            List<string> AllAlbumsName = new List<string>();

            foreach (var item in MusicListCopy)
                AllAlbumsName.Add(TagFile.Album(item));
            //  Reamove all the rapeated AlbumName on the list
            AllAlbumsName = AllAlbumsName.Distinct().ToList();

            List<string> SortedList = new List<string>();
            List<string> OnlyOneAlbumMusic = new List<string>();

            foreach (var ItemInAllAlbumsName in AllAlbumsName)
            {
                foreach (var ItemInMusic in Music)
                {
                    if (TagFile.Album(ItemInMusic) == ItemInAllAlbumsName)
                    {
                        OnlyOneAlbumMusic.Add(ItemInMusic);
                        MusicListCopy.Remove(ItemInMusic);
                    }
                }

                OnlyOneAlbumMusic = OnlyOneAlbumMusic.OrderBy(o => TagFile.Track(o)).ToList();

                foreach (var item in OnlyOneAlbumMusic)
                    SortedList.Add(item);
                OnlyOneAlbumMusic.Clear();
            }

            SortedList = SortedList.OrderBy(o => TagFile.Artist(o)).ToList();   */
            #endregion

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(sortedList);

            _lastSortedMethod = SortedMethod.Artist;

            SortByArtistToolContextMenuStriItem.Checked = true;
            SortByTitleToolContextMenuStriItem.Checked = false;
            SortByAlbumToolContextMenuStriItem.Checked = false;

            ArtistToolStripMenuItem.Checked = true;
            TitleToolStripMenuItem.Checked = false;
            AlbumToolStripMenuItem.Checked = false;
        }

        private void SortByAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Sort thelist by the Album then the Track Number
            var sortedList = Music.OrderBy(x => TagFile.GetAlbum(x)).ThenBy(x => TagFile.GetTrack(x)).ToList();

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(sortedList);

            _lastSortedMethod = SortedMethod.Album;

            SortByAlbumToolContextMenuStriItem.Checked = true;
            SortByTitleToolContextMenuStriItem.Checked = false;
            SortByArtistToolContextMenuStriItem.Checked = false;

            AlbumToolStripMenuItem.Checked = true;
            TitleToolStripMenuItem.Checked = false;
            ArtistToolStripMenuItem.Checked = false;
        }

        private void ClearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppTimer.Stop();

            if (_waveOutEvent != null)
            {
                _waveOutEvent.Dispose();
                _waveOutEvent = null;
            }
            if (_audioFileReader != null)
            {
                _audioFileReader.Dispose();
                _audioFileReader = null;
            }

            FlowLayoutPanelMusic.Controls.Clear();
            Music.Clear();

            LabelMusicCurrentTimeState.Text = "--:--";
            LabelMusicEndTime.Text = "--:--";

            _currentPlayingMusicIndex = 0;
            PlaybackBarControl.Val = 0;

            PictureBoxMusicCover.BackgroundImage = Properties.Resources.MusicTon;
            ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
            PlayAndPauseToolStripMenuItem.Text = "Play";
            _musicState = MusicState.Pause;

            this.Text = "MusicPlayer";
        }

        private void MusicPlayer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            //  Allow only the Audio Files and the folders
            foreach (string filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (!FileIsAudio(filePath))
                {
                    e.Effect = DragDropEffects.None;
                    break;
                }
            }
        }

        private void MusicPlayer_DragDrop(object sender, DragEventArgs e)
        {
            List<string> onlyAudioFiles = new List<string>();

            foreach (string filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                //  Add only the Audio file to the List
                if (FileIsAudio(filePath))
                    onlyAudioFiles.Add(filePath);
                else if (Directory.Exists(filePath))
                {
                    //  Filter the Folder and Add only the Audio file to the List
                    var allFilesPath = Directory.EnumerateFiles(filePath, "*.*", SearchOption.AllDirectories);

                    foreach (var filePathInList in allFilesPath)
                        if (FileIsAudio(filePathInList))
                            onlyAudioFiles.Add(filePathInList);
                }
            }

            AddItemsInListToTheMainList(onlyAudioFiles);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm() { Icon = this.Icon }.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Delete the Temp Files
            if (Directory.Exists("TempFiles/"))
                Directory.Delete("TempFiles/", true);
        }

    }
}
