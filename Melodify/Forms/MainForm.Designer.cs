using Melodify.Components;

namespace Melodify.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LabelMusicCurrentTimeState = new System.Windows.Forms.Label();
            LabelMusicEndTime = new System.Windows.Forms.Label();
            PanelControls = new System.Windows.Forms.Panel();
            PlaybackBarControl = new PlaybackBarControl();
            TrackBarVolumeState = new System.Windows.Forms.TrackBar();
            ButtonPrevious = new System.Windows.Forms.Button();
            ButtonShuffle = new System.Windows.Forms.Button();
            ButtonLoop = new System.Windows.Forms.Button();
            ButtonNext = new System.Windows.Forms.Button();
            ButtonShowAndHideList = new System.Windows.Forms.Button();
            ButtonPlayPause = new System.Windows.Forms.Button();
            AppMenuStrip = new System.Windows.Forms.MenuStrip();
            FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PlayAndPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            NextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            EditSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            TitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ShuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            LoopModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            LoopModeOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            LoopModeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            LoopModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ShowAndHideMusicListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ShowAndHideSongLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AppTimer = new System.Windows.Forms.Timer(components);
            MusicPanelContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            StartSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            RemoveFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ShowMusicLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            EditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            SortByToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            SortByTitleToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            SortByArtistToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            SortByAlbumToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ClearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PictureBoxMusicCover = new System.Windows.Forms.Panel();
            FlowLayoutPanelMusic = new System.Windows.Forms.FlowLayoutPanel();
            PanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarVolumeState).BeginInit();
            AppMenuStrip.SuspendLayout();
            MusicPanelContextMenuStrip.SuspendLayout();
            PictureBoxMusicCover.SuspendLayout();
            SuspendLayout();
            // 
            // LabelMusicCurrentTimeState
            // 
            LabelMusicCurrentTimeState.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            LabelMusicCurrentTimeState.AutoSize = true;
            LabelMusicCurrentTimeState.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LabelMusicCurrentTimeState.Location = new System.Drawing.Point(281, 15);
            LabelMusicCurrentTimeState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelMusicCurrentTimeState.Name = "LabelMusicCurrentTimeState";
            LabelMusicCurrentTimeState.Size = new System.Drawing.Size(40, 16);
            LabelMusicCurrentTimeState.TabIndex = 0;
            LabelMusicCurrentTimeState.Text = "--:--";
            // 
            // LabelMusicEndTime
            // 
            LabelMusicEndTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            LabelMusicEndTime.AutoSize = true;
            LabelMusicEndTime.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LabelMusicEndTime.Location = new System.Drawing.Point(761, 15);
            LabelMusicEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelMusicEndTime.Name = "LabelMusicEndTime";
            LabelMusicEndTime.Size = new System.Drawing.Size(40, 16);
            LabelMusicEndTime.TabIndex = 0;
            LabelMusicEndTime.Text = "--:--";
            // 
            // PanelControls
            // 
            PanelControls.BackColor = System.Drawing.Color.Black;
            PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelControls.Controls.Add(PlaybackBarControl);
            PanelControls.Controls.Add(TrackBarVolumeState);
            PanelControls.Controls.Add(ButtonPrevious);
            PanelControls.Controls.Add(LabelMusicEndTime);
            PanelControls.Controls.Add(LabelMusicCurrentTimeState);
            PanelControls.Controls.Add(ButtonShuffle);
            PanelControls.Controls.Add(ButtonLoop);
            PanelControls.Controls.Add(ButtonNext);
            PanelControls.Controls.Add(ButtonShowAndHideList);
            PanelControls.Controls.Add(ButtonPlayPause);
            PanelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelControls.ForeColor = System.Drawing.Color.White;
            PanelControls.Location = new System.Drawing.Point(0, 442);
            PanelControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PanelControls.Name = "PanelControls";
            PanelControls.Size = new System.Drawing.Size(968, 52);
            PanelControls.TabIndex = 0;
            // 
            // PlaybackBarControl
            // 
            PlaybackBarControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PlaybackBarControl.BackColor = System.Drawing.Color.Transparent;
            PlaybackBarControl.Location = new System.Drawing.Point(336, 13);
            PlaybackBarControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            PlaybackBarControl.Max = 100;
            PlaybackBarControl.Name = "PlaybackBarControl";
            PlaybackBarControl.Size = new System.Drawing.Size(418, 24);
            PlaybackBarControl.TabIndex = 1;
            PlaybackBarControl.Val = 0;
            // 
            // TrackBarVolumeState
            // 
            TrackBarVolumeState.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TrackBarVolumeState.AutoSize = false;
            TrackBarVolumeState.BackColor = System.Drawing.Color.Black;
            TrackBarVolumeState.Cursor = System.Windows.Forms.Cursors.Hand;
            TrackBarVolumeState.Location = new System.Drawing.Point(815, 16);
            TrackBarVolumeState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TrackBarVolumeState.Name = "TrackBarVolumeState";
            TrackBarVolumeState.Size = new System.Drawing.Size(140, 23);
            TrackBarVolumeState.TabIndex = 0;
            TrackBarVolumeState.TabStop = false;
            TrackBarVolumeState.TickStyle = System.Windows.Forms.TickStyle.None;
            TrackBarVolumeState.Value = 3;
            TrackBarVolumeState.Scroll += TrackBarVolumeState_Scroll;
            // 
            // ButtonPrevious
            // 
            ButtonPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ButtonPrevious.BackColor = System.Drawing.Color.Black;
            ButtonPrevious.BackgroundImage = Properties.Resources.Previous;
            ButtonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonPrevious.FlatAppearance.BorderSize = 0;
            ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonPrevious.Location = new System.Drawing.Point(13, 10);
            ButtonPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonPrevious.Name = "ButtonPrevious";
            ButtonPrevious.Size = new System.Drawing.Size(35, 29);
            ButtonPrevious.TabIndex = 0;
            ButtonPrevious.TabStop = false;
            ButtonPrevious.UseVisualStyleBackColor = false;
            ButtonPrevious.Click += ButtonPreviousClick;
            // 
            // ButtonShuffle
            // 
            ButtonShuffle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ButtonShuffle.BackColor = System.Drawing.Color.Black;
            ButtonShuffle.BackgroundImage = Properties.Resources.shuffleOff;
            ButtonShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonShuffle.FlatAppearance.BorderSize = 0;
            ButtonShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonShuffle.Location = new System.Drawing.Point(232, 10);
            ButtonShuffle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonShuffle.Name = "ButtonShuffle";
            ButtonShuffle.Size = new System.Drawing.Size(35, 29);
            ButtonShuffle.TabIndex = 0;
            ButtonShuffle.TabStop = false;
            ButtonShuffle.UseVisualStyleBackColor = false;
            ButtonShuffle.Click += ButtonShuffle_Click;
            // 
            // ButtonLoop
            // 
            ButtonLoop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ButtonLoop.BackColor = System.Drawing.Color.Black;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopOff;
            ButtonLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonLoop.FlatAppearance.BorderSize = 0;
            ButtonLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonLoop.Location = new System.Drawing.Point(193, 10);
            ButtonLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonLoop.Name = "ButtonLoop";
            ButtonLoop.Size = new System.Drawing.Size(35, 29);
            ButtonLoop.TabIndex = 0;
            ButtonLoop.TabStop = false;
            ButtonLoop.UseVisualStyleBackColor = false;
            ButtonLoop.Click += ButtonLoop_Click;
            // 
            // ButtonNext
            // 
            ButtonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ButtonNext.BackColor = System.Drawing.Color.Black;
            ButtonNext.BackgroundImage = Properties.Resources.Next;
            ButtonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonNext.FlatAppearance.BorderSize = 0;
            ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonNext.Location = new System.Drawing.Point(108, 10);
            ButtonNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new System.Drawing.Size(35, 29);
            ButtonNext.TabIndex = 0;
            ButtonNext.TabStop = false;
            ButtonNext.UseVisualStyleBackColor = false;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // ButtonShowAndHideList
            // 
            ButtonShowAndHideList.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ButtonShowAndHideList.BackColor = System.Drawing.Color.Black;
            ButtonShowAndHideList.BackgroundImage = Properties.Resources.ShownList;
            ButtonShowAndHideList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonShowAndHideList.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonShowAndHideList.FlatAppearance.BorderSize = 0;
            ButtonShowAndHideList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonShowAndHideList.Location = new System.Drawing.Point(152, 10);
            ButtonShowAndHideList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonShowAndHideList.Name = "ButtonShowAndHideList";
            ButtonShowAndHideList.Size = new System.Drawing.Size(35, 29);
            ButtonShowAndHideList.TabIndex = 0;
            ButtonShowAndHideList.TabStop = false;
            ButtonShowAndHideList.UseVisualStyleBackColor = false;
            ButtonShowAndHideList.Click += ShowAndHideMusicListToolStripMenuItem_Click;
            // 
            // ButtonPlayPause
            // 
            ButtonPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ButtonPlayPause.BackColor = System.Drawing.Color.Black;
            ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
            ButtonPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonPlayPause.FlatAppearance.BorderSize = 0;
            ButtonPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonPlayPause.Location = new System.Drawing.Point(55, 1);
            ButtonPlayPause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonPlayPause.Name = "ButtonPlayPause";
            ButtonPlayPause.Size = new System.Drawing.Size(47, 46);
            ButtonPlayPause.TabIndex = 0;
            ButtonPlayPause.TabStop = false;
            ButtonPlayPause.UseVisualStyleBackColor = false;
            ButtonPlayPause.Click += ButtonPlayPause_Click;
            // 
            // AppMenuStrip
            // 
            AppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, HelpToolStripMenuItem });
            AppMenuStrip.Location = new System.Drawing.Point(0, 0);
            AppMenuStrip.Name = "AppMenuStrip";
            AppMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            AppMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            AppMenuStrip.Size = new System.Drawing.Size(968, 24);
            AppMenuStrip.TabIndex = 20;
            AppMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenFileToolStripMenuItem, OpenToolStripMenuItem, toolStripSeparator, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            FileToolStripMenuItem.Text = "&File";
            // 
            // OpenFileToolStripMenuItem
            // 
            OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            OpenFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            OpenFileToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            OpenFileToolStripMenuItem.Text = "&Open File";
            OpenFileToolStripMenuItem.Click += OpenFilesToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.O;
            OpenToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            OpenToolStripMenuItem.Text = "&Open Folder";
            OpenToolStripMenuItem.Click += OpenFolderToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(211, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            ExitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            ExitToolStripMenuItem.Text = "E&xit";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { PlayAndPauseToolStripMenuItem, NextToolStripMenuItem, PreviousToolStripMenuItem, toolStripSeparator3, EditSongToolStripMenuItem, SortByToolStripMenuItem, toolStripSeparator4, ShuffleToolStripMenuItem, LoopModeToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            EditToolStripMenuItem.Text = "&Edit";
            // 
            // PlayAndPauseToolStripMenuItem
            // 
            PlayAndPauseToolStripMenuItem.Name = "PlayAndPauseToolStripMenuItem";
            PlayAndPauseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            PlayAndPauseToolStripMenuItem.Text = "Play";
            PlayAndPauseToolStripMenuItem.Click += ButtonPlayPause_Click;
            // 
            // NextToolStripMenuItem
            // 
            NextToolStripMenuItem.Name = "NextToolStripMenuItem";
            NextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            NextToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            NextToolStripMenuItem.Text = "&Next";
            NextToolStripMenuItem.Click += ButtonNext_Click;
            // 
            // PreviousToolStripMenuItem
            // 
            PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem";
            PreviousToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            PreviousToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            PreviousToolStripMenuItem.Text = "&Previous";
            PreviousToolStripMenuItem.Click += ButtonPreviousClick;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // EditSongToolStripMenuItem
            // 
            EditSongToolStripMenuItem.Name = "EditSongToolStripMenuItem";
            EditSongToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            EditSongToolStripMenuItem.Text = "Edit Song";
            EditSongToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // SortByToolStripMenuItem
            // 
            SortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { TitleToolStripMenuItem, ArtistToolStripMenuItem, AlbumToolStripMenuItem });
            SortByToolStripMenuItem.Name = "SortByToolStripMenuItem";
            SortByToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            SortByToolStripMenuItem.Text = "Sort by:";
            // 
            // TitleToolStripMenuItem
            // 
            TitleToolStripMenuItem.Name = "TitleToolStripMenuItem";
            TitleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            TitleToolStripMenuItem.Text = "Title";
            TitleToolStripMenuItem.Click += SortByTitleToolStripMenuItem_Click;
            // 
            // ArtistToolStripMenuItem
            // 
            ArtistToolStripMenuItem.Name = "ArtistToolStripMenuItem";
            ArtistToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            ArtistToolStripMenuItem.Text = "Artist";
            ArtistToolStripMenuItem.Click += SortByArtistToolStripMenuItem_Click;
            // 
            // AlbumToolStripMenuItem
            // 
            AlbumToolStripMenuItem.Name = "AlbumToolStripMenuItem";
            AlbumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            AlbumToolStripMenuItem.Text = "Album";
            AlbumToolStripMenuItem.Click += SortByAlbumToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // ShuffleToolStripMenuItem
            // 
            ShuffleToolStripMenuItem.Name = "ShuffleToolStripMenuItem";
            ShuffleToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            ShuffleToolStripMenuItem.Text = "Shuffle Play";
            ShuffleToolStripMenuItem.Click += ButtonShuffle_Click;
            // 
            // LoopModeToolStripMenuItem
            // 
            LoopModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { LoopModeOneToolStripMenuItem, LoopModeAllToolStripMenuItem, LoopModeOffToolStripMenuItem });
            LoopModeToolStripMenuItem.Name = "LoopModeToolStripMenuItem";
            LoopModeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            LoopModeToolStripMenuItem.Text = "Loop Mode";
            // 
            // LoopModeOneToolStripMenuItem
            // 
            LoopModeOneToolStripMenuItem.Name = "LoopModeOneToolStripMenuItem";
            LoopModeOneToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            LoopModeOneToolStripMenuItem.Text = "One";
            LoopModeOneToolStripMenuItem.Click += LoopModeOneToolStripMenuItem_Click;
            // 
            // LoopModeAllToolStripMenuItem
            // 
            LoopModeAllToolStripMenuItem.Name = "LoopModeAllToolStripMenuItem";
            LoopModeAllToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            LoopModeAllToolStripMenuItem.Text = "All";
            LoopModeAllToolStripMenuItem.Click += LoopModeAllToolStripMenuItem_Click;
            // 
            // LoopModeOffToolStripMenuItem
            // 
            LoopModeOffToolStripMenuItem.Checked = true;
            LoopModeOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            LoopModeOffToolStripMenuItem.Name = "LoopModeOffToolStripMenuItem";
            LoopModeOffToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            LoopModeOffToolStripMenuItem.Text = "Off";
            LoopModeOffToolStripMenuItem.Click += LoopModeOffToolStripMenuItem_Click;
            // 
            // ViewToolStripMenuItem
            // 
            ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ShowAndHideMusicListToolStripMenuItem, ShowAndHideSongLyricsToolStripMenuItem });
            ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            ViewToolStripMenuItem.Text = "&View";
            // 
            // ShowAndHideMusicListToolStripMenuItem
            // 
            ShowAndHideMusicListToolStripMenuItem.Name = "ShowAndHideMusicListToolStripMenuItem";
            ShowAndHideMusicListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            ShowAndHideMusicListToolStripMenuItem.Text = "Hide Music List";
            ShowAndHideMusicListToolStripMenuItem.Click += ShowAndHideMusicListToolStripMenuItem_Click;
            // 
            // ShowAndHideSongLyricsToolStripMenuItem
            // 
            ShowAndHideSongLyricsToolStripMenuItem.Name = "ShowAndHideSongLyricsToolStripMenuItem";
            ShowAndHideSongLyricsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            ShowAndHideSongLyricsToolStripMenuItem.Text = "Show Music Lyrics";
            ShowAndHideSongLyricsToolStripMenuItem.Click += ShowSongLyricsToolStripMenuItem_Click;
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            AboutToolStripMenuItem.Text = "About";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // AppTimer
            // 
            AppTimer.Enabled = true;
            AppTimer.Tick += AppTimer_Tick;
            // 
            // MusicPanelContextMenuStrip
            // 
            MusicPanelContextMenuStrip.BackColor = System.Drawing.Color.White;
            MusicPanelContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StartSongToolStripMenuItem, RemoveFromListToolStripMenuItem, toolStripSeparator1, ShowMusicLyricsToolStripMenuItem, EditToolStripMenuItem1, SortByToolContextMenuStriItem, toolStripSeparator2, ClearListToolStripMenuItem });
            MusicPanelContextMenuStrip.Name = "MusicPanelContextMenuStrip";
            MusicPanelContextMenuStrip.Size = new System.Drawing.Size(171, 148);
            // 
            // StartSongToolStripMenuItem
            // 
            StartSongToolStripMenuItem.BackColor = System.Drawing.Color.White;
            StartSongToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            StartSongToolStripMenuItem.Name = "StartSongToolStripMenuItem";
            StartSongToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            StartSongToolStripMenuItem.Text = "Start this Song";
            StartSongToolStripMenuItem.Click += StartSongToolStripMenuItem_Click;
            // 
            // RemoveFromListToolStripMenuItem
            // 
            RemoveFromListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            RemoveFromListToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            RemoveFromListToolStripMenuItem.Name = "RemoveFromListToolStripMenuItem";
            RemoveFromListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            RemoveFromListToolStripMenuItem.Text = "Remove From List";
            RemoveFromListToolStripMenuItem.Click += RemoveFromListToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // ShowMusicLyricsToolStripMenuItem
            // 
            ShowMusicLyricsToolStripMenuItem.Name = "ShowMusicLyricsToolStripMenuItem";
            ShowMusicLyricsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            ShowMusicLyricsToolStripMenuItem.Text = "Show Music Lyrics";
            ShowMusicLyricsToolStripMenuItem.Click += ShowMusicLyricsToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem1
            // 
            EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
            EditToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            EditToolStripMenuItem1.Text = "Edit";
            EditToolStripMenuItem1.Click += EditToolStripMenuItem_Click;
            // 
            // SortByToolContextMenuStriItem
            // 
            SortByToolContextMenuStriItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SortByTitleToolContextMenuStriItem, SortByArtistToolContextMenuStriItem, SortByAlbumToolContextMenuStriItem });
            SortByToolContextMenuStriItem.Name = "SortByToolContextMenuStriItem";
            SortByToolContextMenuStriItem.Size = new System.Drawing.Size(170, 22);
            SortByToolContextMenuStriItem.Text = "Sort by:";
            // 
            // SortByTitleToolContextMenuStriItem
            // 
            SortByTitleToolContextMenuStriItem.Name = "SortByTitleToolContextMenuStriItem";
            SortByTitleToolContextMenuStriItem.Size = new System.Drawing.Size(110, 22);
            SortByTitleToolContextMenuStriItem.Text = "Title";
            SortByTitleToolContextMenuStriItem.Click += SortByTitleToolStripMenuItem_Click;
            // 
            // SortByArtistToolContextMenuStriItem
            // 
            SortByArtistToolContextMenuStriItem.Name = "SortByArtistToolContextMenuStriItem";
            SortByArtistToolContextMenuStriItem.Size = new System.Drawing.Size(110, 22);
            SortByArtistToolContextMenuStriItem.Text = "Artist";
            SortByArtistToolContextMenuStriItem.Click += SortByArtistToolStripMenuItem_Click;
            // 
            // SortByAlbumToolContextMenuStriItem
            // 
            SortByAlbumToolContextMenuStriItem.Name = "SortByAlbumToolContextMenuStriItem";
            SortByAlbumToolContextMenuStriItem.Size = new System.Drawing.Size(110, 22);
            SortByAlbumToolContextMenuStriItem.Text = "Album";
            SortByAlbumToolContextMenuStriItem.Click += SortByAlbumToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // ClearListToolStripMenuItem
            // 
            ClearListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            ClearListToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem";
            ClearListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            ClearListToolStripMenuItem.Text = "Clear List";
            ClearListToolStripMenuItem.Click += ClearListToolStripMenuItem_Click;
            // 
            // PictureBoxMusicCover
            // 
            PictureBoxMusicCover.BackColor = System.Drawing.Color.Black;
            PictureBoxMusicCover.BackgroundImage = Properties.Resources.Melodify;
            PictureBoxMusicCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            PictureBoxMusicCover.Controls.Add(FlowLayoutPanelMusic);
            PictureBoxMusicCover.Dock = System.Windows.Forms.DockStyle.Fill;
            PictureBoxMusicCover.Location = new System.Drawing.Point(0, 24);
            PictureBoxMusicCover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PictureBoxMusicCover.Name = "PictureBoxMusicCover";
            PictureBoxMusicCover.Size = new System.Drawing.Size(968, 418);
            PictureBoxMusicCover.TabIndex = 0;
            // 
            // FlowLayoutPanelMusic
            // 
            FlowLayoutPanelMusic.AutoScroll = true;
            FlowLayoutPanelMusic.BackColor = System.Drawing.Color.Black;
            FlowLayoutPanelMusic.Dock = System.Windows.Forms.DockStyle.Right;
            FlowLayoutPanelMusic.ForeColor = System.Drawing.Color.White;
            FlowLayoutPanelMusic.Location = new System.Drawing.Point(752, 0);
            FlowLayoutPanelMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FlowLayoutPanelMusic.Name = "FlowLayoutPanelMusic";
            FlowLayoutPanelMusic.Size = new System.Drawing.Size(216, 418);
            FlowLayoutPanelMusic.TabIndex = 0;
            FlowLayoutPanelMusic.Paint += FlowLayoutPanelMusic_Paint;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(968, 494);
            Controls.Add(PictureBoxMusicCover);
            Controls.Add(AppMenuStrip);
            Controls.Add(PanelControls);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Melodify";
            FormClosing += Form_FormClosing;
            Load += MusicPlayer_Load;
            DragDrop += MusicPlayer_DragDrop;
            DragEnter += MusicPlayer_DragEnter;
            PanelControls.ResumeLayout(false);
            PanelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarVolumeState).EndInit();
            AppMenuStrip.ResumeLayout(false);
            AppMenuStrip.PerformLayout();
            MusicPanelContextMenuStrip.ResumeLayout(false);
            PictureBoxMusicCover.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel PictureBoxMusicCover;
        private System.Windows.Forms.Button ButtonPlayPause;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonShowAndHideList;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonLoop;
        private System.Windows.Forms.Button ButtonShuffle;
        private System.Windows.Forms.Label LabelMusicCurrentTimeState;
        private System.Windows.Forms.Label LabelMusicEndTime;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.MenuStrip AppMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayAndPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreviousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ShuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowAndHideMusicListToolStripMenuItem;
        private System.Windows.Forms.TrackBar TrackBarVolumeState;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelMusic;
        private System.Windows.Forms.Timer AppTimer;
        private PlaybackBarControl PlaybackBarControl;
        private System.Windows.Forms.ContextMenuStrip MusicPanelContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StartSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveFromListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EditSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ShowAndHideSongLyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem SortByTitleToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem SortByArtistToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem SortByAlbumToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowMusicLyricsToolStripMenuItem;
    }
}