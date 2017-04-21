using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotiiShuffle
{
    public partial class PlaylistItem : UserControl
    {
        public string SongURI = "";
        public string Song_Name = "";
        public string Artist_Name = "";
        public SpotifyAPI.Web.Models.FullTrack MySong;

        public PlaylistItem(string songURI, string imageURL, string songName, string albumName, string artistName, SpotifyAPI.Web.Models.FullTrack ThisSong)
        {
            InitializeComponent();

            this.SongURI = songURI;
            this.Song_Name = songName;
            this.Artist_Name = artistName;
            this.AlbumCover.ImageLocation = imageURL;
            this.SongName.Text = songName;
            this.AlbumName.Text = albumName;
            this.ArtistName.Text = artistName;
            MySong = ThisSong;

        }
    }
}
