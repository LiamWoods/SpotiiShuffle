namespace SpotiiShuffle
{
    partial class PlaylistItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlbumCover = new System.Windows.Forms.PictureBox();
            this.SongName = new System.Windows.Forms.Label();
            this.AlbumName = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCover)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumCover
            // 
            this.AlbumCover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumCover.Location = new System.Drawing.Point(3, 3);
            this.AlbumCover.Name = "AlbumCover";
            this.AlbumCover.Size = new System.Drawing.Size(87, 87);
            this.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumCover.TabIndex = 0;
            this.AlbumCover.TabStop = false;
            // 
            // SongName
            // 
            this.SongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.Color.White;
            this.SongName.Location = new System.Drawing.Point(96, 10);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(93, 20);
            this.SongName.TabIndex = 1;
            this.SongName.Text = "Song Name";
            // 
            // AlbumName
            // 
            this.AlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumName.ForeColor = System.Drawing.Color.White;
            this.AlbumName.Location = new System.Drawing.Point(96, 36);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(100, 20);
            this.AlbumName.TabIndex = 2;
            this.AlbumName.Text = "Album Name";
            // 
            // ArtistName
            // 
            this.ArtistName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtistName.AutoSize = true;
            this.ArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.ForeColor = System.Drawing.Color.White;
            this.ArtistName.Location = new System.Drawing.Point(96, 62);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(92, 20);
            this.ArtistName.TabIndex = 3;
            this.ArtistName.Text = "Artist Name";
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.AlbumName);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.AlbumCover);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(450, 93);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AlbumCover;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Label ArtistName;
    }
}
