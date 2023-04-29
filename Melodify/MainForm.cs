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
        private SortedMethode LastSortedMethode;
        private AudioFileReader AudioFileReader;
        private bool IsFileGenerateException;
        private int CurrentPlayingMusicIndex;
        private List<string> AudioExtensions;
        private ShuffleState ShuffleState;
        private WaveOutEvent WaveOutEvent;
        public static List<string> Music;
        private MusicState MusicState;
        private LoopState LoopState;
        private Random RandomValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            Music = new List<string>();
            RandomValue = new Random();
            MusicState = MusicState.Pause;
            ShuffleState = ShuffleState.Off;
            LoopState = LoopState.Off;
            CurrentPlayingMusicIndex = 0;
            IsFileGenerateException = false;
            LastSortedMethode = SortedMethode.Title;

            AudioExtensions = new List<string>()
            {
                ".mp3", ".m4a", ".ogg", ".wav", ".3gp", ".flac", ".m4b", ".m4p", ".mpeg", ".mp4"
            };

            PlaybackBarControl.ChangedProgressPanel.MouseMove += ChangedProgressPanel_MouseMove;
        }

        private void OpenFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string audioFilter = "Audio Files|" + (from ext in AudioExtensions select ("*" + ext + "; ")) + "| All files |*.*";

            OpenFileDialog OFD = new OpenFileDialog
            {
                Multiselect = true,
                //Filter = "Audio Files|*.mp3; *.m4a; *.ogg; *.wav; *.3gp; *.flac; *.m4b; *.m4p; *.mpeg; | All files |*.*"
                Filter = audioFilter
            };

            if (OFD.ShowDialog() == DialogResult.OK)
                AddItemsInListToTheMainList(OFD.FileNames.ToList());
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                var AllFilesPath = Directory.EnumerateFiles(FBD.SelectedPath, "*.*", SearchOption.AllDirectories);

                List<string> OnlyAudioFiles = new List<string>();
                foreach (var FilePath in AllFilesPath)
                    if (FileIsAudio(FilePath))
                        OnlyAudioFiles.Add(FilePath);

                AddItemsInListToTheMainList(OnlyAudioFiles);
            }
        }

        private void AddMusicToFlowLayoutPanel(string MusicPath)
        {
            MusicPanel MusicPanel = new MusicPanel(MusicPath);
            MusicPanel.DoubleClick += MusicPanel_DoubleClick;
            MusicPanel.Click += MusicPanel_Click;
            MusicPanel.MouseClick += MusicPanel_MouseClick;
            FlowLayoutPanelMusic.Controls.Add(MusicPanel);
        }

        private void MusicPanel_DoubleClick(object sender, EventArgs e)
        {
            MusicPanel ClickedMusic = sender as MusicPanel;

            for (int i = 0; i < FlowLayoutPanelMusic.Controls.Count; i++)
            {
                if (FlowLayoutPanelMusic.Controls[i] == ClickedMusic)
                {
                    CurrentPlayingMusicIndex = i;
                    MusicInitialize(ClickedMusic.MusicPath);
                }

                FlowLayoutPanelMusic.Controls[i].BackColor = Color.Transparent;
            }

            ClickedMusic.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void MusicPanel_Click(object sender, EventArgs e)
        {
            MusicPanel ClickedMusic = sender as MusicPanel;

            foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                musicPanel.BackColor = Color.Transparent;

            ClickedMusic.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void MusicPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MusicPanel ClickedMusic = sender as MusicPanel;

                //  Change the Background color of the Clicked Music Panel, and reset the others background color
                foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                    musicPanel.BackColor = Color.Transparent;
                ClickedMusic.BackColor = Color.FromArgb(28, 28, 28);

                //  Show the Context Menu Strip, on the Clicked Music Panel
                Point PointLowerLeft = new Point(0, ClickedMusic.Height);
                PointLowerLeft = ClickedMusic.PointToScreen(PointLowerLeft);
                this.MusicPanelContextMenuStrip.Show(PointLowerLeft);
            }
        }

        private async void AddItemsInListToTheMainList(List<string> List)
        {
            //  Initialize the list and Play the first music
            foreach (string item in List)
            {
                if (FileIsAudio(item))
                {
                    Music.Add(item);
                    AddMusicToFlowLayoutPanel(item);
                }
                await Task.Delay(10);
            }
        }

        private bool FileIsAudio(string AudioFilePath)
        {
            bool Value = false;

            foreach (string AudioExtension in AudioExtensions)
            {
                if (AudioFilePath.ToLower().EndsWith(AudioExtension))
                {
                    Value = true;
                    break;
                }
            }
            return Value;
        }

        private void MusicInitialize(string path)
        {
            if (WaveOutEvent != null)
                WaveOutEvent.Dispose();
            if (AudioFileReader != null)
                AudioFileReader.Dispose();

            try
            {
                AudioFileReader = new AudioFileReader(path);
                WaveOutEvent = new WaveOutEvent();
                WaveOutEvent.Init(AudioFileReader);
                WaveOutEvent.Play();

                if (!AppTimer.Enabled)
                    AppTimer.Start();

                MusicState = MusicState.Play;
                ButtonPlayPause.BackgroundImage = Properties.Resources.Pause;
                PlayAndPauseToolStripMenuItem.Text = "Pause";

                PlaybackBarControl.Max = Convert.ToInt32(ConvertFrom.TimeToSeconds(AudioFileReader.TotalTime));
                AudioFileReader.Volume = TrackBarVolumeState.Value / 10f;

                //  This condition is related to the (Exception) Code Part
                //  The Path Variable will be changed to the CurrentPlayingMusic, for get the original audio meatdata
                if (IsFileGenerateException)
                    path = Music[CurrentPlayingMusicIndex];

                //  Change the Label Text to the Music Total Time
                //  Change the PictureBox BackgroundImage to the Music Cover
                LabelMusicEndTime.Text = AudioFileReader.TotalTime.ToString(@"mm\:ss");
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
                IsFileGenerateException = false;
            }
            catch
            {
                try
                {
                    //  If Audio File GenerateException, Convert it to 'wav' and save it
                    //  on a Temp File, so we can play it later
                    AudioFileReader = null;

                    using (var reader = new MediaFoundationReader(Music[CurrentPlayingMusicIndex]))
                    {
                        if (!Directory.Exists("TempFiles/"))
                            Directory.CreateDirectory("TempFiles/");

                        //  Save the 'wav' audio on the Temp File
                        WaveFileWriter.CreateWaveFile("TempFiles/temp.wav", reader);
                    }

                    //  Change the "IsFileGenerateException" value to true, because the File is Generate Exception
                    IsFileGenerateException = true;

                    //  Try to play the Temp File, if isn't played alert a message to the user
                    MusicInitialize("TempFiles/temp.wav");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("This song is hard for us to play it for you, Please play another one." + Environment.NewLine + "(" + Ex.Message + ")",
                            "We are sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            if (Music.Count != 0)
            {
                if (MusicState == MusicState.Pause)
                {
                    if (CurrentPlayingMusicIndex == 0 && WaveOutEvent == null)
                        MusicInitialize(Music[CurrentPlayingMusicIndex]);
                    else
                    {
                        WaveOutEvent.Play();

                        MusicState = MusicState.Play;
                        ButtonPlayPause.BackgroundImage = Properties.Resources.Pause;
                        PlayAndPauseToolStripMenuItem.Text = "Pause";
                    }
                }
                else if (MusicState == MusicState.Play)
                {
                    WaveOutEvent.Pause();

                    MusicState = MusicState.Pause;
                    ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
                    PlayAndPauseToolStripMenuItem.Text = "Play";
                }
            }
            else
                OpenFilesToolStripMenuItem_Click(sender, e);
        }

        private void ButtonPrevieus_Click(object sender, EventArgs e)
        {
            //  Check if the Current Playing Music isn't the first one on list, and the list isn't clear
            if (CurrentPlayingMusicIndex != 0 && Music.Count != 0)
            {
                MusicInitialize(Music[--CurrentPlayingMusicIndex]);

                FlowLayoutPanelMusic.ScrollControlIntoView(FlowLayoutPanelMusic.Controls[CurrentPlayingMusicIndex]);
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            //  Check if the Current Playing Music isn't the last one on list, and the list isn't clear
            //  and check if the LoopState equale All, to reaPeat the Playlist from the first
            if (CurrentPlayingMusicIndex != Music.Count - 1 && Music.Count != 0)
            {
                MusicInitialize(Music[++CurrentPlayingMusicIndex]);

                FlowLayoutPanelMusic.ScrollControlIntoView(FlowLayoutPanelMusic.Controls[CurrentPlayingMusicIndex]);
            }
            else if (CurrentPlayingMusicIndex == Music.Count - 1)
            {
                CurrentPlayingMusicIndex = 0;
                MusicInitialize(Music[CurrentPlayingMusicIndex]);

                if (LoopState == LoopState.Off)
                    ButtonPlayPause.PerformClick();
            }
        }

        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            if (Music.Count != 0)
            {
                if (ShuffleState == ShuffleState.On)
                {
                    ShuffleState = ShuffleState.Off;
                    ShuffleToolStripMenuItem.Checked = false;
                    ButtonShuffle.BackgroundImage = Properties.Resources.shuffleOff;

                    //  Order the list on the last SortedMethode
                    if (LastSortedMethode == SortedMethode.Title)
                        SortByTitleToolContextMenuStriItem.PerformClick();
                    else if (LastSortedMethode == SortedMethode.Album)
                        SortByAlbumToolContextMenuStriItem.PerformClick();
                    else if (LastSortedMethode == SortedMethode.Artist)
                        SortByArtistToolContextMenuStriItem.PerformClick();
                }
                else if (ShuffleState == ShuffleState.Off)
                {
                    ShuffleState = ShuffleState.On;
                    ShuffleToolStripMenuItem.Checked = true;
                    ButtonShuffle.BackgroundImage = Properties.Resources.shuffleOn;

                    SortByTitleToolContextMenuStriItem.Checked = false;
                    SortByArtistToolContextMenuStriItem.Checked = false;
                    SortByAlbumToolContextMenuStriItem.Checked = false;

                    TitleToolStripMenuItem.Checked = false;
                    ArtistToolStripMenuItem.Checked = false;
                    AlbumToolStripMenuItem.Checked = false;

                    //  Shuffle the List
                    List<string> ShuffledList = Music.OrderBy((item) => RandomValue.Next()).ToList();

                    // Clear the Lists and initialize the index and waveoutevent to null
                    ClearListToolStripMenuItem.PerformClick();

                    //  Initialize the list and Play the first music
                    AddItemsInListToTheMainList(ShuffledList);
                }
            }
        }

        private void ButtonLoop_Click(object sender, EventArgs e)
        {
            if (LoopState == LoopState.One)
            {
                LoopState = LoopState.All;
                LoopModeAllToolStripMenuItem.Checked = true;
                LoopModeOneToolStripMenuItem.Checked = false;
                LoopModeOffToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopAll;
            }
            else if (LoopState == LoopState.All)
            {
                LoopState = LoopState.Off;
                LoopModeOffToolStripMenuItem.Checked = true;
                LoopModeOneToolStripMenuItem.Checked = false;
                LoopModeAllToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopOff;
            }
            else if (LoopState == LoopState.Off)
            {
                LoopState = LoopState.One;
                LoopModeOneToolStripMenuItem.Checked = true;
                LoopModeAllToolStripMenuItem.Checked = false;
                LoopModeOffToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopOne;
            }
        }

        private void LoopModeOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopState = LoopState.One;
            LoopModeOneToolStripMenuItem.Checked = true;
            LoopModeAllToolStripMenuItem.Checked = false;
            LoopModeOffToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopOne;
        }

        private void LoopModeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopState = LoopState.All;
            LoopModeAllToolStripMenuItem.Checked = true;
            LoopModeOneToolStripMenuItem.Checked = false;
            LoopModeOffToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopAll;
        }

        private void LoopModeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopState = LoopState.Off;
            LoopModeOffToolStripMenuItem.Checked = true;
            LoopModeOneToolStripMenuItem.Checked = false;
            LoopModeAllToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopOff;
        }

        private void ChangedProgressPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (AudioFileReader != null)
            {
                if (PlaybackBarControl.IsMouseDown)
                    AudioFileReader.CurrentTime = ConvertFrom.SecondsToTime(PlaybackBarControl.Val);
            }
            else
                PlaybackBarControl.Val = 0;
        }

        private void TrackBarVolumeState_Scroll(object sender, EventArgs e)
        {
            if (AudioFileReader != null)
                AudioFileReader.Volume = TrackBarVolumeState.Value / 10f;
            else
                TrackBarVolumeState.Value = 10;
        }

        private void AppTimer_Tick(object sender, EventArgs e)
        {
            if (AudioFileReader != null)
            {
                //  Change the Label Text to the Music current Time
                LabelMusicCurrentTimeState.Text = AudioFileReader.CurrentTime.ToString(@"mm\:ss");

                //  Change the PlaybackBarControl value to the Music current Time
                PlaybackBarControl.Val = Convert.ToInt32(ConvertFrom.TimeToSeconds(AudioFileReader.CurrentTime));

                //  Check if the Music end, then start the Next one or repeat it
                if (LabelMusicCurrentTimeState.Text == LabelMusicEndTime.Text)
                {
                    if (LoopState == LoopState.One)
                        AudioFileReader.Position = 0;
                    else if (LoopState == LoopState.Off || LoopState == LoopState.All)
                    {
                        MusicState = MusicState.Pause;
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
                    if (musicPanel.MusicPath == Music[CurrentPlayingMusicIndex])
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
                    CurrentPlayingMusicIndex = i;
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
                LyricsForm LyricsForm = new LyricsForm(Music[CurrentPlayingMusicIndex])
                {
                    Icon = this.Icon
                };
                LyricsForm.Show();
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
                        LyricsForm LyricsForm = new LyricsForm(Music[i])
                        {
                            Icon = this.Icon
                        };
                        LyricsForm.Show();
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
                        EditForm EditForm = new EditForm(i)
                        {
                            Icon = this.Icon
                        };
                        EditForm.Show();
                        break;
                    }
                }
            }
        }

        private void SortByTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  I use the OrderBy function and the Linq, to sort the list on the title
            List<string> SortedList = Music.OrderBy(o => TagFile.GetTitle(o)).ToList();

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(SortedList);

            LastSortedMethode = SortedMethode.Title;

            SortByTitleToolContextMenuStriItem.Checked = true;
            SortByArtistToolContextMenuStriItem.Checked = false;
            SortByAlbumToolContextMenuStriItem.Checked = false;

            TitleToolStripMenuItem.Checked = true;
            ArtistToolStripMenuItem.Checked = false;
            AlbumToolStripMenuItem.Checked = false;
        }

        private void SortByArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SortedList = Music.OrderBy(x => TagFile.GetArtists(x)).ThenBy(x => TagFile.GetAlbum(x)).ThenBy(x => TagFile.GetTrack(x)).ToList();
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
            AddItemsInListToTheMainList(SortedList);

            LastSortedMethode = SortedMethode.Artist;

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
            var SortedList = Music.OrderBy(x => TagFile.GetAlbum(x)).ThenBy(x => TagFile.GetTrack(x)).ToList();

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(SortedList);

            LastSortedMethode = SortedMethode.Album;

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

            if (WaveOutEvent != null)
            {
                WaveOutEvent.Dispose();
                WaveOutEvent = null;
            }
            if (AudioFileReader != null)
            {
                AudioFileReader.Dispose();
                AudioFileReader = null;
            }

            FlowLayoutPanelMusic.Controls.Clear();
            Music.Clear();

            LabelMusicCurrentTimeState.Text = "--:--";
            LabelMusicEndTime.Text = "--:--";

            CurrentPlayingMusicIndex = 0;
            PlaybackBarControl.Val = 0;

            PictureBoxMusicCover.BackgroundImage = Properties.Resources.MusicTon;
            ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
            PlayAndPauseToolStripMenuItem.Text = "Play";
            MusicState = MusicState.Pause;

            this.Text = "MusicPlayer";
        }

        private void MusicPlayer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            //  Allow only the Audio Files and the folders
            foreach (string FilePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (!FileIsAudio(FilePath))
                {
                    e.Effect = DragDropEffects.None;
                    break;
                }
            }
        }

        private void MusicPlayer_DragDrop(object sender, DragEventArgs e)
        {
            List<string> OnlyAudioFiles = new List<string>();

            foreach (string FilePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                //  Add only the Audio file to the List
                if (FileIsAudio(FilePath))
                    OnlyAudioFiles.Add(FilePath);
                else if (Directory.Exists(FilePath))
                {
                    //  Filter the Folder and Add only the Audio file to the List
                    var AllFilesPath = Directory.EnumerateFiles(FilePath, "*.*", SearchOption.AllDirectories);

                    foreach (var FilePathInList in AllFilesPath)
                        if (FileIsAudio(FilePathInList))
                            OnlyAudioFiles.Add(FilePathInList);
                }
            }

            AddItemsInListToTheMainList(OnlyAudioFiles);
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
