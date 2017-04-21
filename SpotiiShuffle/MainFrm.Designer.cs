namespace SpotiiShuffle
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.SongsSplitPanel = new System.Windows.Forms.SplitContainer();
            this.CurrentSongTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RedX3Panel = new System.Windows.Forms.Panel();
            this.RedXLbl3 = new System.Windows.Forms.Label();
            this.RedX3Img = new System.Windows.Forms.PictureBox();
            this.RedX2Panel = new System.Windows.Forms.Panel();
            this.RedXLbl2 = new System.Windows.Forms.Label();
            this.RedX2Img = new System.Windows.Forms.PictureBox();
            this.RedX1Panel = new System.Windows.Forms.Panel();
            this.RedXLbl1 = new System.Windows.Forms.Label();
            this.RedX1Img = new System.Windows.Forms.PictureBox();
            this.CurrentSongPanel = new System.Windows.Forms.Panel();
            this.AlbumCoverArt = new System.Windows.Forms.PictureBox();
            this.ArtistName = new System.Windows.Forms.Label();
            this.AlbumName = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.CurrentSongHeaderPanel = new System.Windows.Forms.Panel();
            this.CurrentSongLbl = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.FlowPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.NextSongsHeaderPanel = new System.Windows.Forms.Panel();
            this.NextSongsLbl = new System.Windows.Forms.Label();
            this.ShuffleBtn = new System.Windows.Forms.Button();
            this.ControlBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeTimeModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShuffleWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.HomeTimeMode = new System.Windows.Forms.Timer(this.components);
            this.SongControlsPanel = new System.Windows.Forms.Panel();
            this.ProgressEndLbl = new System.Windows.Forms.Label();
            this.ProgressStartLbl = new System.Windows.Forms.Label();
            this.PlaylistsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MainSplitPanel = new System.Windows.Forms.SplitContainer();
            this.PlaylistsHeaderPanel = new System.Windows.Forms.Panel();
            this.PlaylistsLbl = new System.Windows.Forms.Label();
            this.CheckForNewSongs = new System.Windows.Forms.Timer(this.components);
            this.NoSkipTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckSongsWorker = new System.ComponentModel.BackgroundWorker();
            this.RemoveSongTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SongsSplitPanel)).BeginInit();
            this.SongsSplitPanel.Panel1.SuspendLayout();
            this.SongsSplitPanel.Panel2.SuspendLayout();
            this.SongsSplitPanel.SuspendLayout();
            this.CurrentSongTableLayout.SuspendLayout();
            this.RedX3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedX3Img)).BeginInit();
            this.RedX2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedX2Img)).BeginInit();
            this.RedX1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedX1Img)).BeginInit();
            this.CurrentSongPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverArt)).BeginInit();
            this.CurrentSongHeaderPanel.SuspendLayout();
            this.NextSongsHeaderPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SongControlsPanel.SuspendLayout();
            this.PlaylistsFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitPanel)).BeginInit();
            this.MainSplitPanel.Panel1.SuspendLayout();
            this.MainSplitPanel.Panel2.SuspendLayout();
            this.MainSplitPanel.SuspendLayout();
            this.PlaylistsHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SongsSplitPanel
            // 
            this.SongsSplitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SongsSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongsSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SongsSplitPanel.IsSplitterFixed = true;
            this.SongsSplitPanel.Location = new System.Drawing.Point(0, 0);
            this.SongsSplitPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SongsSplitPanel.Name = "SongsSplitPanel";
            this.SongsSplitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SongsSplitPanel.Panel1
            // 
            this.SongsSplitPanel.Panel1.AutoScroll = true;
            this.SongsSplitPanel.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.SongsSplitPanel.Panel1.Controls.Add(this.CurrentSongTableLayout);
            this.SongsSplitPanel.Panel1.Controls.Add(this.CurrentSongHeaderPanel);
            // 
            // SongsSplitPanel.Panel2
            // 
            this.SongsSplitPanel.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.SongsSplitPanel.Panel2.Controls.Add(this.FlowPlaylist);
            this.SongsSplitPanel.Panel2.Controls.Add(this.NextSongsHeaderPanel);
            this.SongsSplitPanel.Size = new System.Drawing.Size(1079, 573);
            this.SongsSplitPanel.SplitterDistance = 225;
            this.SongsSplitPanel.SplitterWidth = 5;
            this.SongsSplitPanel.TabIndex = 1;
            // 
            // CurrentSongTableLayout
            // 
            this.CurrentSongTableLayout.ColumnCount = 4;
            this.CurrentSongTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.CurrentSongTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CurrentSongTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CurrentSongTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CurrentSongTableLayout.Controls.Add(this.RedX3Panel, 3, 0);
            this.CurrentSongTableLayout.Controls.Add(this.RedX2Panel, 2, 0);
            this.CurrentSongTableLayout.Controls.Add(this.RedX1Panel, 1, 0);
            this.CurrentSongTableLayout.Controls.Add(this.CurrentSongPanel, 0, 0);
            this.CurrentSongTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentSongTableLayout.Location = new System.Drawing.Point(0, 41);
            this.CurrentSongTableLayout.Name = "CurrentSongTableLayout";
            this.CurrentSongTableLayout.RowCount = 1;
            this.CurrentSongTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentSongTableLayout.Size = new System.Drawing.Size(1079, 184);
            this.CurrentSongTableLayout.TabIndex = 5;
            // 
            // RedX3Panel
            // 
            this.RedX3Panel.Controls.Add(this.RedXLbl3);
            this.RedX3Panel.Controls.Add(this.RedX3Img);
            this.RedX3Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedX3Panel.Location = new System.Drawing.Point(918, 3);
            this.RedX3Panel.Name = "RedX3Panel";
            this.RedX3Panel.Size = new System.Drawing.Size(158, 178);
            this.RedX3Panel.TabIndex = 3;
            this.RedX3Panel.Visible = false;
            // 
            // RedXLbl3
            // 
            this.RedXLbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedXLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedXLbl3.ForeColor = System.Drawing.Color.White;
            this.RedXLbl3.Location = new System.Drawing.Point(0, 139);
            this.RedXLbl3.Name = "RedXLbl3";
            this.RedXLbl3.Size = new System.Drawing.Size(158, 39);
            this.RedXLbl3.TabIndex = 2;
            this.RedXLbl3.Text = "Person 3";
            this.RedXLbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedX3Img
            // 
            this.RedX3Img.Dock = System.Windows.Forms.DockStyle.Top;
            this.RedX3Img.Image = ((System.Drawing.Image)(resources.GetObject("RedX3Img.Image")));
            this.RedX3Img.Location = new System.Drawing.Point(0, 0);
            this.RedX3Img.Name = "RedX3Img";
            this.RedX3Img.Size = new System.Drawing.Size(158, 139);
            this.RedX3Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedX3Img.TabIndex = 1;
            this.RedX3Img.TabStop = false;
            // 
            // RedX2Panel
            // 
            this.RedX2Panel.Controls.Add(this.RedXLbl2);
            this.RedX2Panel.Controls.Add(this.RedX2Img);
            this.RedX2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedX2Panel.Location = new System.Drawing.Point(757, 3);
            this.RedX2Panel.Name = "RedX2Panel";
            this.RedX2Panel.Size = new System.Drawing.Size(155, 178);
            this.RedX2Panel.TabIndex = 2;
            this.RedX2Panel.Visible = false;
            // 
            // RedXLbl2
            // 
            this.RedXLbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedXLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedXLbl2.ForeColor = System.Drawing.Color.White;
            this.RedXLbl2.Location = new System.Drawing.Point(0, 139);
            this.RedXLbl2.Name = "RedXLbl2";
            this.RedXLbl2.Size = new System.Drawing.Size(155, 39);
            this.RedXLbl2.TabIndex = 2;
            this.RedXLbl2.Text = "Person 2";
            this.RedXLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedX2Img
            // 
            this.RedX2Img.Dock = System.Windows.Forms.DockStyle.Top;
            this.RedX2Img.Image = ((System.Drawing.Image)(resources.GetObject("RedX2Img.Image")));
            this.RedX2Img.Location = new System.Drawing.Point(0, 0);
            this.RedX2Img.Name = "RedX2Img";
            this.RedX2Img.Size = new System.Drawing.Size(155, 139);
            this.RedX2Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedX2Img.TabIndex = 1;
            this.RedX2Img.TabStop = false;
            // 
            // RedX1Panel
            // 
            this.RedX1Panel.BackColor = System.Drawing.Color.Transparent;
            this.RedX1Panel.Controls.Add(this.RedXLbl1);
            this.RedX1Panel.Controls.Add(this.RedX1Img);
            this.RedX1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedX1Panel.Location = new System.Drawing.Point(596, 3);
            this.RedX1Panel.Name = "RedX1Panel";
            this.RedX1Panel.Size = new System.Drawing.Size(155, 178);
            this.RedX1Panel.TabIndex = 1;
            this.RedX1Panel.Visible = false;
            // 
            // RedXLbl1
            // 
            this.RedXLbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedXLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedXLbl1.ForeColor = System.Drawing.Color.White;
            this.RedXLbl1.Location = new System.Drawing.Point(0, 139);
            this.RedXLbl1.Name = "RedXLbl1";
            this.RedXLbl1.Size = new System.Drawing.Size(155, 39);
            this.RedXLbl1.TabIndex = 1;
            this.RedXLbl1.Text = "Person 1";
            this.RedXLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedX1Img
            // 
            this.RedX1Img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.RedX1Img.Dock = System.Windows.Forms.DockStyle.Top;
            this.RedX1Img.Image = ((System.Drawing.Image)(resources.GetObject("RedX1Img.Image")));
            this.RedX1Img.Location = new System.Drawing.Point(0, 0);
            this.RedX1Img.Name = "RedX1Img";
            this.RedX1Img.Size = new System.Drawing.Size(155, 139);
            this.RedX1Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedX1Img.TabIndex = 0;
            this.RedX1Img.TabStop = false;
            // 
            // CurrentSongPanel
            // 
            this.CurrentSongPanel.Controls.Add(this.AlbumCoverArt);
            this.CurrentSongPanel.Controls.Add(this.ArtistName);
            this.CurrentSongPanel.Controls.Add(this.AlbumName);
            this.CurrentSongPanel.Controls.Add(this.SongName);
            this.CurrentSongPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentSongPanel.Location = new System.Drawing.Point(3, 3);
            this.CurrentSongPanel.Name = "CurrentSongPanel";
            this.CurrentSongPanel.Size = new System.Drawing.Size(587, 178);
            this.CurrentSongPanel.TabIndex = 0;
            // 
            // AlbumCoverArt
            // 
            this.AlbumCoverArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumCoverArt.Location = new System.Drawing.Point(6, 7);
            this.AlbumCoverArt.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumCoverArt.Name = "AlbumCoverArt";
            this.AlbumCoverArt.Size = new System.Drawing.Size(173, 164);
            this.AlbumCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumCoverArt.TabIndex = 0;
            this.AlbumCoverArt.TabStop = false;
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.ForeColor = System.Drawing.Color.White;
            this.ArtistName.Location = new System.Drawing.Point(187, 53);
            this.ArtistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(92, 20);
            this.ArtistName.TabIndex = 3;
            this.ArtistName.Text = "Artist Name";
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumName.ForeColor = System.Drawing.Color.White;
            this.AlbumName.Location = new System.Drawing.Point(187, 86);
            this.AlbumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(100, 20);
            this.AlbumName.TabIndex = 4;
            this.AlbumName.Text = "Album Name";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.Color.White;
            this.SongName.Location = new System.Drawing.Point(187, 20);
            this.SongName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(93, 20);
            this.SongName.TabIndex = 2;
            this.SongName.Text = "Song Name";
            // 
            // CurrentSongHeaderPanel
            // 
            this.CurrentSongHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.CurrentSongHeaderPanel.Controls.Add(this.CurrentSongLbl);
            this.CurrentSongHeaderPanel.Controls.Add(this.counter);
            this.CurrentSongHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentSongHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.CurrentSongHeaderPanel.Name = "CurrentSongHeaderPanel";
            this.CurrentSongHeaderPanel.Size = new System.Drawing.Size(1079, 41);
            this.CurrentSongHeaderPanel.TabIndex = 1;
            // 
            // CurrentSongLbl
            // 
            this.CurrentSongLbl.AutoSize = true;
            this.CurrentSongLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSongLbl.ForeColor = System.Drawing.Color.White;
            this.CurrentSongLbl.Location = new System.Drawing.Point(3, 4);
            this.CurrentSongLbl.Name = "CurrentSongLbl";
            this.CurrentSongLbl.Size = new System.Drawing.Size(153, 26);
            this.CurrentSongLbl.TabIndex = 0;
            this.CurrentSongLbl.Text = "Current Song";
            // 
            // counter
            // 
            this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.ForeColor = System.Drawing.Color.White;
            this.counter.Location = new System.Drawing.Point(900, 9);
            this.counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(66, 20);
            this.counter.TabIndex = 0;
            this.counter.Text = "Counter";
            // 
            // FlowPlaylist
            // 
            this.FlowPlaylist.AutoScroll = true;
            this.FlowPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.FlowPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPlaylist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPlaylist.Location = new System.Drawing.Point(0, 41);
            this.FlowPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.FlowPlaylist.Name = "FlowPlaylist";
            this.FlowPlaylist.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.FlowPlaylist.Size = new System.Drawing.Size(1079, 302);
            this.FlowPlaylist.TabIndex = 1;
            this.FlowPlaylist.WrapContents = false;
            // 
            // NextSongsHeaderPanel
            // 
            this.NextSongsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.NextSongsHeaderPanel.Controls.Add(this.NextSongsLbl);
            this.NextSongsHeaderPanel.Controls.Add(this.ShuffleBtn);
            this.NextSongsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NextSongsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.NextSongsHeaderPanel.Name = "NextSongsHeaderPanel";
            this.NextSongsHeaderPanel.Size = new System.Drawing.Size(1079, 41);
            this.NextSongsHeaderPanel.TabIndex = 0;
            // 
            // NextSongsLbl
            // 
            this.NextSongsLbl.AutoSize = true;
            this.NextSongsLbl.BackColor = System.Drawing.Color.Transparent;
            this.NextSongsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextSongsLbl.ForeColor = System.Drawing.Color.White;
            this.NextSongsLbl.Location = new System.Drawing.Point(3, 4);
            this.NextSongsLbl.Name = "NextSongsLbl";
            this.NextSongsLbl.Size = new System.Drawing.Size(135, 26);
            this.NextSongsLbl.TabIndex = 0;
            this.NextSongsLbl.Text = "Next Songs";
            // 
            // ShuffleBtn
            // 
            this.ShuffleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShuffleBtn.Location = new System.Drawing.Point(980, 3);
            this.ShuffleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ShuffleBtn.Name = "ShuffleBtn";
            this.ShuffleBtn.Size = new System.Drawing.Size(95, 35);
            this.ShuffleBtn.TabIndex = 0;
            this.ShuffleBtn.Text = "Reshuffle";
            this.ShuffleBtn.UseVisualStyleBackColor = true;
            this.ShuffleBtn.Click += new System.EventHandler(this.ShuffleBtn_Click);
            // 
            // ControlBtn
            // 
            this.ControlBtn.Location = new System.Drawing.Point(4, 7);
            this.ControlBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ControlBtn.Name = "ControlBtn";
            this.ControlBtn.Size = new System.Drawing.Size(125, 39);
            this.ControlBtn.TabIndex = 0;
            this.ControlBtn.Text = "Pause";
            this.ControlBtn.UseVisualStyleBackColor = true;
            this.ControlBtn.Click += new System.EventHandler(this.ControlBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(137, 7);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(125, 39);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(327, 12);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(900, 28);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectPlaylistToolStripMenuItem,
            this.homeTimeModToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1296, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectPlaylistToolStripMenuItem
            // 
            this.selectPlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectPlaylistToolStripMenuItem.Name = "selectPlaylistToolStripMenuItem";
            this.selectPlaylistToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.selectPlaylistToolStripMenuItem.Text = "Select Playlist";
            this.selectPlaylistToolStripMenuItem.Visible = false;
            // 
            // homeTimeModToolStripMenuItem
            // 
            this.homeTimeModToolStripMenuItem.Checked = true;
            this.homeTimeModToolStripMenuItem.CheckOnClick = true;
            this.homeTimeModToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.homeTimeModToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeTimeModToolStripMenuItem.Name = "homeTimeModToolStripMenuItem";
            this.homeTimeModToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.homeTimeModToolStripMenuItem.Text = "HomeTime Mode = DISABLED";
            this.homeTimeModToolStripMenuItem.Click += new System.EventHandler(this.homeTimeModToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // ShuffleWorker
            // 
            this.ShuffleWorker.WorkerSupportsCancellation = true;
            this.ShuffleWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ShuffleWorker_DoWork);
            this.ShuffleWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ShuffleWorker_RunWorkerCompleted);
            // 
            // HomeTimeMode
            // 
            this.HomeTimeMode.Interval = 10000;
            this.HomeTimeMode.Tick += new System.EventHandler(this.HomeTimeMode_Tick);
            // 
            // SongControlsPanel
            // 
            this.SongControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SongControlsPanel.Controls.Add(this.ProgressEndLbl);
            this.SongControlsPanel.Controls.Add(this.ProgressStartLbl);
            this.SongControlsPanel.Controls.Add(this.ControlBtn);
            this.SongControlsPanel.Controls.Add(this.NextBtn);
            this.SongControlsPanel.Controls.Add(this.progressBar1);
            this.SongControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SongControlsPanel.Location = new System.Drawing.Point(0, 597);
            this.SongControlsPanel.Name = "SongControlsPanel";
            this.SongControlsPanel.Size = new System.Drawing.Size(1296, 53);
            this.SongControlsPanel.TabIndex = 2;
            // 
            // ProgressEndLbl
            // 
            this.ProgressEndLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressEndLbl.AutoSize = true;
            this.ProgressEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressEndLbl.ForeColor = System.Drawing.Color.White;
            this.ProgressEndLbl.Location = new System.Drawing.Point(1234, 16);
            this.ProgressEndLbl.Name = "ProgressEndLbl";
            this.ProgressEndLbl.Size = new System.Drawing.Size(44, 17);
            this.ProgressEndLbl.TabIndex = 4;
            this.ProgressEndLbl.Text = "00:00";
            // 
            // ProgressStartLbl
            // 
            this.ProgressStartLbl.AutoSize = true;
            this.ProgressStartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressStartLbl.ForeColor = System.Drawing.Color.White;
            this.ProgressStartLbl.Location = new System.Drawing.Point(270, 16);
            this.ProgressStartLbl.Name = "ProgressStartLbl";
            this.ProgressStartLbl.Size = new System.Drawing.Size(44, 17);
            this.ProgressStartLbl.TabIndex = 3;
            this.ProgressStartLbl.Text = "00:00";
            // 
            // PlaylistsFlowPanel
            // 
            this.PlaylistsFlowPanel.AutoScroll = true;
            this.PlaylistsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.PlaylistsFlowPanel.Controls.Add(this.button1);
            this.PlaylistsFlowPanel.Controls.Add(this.button2);
            this.PlaylistsFlowPanel.Controls.Add(this.button3);
            this.PlaylistsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaylistsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PlaylistsFlowPanel.Location = new System.Drawing.Point(0, 41);
            this.PlaylistsFlowPanel.Name = "PlaylistsFlowPanel";
            this.PlaylistsFlowPanel.Size = new System.Drawing.Size(213, 532);
            this.PlaylistsFlowPanel.TabIndex = 0;
            this.PlaylistsFlowPanel.WrapContents = false;
            this.PlaylistsFlowPanel.Resize += new System.EventHandler(this.PlaylistsFlowPanel_Resize);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(166)))), ((int)(((byte)(213)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 76);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MainSplitPanel
            // 
            this.MainSplitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.MainSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitPanel.IsSplitterFixed = true;
            this.MainSplitPanel.Location = new System.Drawing.Point(0, 24);
            this.MainSplitPanel.Name = "MainSplitPanel";
            // 
            // MainSplitPanel.Panel1
            // 
            this.MainSplitPanel.Panel1.Controls.Add(this.PlaylistsFlowPanel);
            this.MainSplitPanel.Panel1.Controls.Add(this.PlaylistsHeaderPanel);
            // 
            // MainSplitPanel.Panel2
            // 
            this.MainSplitPanel.Panel2.Controls.Add(this.SongsSplitPanel);
            this.MainSplitPanel.Size = new System.Drawing.Size(1296, 573);
            this.MainSplitPanel.SplitterDistance = 213;
            this.MainSplitPanel.TabIndex = 5;
            // 
            // PlaylistsHeaderPanel
            // 
            this.PlaylistsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.PlaylistsHeaderPanel.Controls.Add(this.PlaylistsLbl);
            this.PlaylistsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaylistsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.PlaylistsHeaderPanel.Name = "PlaylistsHeaderPanel";
            this.PlaylistsHeaderPanel.Size = new System.Drawing.Size(213, 41);
            this.PlaylistsHeaderPanel.TabIndex = 2;
            // 
            // PlaylistsLbl
            // 
            this.PlaylistsLbl.AutoSize = true;
            this.PlaylistsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistsLbl.ForeColor = System.Drawing.Color.White;
            this.PlaylistsLbl.Location = new System.Drawing.Point(3, 4);
            this.PlaylistsLbl.Name = "PlaylistsLbl";
            this.PlaylistsLbl.Size = new System.Drawing.Size(102, 26);
            this.PlaylistsLbl.TabIndex = 0;
            this.PlaylistsLbl.Text = "Playlists";
            // 
            // CheckForNewSongs
            // 
            this.CheckForNewSongs.Enabled = true;
            this.CheckForNewSongs.Interval = 10000;
            this.CheckForNewSongs.Tick += new System.EventHandler(this.CheckForNewSongs_Tick);
            // 
            // NoSkipTimer
            // 
            this.NoSkipTimer.Interval = 4000;
            this.NoSkipTimer.Tick += new System.EventHandler(this.NoSkipTimer_Tick);
            // 
            // CheckSongsWorker
            // 
            this.CheckSongsWorker.WorkerReportsProgress = true;
            this.CheckSongsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CheckSongsWorker_DoWork);
            this.CheckSongsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CheckSongsWorker_RunWorkerCompleted);
            // 
            // RemoveSongTimer
            // 
            this.RemoveSongTimer.Interval = 10000;
            this.RemoveSongTimer.Tick += new System.EventHandler(this.RemoveSongTimer_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1296, 650);
            this.Controls.Add(this.MainSplitPanel);
            this.Controls.Add(this.SongControlsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotiiShuffle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.SongsSplitPanel.Panel1.ResumeLayout(false);
            this.SongsSplitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SongsSplitPanel)).EndInit();
            this.SongsSplitPanel.ResumeLayout(false);
            this.CurrentSongTableLayout.ResumeLayout(false);
            this.RedX3Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RedX3Img)).EndInit();
            this.RedX2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RedX2Img)).EndInit();
            this.RedX1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RedX1Img)).EndInit();
            this.CurrentSongPanel.ResumeLayout(false);
            this.CurrentSongPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverArt)).EndInit();
            this.CurrentSongHeaderPanel.ResumeLayout(false);
            this.CurrentSongHeaderPanel.PerformLayout();
            this.NextSongsHeaderPanel.ResumeLayout(false);
            this.NextSongsHeaderPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SongControlsPanel.ResumeLayout(false);
            this.SongControlsPanel.PerformLayout();
            this.PlaylistsFlowPanel.ResumeLayout(false);
            this.MainSplitPanel.Panel1.ResumeLayout(false);
            this.MainSplitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitPanel)).EndInit();
            this.MainSplitPanel.ResumeLayout(false);
            this.PlaylistsHeaderPanel.ResumeLayout(false);
            this.PlaylistsHeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer SongsSplitPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FlowLayoutPanel FlowPlaylist;
        private System.Windows.Forms.Button ShuffleBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label counter;
        private System.ComponentModel.BackgroundWorker ShuffleWorker;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectPlaylistToolStripMenuItem;
        private System.Windows.Forms.Button ControlBtn;
        private System.Windows.Forms.ToolStripMenuItem homeTimeModToolStripMenuItem;
        private System.Windows.Forms.Timer HomeTimeMode;
        private System.Windows.Forms.Panel NextSongsHeaderPanel;
        private System.Windows.Forms.Label NextSongsLbl;
        private System.Windows.Forms.Panel CurrentSongHeaderPanel;
        private System.Windows.Forms.Label CurrentSongLbl;
        private System.Windows.Forms.Panel SongControlsPanel;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel PlaylistsFlowPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer MainSplitPanel;
        private System.Windows.Forms.Panel PlaylistsHeaderPanel;
        private System.Windows.Forms.Label PlaylistsLbl;
        private System.Windows.Forms.TableLayoutPanel CurrentSongTableLayout;
        private System.Windows.Forms.Panel RedX3Panel;
        private System.Windows.Forms.Panel RedX2Panel;
        private System.Windows.Forms.Panel RedX1Panel;
        private System.Windows.Forms.PictureBox RedX3Img;
        private System.Windows.Forms.PictureBox RedX2Img;
        private System.Windows.Forms.PictureBox RedX1Img;
        private System.Windows.Forms.Label RedXLbl1;
        private System.Windows.Forms.Label RedXLbl3;
        private System.Windows.Forms.Label RedXLbl2;
        private System.Windows.Forms.Label ProgressEndLbl;
        private System.Windows.Forms.Label ProgressStartLbl;
        private System.Windows.Forms.Panel CurrentSongPanel;
        private System.Windows.Forms.PictureBox AlbumCoverArt;
        private System.Windows.Forms.Label ArtistName;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Timer CheckForNewSongs;
        private System.Windows.Forms.Timer NoSkipTimer;
        private System.ComponentModel.BackgroundWorker CheckSongsWorker;
        private System.Windows.Forms.Timer RemoveSongTimer;
    }
}

