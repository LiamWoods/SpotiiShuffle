using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Local;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses
using ChatSharp; // IRC.
using System.Diagnostics;

namespace SpotiiShuffle
{
    public partial class MainFrm : Form
    {
        private SpotifyLocalAPI SpotifyAPIObject; // local use
        private List<PlaylistItem> PlaylistOfSongs; // shuffled playlist
        private SpotifyWebAPI _spotify; // spotify web
        private Paging<PlaylistTrack> Tracks; // used to store playlist track repsonses
        private int length; // length of song
        private string UserID = ""; // used to store user ID
        private int total; // used to store total songs
        private int current = 1; // used to identify current song.
        private Color _ColourThemeDark = Color.FromArgb(0, 47, 47);
        private Color _ColourThemeLight = Color.FromArgb(4, 99, 128);

        private IrcClient client;
        private List<string> usersVoted;
        private List<string> usersVotedShuffle;
        private IrcChannel channel;

        private bool NoSkip = false;
        private bool snackgiven = false;

        private string LastSong = "";
        private SimplePlaylist SelectedPlaylist;
        private PlaylistItem HomeTimeItem;

        private string CurrentlyPlaying = "";
        private string Token;
        private Dictionary<string, string> Moderators;

        public MainFrm()
        {
            InitializeComponent();
            BootUpSpotify();
            SpotifyAPIObject = new SpotifyLocalAPI();
            _spotify = new SpotifyWebAPI();
            PlaylistOfSongs = new List<PlaylistItem>();
            usersVoted = new List<string>();
            usersVotedShuffle = new List<string>();
            dynamic json = Newtonsoft.Json.Linq.JObject.Parse(System.IO.File.ReadAllText("config.json"));
            if(json.clienttoken.ToString() == "TOKEN")
            {
                MessageBox.Show("Please update the config.json in order to use this application.");
                Application.Exit();
                return;
            }
            client = new IrcClient(json.ircdetails.hostname.ToString(), new IrcUser(json.ircdetails.nickname.ToString(), json.ircdetails.username.ToString(), json.ircdetails.password.ToString()), bool.Parse(json.ircdetails.usessl.ToString()));
            Token = json.clienttoken.ToString();
            client.IgnoreInvalidSSL = true;
            client.ConnectAsync();
            client.ConnectionComplete += Client_ConnectionComplete;
            client.ChannelMessageRecieved += Client_ChannelMessageRecieved;
            client.PrivateMessageRecieved += Client_PrivateMessageRecieved;
            Moderators = new Dictionary<string, string>();
            foreach(var Tok in json.ircdetails.moderators)
            {
                Moderators.Add(Tok.Name, Tok.Value.ToString());
            }
        }

        private void Client_PrivateMessageRecieved(object sender, ChatSharp.Events.PrivateMessageEventArgs e)
        {

            if (Moderators.Keys.Contains(e.PrivateMessage.User.User))
            {
                try
                {
                    string[] command = e.PrivateMessage.Message.Split(' ');
                    switch (command[0])
                    {
                        case "!fix":
                            progressBar1_Click(null, null);
                            break;
                        case "!boost":
                            if (BoostSong(command[1], command[2]))
                            {
                                PMUser("Your song has been added to the queue!", e.PrivateMessage.User.Nick);
                                if (!SpotifyAPIObject.GetStatus().Playing)
                                {
                                    NextSong();
                                }
                            }
                            else
                            {
                                PMUser("Error: Song URI not in right format.", e.PrivateMessage.User.Nick);
                            }
                            break;
                        case "!hometime":
                            FullTrack HomeTimeTrack = _spotify.GetTrack(command[1].Substring(command[1].LastIndexOf(':') + 1));
                            HomeTimeItem = getInfoFromTrack(HomeTimeTrack);
                            if (HomeTimeTrack.HasError())
                            {
                                if (HomeTimeTrack.Error.Status == 400)
                                {
                                    PMUser("Error: Song URI not in right format.", e.PrivateMessage.User.Nick);
                                    break;
                                }
                                else if (HomeTimeTrack.Error.Status == 500)
                                {
                                    doAuth();
                                    HomeTimeTrack = _spotify.GetTrack(command[1].Substring(command[1].LastIndexOf(':') + 1));
                                    HomeTimeItem = getInfoFromTrack(HomeTimeTrack);
                                }
                            }
                            foreach (string mod in Moderators.Values)
                            {
                                PMUser($"Hometime mode song changed to '{HomeTimeTrack.Name}' by {e.PrivateMessage.User.Nick}", mod);
                            }
                            break;
                        case "!msg":
                            string to = command[1];
                            string msg = string.Join(" ", command.ToList().Skip(2).ToArray());
                            PMUser(msg, to);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    PMUser("Error: " + ex.Message, e.PrivateMessage.User.Nick);
                }

            }
        }

        private void PMUser(string msg, string nickname)
        {
            client.SendMessage(msg, nickname);
        }

        private bool BoostSong(string index, string spotifyuri)
        {
            bool retval = true;
            try
            {
                int SongPosition = int.Parse(index);
                spotifyuri = spotifyuri.Substring(spotifyuri.LastIndexOf(':') + 1);
                FullTrack RequestedSong = _spotify.GetTrack(spotifyuri);
                if (RequestedSong.HasError() && RequestedSong.Error.Status == 400)
                {
                    return false;
                }
                if (RequestedSong.HasError())
                {
                    doAuth();
                    RequestedSong = _spotify.GetTrack(spotifyuri);
                }

                string SongURI = RequestedSong.Uri;
                string SongName = RequestedSong.Name;
                string AlbumName = RequestedSong.Album.Name;
                string AlbumImage = RequestedSong.Album.Images.FirstOrDefault().Url;
                string ArtistName = RequestedSong.Artists[0].Name;


                PlaylistItem control = new PlaylistItem(SongURI, AlbumImage, SongName, AlbumName, ArtistName, RequestedSong);
                if (FlowPlaylist.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        FlowPlaylist.Controls.Add(control);
                        FlowPlaylist.Controls.SetChildIndex(control, SongPosition);
                        PlaylistOfSongs.Insert(SongPosition, control);
                    }));
                }
                else
                {
                    FlowPlaylist.Controls.Add(control);
                    FlowPlaylist.Controls.SetChildIndex(control, SongPosition);
                    PlaylistOfSongs.Insert(SongPosition, control);
                }

            }
            catch (Exception)
            {
                retval = false;
            }
            return retval;
        }

        private void Client_ConnectionComplete(object sender, EventArgs e)
        {
            client.JoinChannel("#spotify");
        }

        private void Client_ChannelMessageRecieved(object sender, ChatSharp.Events.PrivateMessageEventArgs e)
        {
            string name = e.IrcMessage.Prefix.Substring(0, e.IrcMessage.Prefix.IndexOf("!")).Trim();
            string command = e.IrcMessage.Parameters[1];
            string recivedin = e.IrcMessage.Parameters[0];
            channel = client.Channels.FirstOrDefault();
            if (command.Contains("botsnack"))
            {
                snackgiven = true;
            }
            if (name.ToLower() == "hubot" && snackgiven)
            {
                PMUser("Hubot is always stealing the snacks, greedy little robot.", recivedin);
                snackgiven = false;
            }
            CheckCommand(name, command);
        }

        private void CheckCommand(string user, string command)
        {
            switch (command.ToLower().Trim())
            {
                case "!skip":
                    if (usersVoted.Contains(user) || NoSkipTimer.Enabled == true)
                    {
                        return;
                    }
                    else
                    {
                        usersVoted.Add(user);
                    }
                    try
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke((MethodInvoker)(() =>
                            {
                                switch (usersVoted.Count)
                                {
                                    case 1:
                                        RedXLbl1.Text = user;
                                        RedX1Panel.Visible = true;
                                        break;
                                    case 2:
                                        RedXLbl2.Text = user;
                                        RedX2Panel.Visible = true;
                                        break;
                                    case 3:
                                        RedXLbl3.Text = user;
                                        RedX3Panel.Visible = true;
                                        channel.SendMessage(CurrentlyPlaying + " has been skipped.");
                                        NoSkipTimer.Start();
                                        if (RemoveSongTimer.Enabled)
                                        {
                                            RemoveSongTimer.Stop();
                                            PlaylistItem PI = (PlaylistItem)CurrentSongPanel.Controls[0];
                                            _spotify.RemovePlaylistTrack(UserID, SelectedPlaylist.Id, new DeleteTrackUri(PI.MySong.Uri));

                                        }
                                        RemoveSongTimer.Start();
                                        NextSong();
                                        break;
                                    default:
                                        break;
                                }
                            }));
                        }
                        else
                        {
                            switch (usersVoted.Count)
                            {
                                case 1:
                                    RedXLbl1.Text = user;
                                    RedX1Panel.Visible = true;
                                    break;
                                case 2:
                                    RedXLbl2.Text = user;
                                    RedX2Panel.Visible = true;
                                    break;
                                case 3:
                                    RedXLbl3.Text = user;
                                    RedX3Panel.Visible = true;
                                    channel.SendMessage(CurrentlyPlaying + " has been skipped.");
                                    NoSkipTimer.Start();
                                    if (RemoveSongTimer.Enabled)
                                    {
                                        RemoveSongTimer.Stop();
                                        PlaylistItem PI = (PlaylistItem)CurrentSongPanel.Controls[0];
                                        _spotify.RemovePlaylistTrack(UserID, SelectedPlaylist.Id, new DeleteTrackUri(PI.MySong.Uri));

                                    }
                                    RemoveSongTimer.Start(); NextSong();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }

                    break;
                case "!shuffle":
                    if (usersVotedShuffle.Contains(user))
                    {
                        return;
                    }
                    else
                    {
                        usersVotedShuffle.Add(user);
                    }
                    if (usersVotedShuffle.Count == 3)
                    {
                        usersVotedShuffle.Clear();
                        if (ShuffleWorker.IsBusy == false)
                        {
                            ShuffleWorker.RunWorkerAsync();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private async void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                bool canConnect = SpotifyAPIObject.Connect();
                if (canConnect == false)
                {
                    MessageBox.Show("Cannot connect to your spotify process, sorry!");
                    Application.Exit();
                    return;
                }
                SpotifyAPIObject.ListenForEvents = true;
                SpotifyAPIObject.OnTrackChange += SpotifyAPIObject_OnTrackChange;
                SpotifyAPIObject.OnTrackTimeChange += SpotifyAPIObject_OnTrackTimeChange;

                doAuth();
                await getUserPlaylists();

                homeTimeModToolStripMenuItem.Text = "HomeTime Mode = ENABLED";
                HomeTimeMode.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in MainFrm_Load... Why you ask? Not because of shoddy coding, but because - " + Environment.NewLine + ex.Message);
                this.Close();
            }

        }

        private async Task getUserPlaylists()
        {
            if(PlaylistsFlowPanel.InvokeRequired)
            {
                PlaylistsFlowPanel.Invoke(new MethodInvoker(async () => await getUserPlaylists()));
                return;
            }
            Paging<SimplePlaylist> UserPublicPlaylists = await _spotify.GetUserPlaylistsAsync(UserID); // gets all PUBLIC playlists of the user
            if (UserPublicPlaylists.Error != null && UserPublicPlaylists.Error.Status == 500)
            {
                MessageBox.Show("Spotify API is currently unavailable, please try again later.");
                return;
            }
            PlaylistsFlowPanel.SuspendLayout();
            PlaylistsFlowPanel.Controls.Clear();
            bool IsFirstItem = true;
            foreach (SimplePlaylist SP in UserPublicPlaylists.Items) // for each of their PUBLIC playlists
            {
                Button PlaylistBtn = new Button();
                PlaylistBtn.Click += TSMU_Click; // assign click event
                PlaylistBtn.Text = SP.Name;
                PlaylistBtn.Tag = SP;
                PlaylistBtn.FlatStyle = FlatStyle.Flat;
                PlaylistBtn.BackColor = _ColourThemeDark;
                PlaylistBtn.ForeColor = Color.White;
                PlaylistBtn.FlatAppearance.BorderSize = 0;
                PlaylistBtn.Margin = new Padding(0);
                PlaylistBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(6, 166, 123);

                if (IsFirstItem)
                {
                    PlaylistBtn.Width = PlaylistsFlowPanel.Width;
                }
                else
                {
                    PlaylistBtn.Dock = DockStyle.Top;
                };
                PlaylistsFlowPanel.Controls.Add(PlaylistBtn);
                IsFirstItem = false;
            }
            PlaylistsFlowPanel.ResumeLayout();
        }

        private void TSMU_Click(object sender, EventArgs e)
        {
            //Reset selected state for all buttons
            foreach (Control ctrl in PlaylistsFlowPanel.Controls)
            {
                ctrl.BackColor = _ColourThemeDark;
                ctrl.Enabled = false;
            }
            current = 1; // reset current song
            Button c = (Button)sender; // get button clicked from sender
            c.BackColor = _ColourThemeLight; //Highlight selected
            if (ShuffleWorker.IsBusy && ShuffleWorker.CancellationPending == false)
            {
                ShuffleWorker.CancelAsync();
            }
            LastSong = "";
            SelectedPlaylist = (SimplePlaylist)c.Tag;
            ShuffleWorker.RunWorkerAsync(GetPlaylistTracks(SelectedPlaylist)); // shuffle with true, meaning it'll grab the songs too.
        }

        private async void doAuth()
        {
            try
            {
                _spotify = new SpotifyWebAPI();

                WebAPIFactory webApiFactory = new WebAPIFactory(
                    "http://localhost",
                    8000,
                    Token,
                    Scope.UserReadPrivate | Scope.PlaylistReadPrivate | Scope.PlaylistReadCollaborative,
                    TimeSpan.FromSeconds(20));
                _spotify = await webApiFactory.GetWebApi();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + "Please report this error on my github! https://github.com/JackRyder/");
            }

            if (_spotify == null)
            {
                Application.Exit();
            }

            UserID = _spotify.GetPrivateProfile().Id; // gets user ID of the one who logged in.

            FullTrack HomeTimeTrack = _spotify.GetTrack("72VjtouKhCbaBol2e7tsaQ");
            HomeTimeItem = getInfoFromTrack(HomeTimeTrack);
            Activate();

        }
        private new void Activate()
        {
            Process currentProcess = Process.GetCurrentProcess();
            IntPtr hWnd = currentProcess.MainWindowHandle;
            if (hWnd != User32.InvalidHandleValue)
            {
                User32.SetForegroundWindow(hWnd);
                User32.ShowWindow(hWnd, 1);
            }
        }

        private List<PlaylistItem> GetPlaylistTracks(SimplePlaylist ForPlaylist)
        {
            try
            {
                Tracks = _spotify.GetPlaylistTracks(ForPlaylist.Owner.Id, ForPlaylist.Id);
                return GrabPlaylistSongs(ForPlaylist.Owner.Id, ForPlaylist.Id);
            }
            catch (Exception)
            {
                //probably an auth error. let's fixed that.
                doAuth();
                return GetPlaylistTracks(ForPlaylist);
            }

        }

        private List<PlaylistItem> GrabPlaylistSongs(string ownerID, string playlistID)
        {
            List<PlaylistItem> ListOfPlaylistItems = new List<PlaylistItem> { };
            int count = 0;
            int total = Tracks.Total;
            for (int i = 0; i <= total - 1; i++)
            {
                try
                {
                    PlaylistItem PlaylistItem = getInfoFromTrack(Tracks.Items[count].Track);
                    ListOfPlaylistItems.Add(PlaylistItem);
                    if (count == 99 && Tracks.HasNextPage())
                    {
                        Tracks = _spotify.GetPlaylistTracks(ownerID, playlistID, null, 100, i);
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }
                catch (NullReferenceException)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    i--; // retry :P
                    System.Threading.Thread.Sleep(1000);
                }
            }
            LastSong = ListOfPlaylistItems.LastOrDefault().Song_Name;
            return ListOfPlaylistItems;
        }

        private void StartTheShuffle(List<PlaylistItem> playlistList = null)
        {
            List<PlaylistItem> ListOfPlaylistItems;

            if (playlistList != null)
            {
                ListOfPlaylistItems = playlistList;
            }
            else
            {
                ListOfPlaylistItems = PlaylistOfSongs.ToList();
            }
            PlaylistOfSongs.Clear();

            var rnd = new Random();
            while (ListOfPlaylistItems.Count != 0)
            {
                var index = rnd.Next(0, ListOfPlaylistItems.Count);
                PlaylistOfSongs.Add(ListOfPlaylistItems[index]);
                ListOfPlaylistItems.RemoveAt(index);
            }
            PlaylistOfSongs.RemoveAll(item => item == null);
            ReloadList();
            if (playlistList != null)
            {
                total = PlaylistOfSongs.Count;
                NextSong();
            }

        }

        private void SpotifyAPIObject_OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            try
            {
                if (length == 0)
                {
                    return;
                }

                this.Invoke((MethodInvoker)(() =>
                {
                    progressBar1.Value = (int)Math.Ceiling(e.TrackTime);
                    ProgressStartLbl.Text = TimeSpan.FromSeconds(e.TrackTime).ToString(@"mm\:ss");
                }));
                if (progressBar1.Value == progressBar1.Maximum || (progressBar1.Value == 0 && !SpotifyAPIObject.GetStatus().Playing))
                {
                    NextSong();
                    Console.WriteLine("next");
                    return;
                }
                Console.WriteLine(progressBar1.Value + " / " + progressBar1.Maximum);
            }
            catch (ArgumentOutOfRangeException)
            {
                NextSong();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void NextSong()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => progressBar1.Value = 0));
            }
            PlaylistItem PI = PlaylistOfSongs.FirstOrDefault();
            if (PI == null)
            {
                return;
            }
            ControlBtn.Text = "Pause";
            SpotifyAPIObject.PlayURL(PI.SongURI);
            //SpotifyAPIObject.Play();
            PlaylistOfSongs.Remove(PI);
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    counter.Text = $"Song {current} of {total}";
                    PlaylistItem nextSongControl = (PlaylistItem)FlowPlaylist.Controls[0];
                    FlowPlaylist.Controls.Remove(nextSongControl);
                    CurrentSongPanel.Controls.Clear();
                    CurrentSongPanel.Controls.Add(nextSongControl);
                    nextSongControl.Location = new Point(0, 0);
                    nextSongControl.Size = CurrentSongPanel.Size;
                    CurrentlyPlaying = nextSongControl.Song_Name + " by " + nextSongControl.Artist_Name;
                    RedX1Panel.Visible = false;
                    RedX2Panel.Visible = false;
                    RedX3Panel.Visible = false;
                }));
            }
            else
            {
                counter.Text = $"Song {current} of {total}";
                PlaylistItem nextSongControl = (PlaylistItem)FlowPlaylist.Controls[0];
                FlowPlaylist.Controls.Remove(nextSongControl);
                CurrentSongPanel.Controls.Clear();
                CurrentSongPanel.Controls.Add(nextSongControl);
                nextSongControl.Location = new Point(0, 0);
                nextSongControl.Size = CurrentSongPanel.Size;
                CurrentlyPlaying = nextSongControl.Song_Name + " by " + nextSongControl.Artist_Name;
                RedX1Panel.Visible = false;
                RedX2Panel.Visible = false;
                RedX3Panel.Visible = false;
            }
            current++;
            usersVoted.Clear();
        }

        private void SpotifyAPIObject_OnTrackChange(object sender, TrackChangeEventArgs e)
        {
            SpotifyAPI.Local.Models.Track NewTrack = e.NewTrack;
            string songName = NewTrack.TrackResource.Name;
            string artistName = NewTrack.ArtistResource.Name;
            this.Invoke((MethodInvoker)(() => progressBar1.Maximum = NewTrack.Length));
            this.Invoke((MethodInvoker)(() => ProgressEndLbl.Text = TimeSpan.FromSeconds(NewTrack.Length).ToString(@"mm\:ss")));
            this.Invoke((MethodInvoker)(() => ProgressStartLbl.Text = "00:00"));
            length = NewTrack.Length;
            //setNewSongAsset(imageURL, songName, albumName, artistName);
            client.SetTopic("#spotify", "Now playing: " + songName + " by " + artistName);
        }

        private void setNewSongAsset(string imageURL, string songName, string albumName, string artistName)
        {
            //PlaylistItem nextSongControl = (PlaylistItem)FlowPlaylist.Controls[0];
            //FlowPlaylist.Controls.Remove(nextSongControl);
            //CurrentSongPanel.Controls.Clear();
            //CurrentSongPanel.Controls.Add(nextSongControl);
            //nextSongControl.Location = new Point(0, 0);
            //nextSongControl.Size = CurrentSongPanel.Size;

            this.Invoke((MethodInvoker)(() =>
            {
                AlbumCoverArt.ImageLocation = imageURL;
                SongName.Text = "Song: " + songName;
                AlbumName.Text = "Album: " + albumName;
                ArtistName.Text = "Artist: " + artistName;
            }));

        }

        private void BootUpSpotify()
        {
            if (SpotifyLocalAPI.IsSpotifyRunning() == false)
            {
                SpotifyLocalAPI.RunSpotify();
            }
            if (SpotifyLocalAPI.IsSpotifyWebHelperRunning() == false)
            {
                SpotifyLocalAPI.RunSpotifyWebHelper();
            }

            System.Threading.Thread.Sleep(3000);
        }

        private void ReloadList()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                FlowPlaylist.SuspendLayout();
                FlowPlaylist.Controls.Clear();
                FlowPlaylist.Controls.AddRange(PlaylistOfSongs.ToArray());
                FlowPlaylist.ResumeLayout();
            }));
        }

        // NOT IN USE
        [Obsolete]
        private PlaylistItem loadInfo(string id)
        {
            PlaylistItem TempPI;

            FullTrack ft = _spotify.GetTrack(id);

            for (int i = 0; i <= 15; i++)
            {
                ft = _spotify.GetTrack(id);
                if (ft.Error == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("RATE LIMIT HIT.");
                    System.Threading.Thread.Sleep(1000);
                }
            }

            if (ft.Error != null)
            {
                MessageBox.Show(ft.Error.Message, "SpotiiShuffle - error " + ft.Error.Status);
                return null;
            }

            string SongURI = ft.Uri;
            string SongName = ft.Name;
            string AlbumName = ft.Album.Name;
            string AlbumImage = ft.Album.Images.FirstOrDefault().Url;
            string ArtistName = ft.Artists[0].Name;


            TempPI = new PlaylistItem(SongURI, AlbumImage, SongName, AlbumName, ArtistName, ft);

            return TempPI;

        }

        private PlaylistItem getInfoFromTrack(FullTrack track)
        {
            PlaylistItem TempPI;

            string SongURI = track.Uri;
            string SongName = track.Name;
            string AlbumName = track.Album.Name;
            string AlbumImage = track.Album.Images.Count > 0 ? track.Album.Images.FirstOrDefault().Url : "http://orig14.deviantart.net/5162/f/2014/153/9/e/no_album_art__no_cover___placeholder_picture_by_cmdrobot-d7kpm65.jpg";
            string ArtistName = track.Artists[0].Name;

            TempPI = new PlaylistItem(SongURI, AlbumImage, SongName, AlbumName, ArtistName, track);

            TempPI.Height = 93;

            return TempPI;
        }

        private void ShuffleBtn_Click(object sender, EventArgs e)
        {
            ShuffleWorker.RunWorkerAsync();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            NextSong();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpotifyAPIObject.ListenForEvents = false;
            SpotifyAPIObject.OnTrackChange -= SpotifyAPIObject_OnTrackChange;
            SpotifyAPIObject.OnTrackTimeChange -= SpotifyAPIObject_OnTrackTimeChange;
            Application.Exit();
        }

        private void ShuffleWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            this.Invoke((MethodInvoker)(() =>
            {
                selectPlaylistToolStripMenuItem.Enabled = false;
                ShuffleBtn.Enabled = false;
            }));
            if (ShuffleWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            if (e.Argument != null)
            {
                StartTheShuffle((List<PlaylistItem>)e.Argument); // dirty casting!
            }
            else
            {
                StartTheShuffle();
            }
        }

        private void ShuffleWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            selectPlaylistToolStripMenuItem.Enabled = true;
            ShuffleBtn.Enabled = true;

            foreach (Control ctrl in PlaylistsFlowPanel.Controls)
            {
                ctrl.Enabled = true;
            }
            PlaylistsFlowPanel.VerticalScroll.Value = 0;
        }

        private void ControlBtn_Click(object sender, EventArgs e)
        {
            if (ControlBtn.Text == "Pause")
            {
                SpotifyAPIObject.Pause();
                isPaused = true;
                ControlBtn.Text = "Play";
            }
            else if (ControlBtn.Text == "Play")
            {
                SpotifyAPIObject.Play();
                isPaused = false;
                ControlBtn.Text = "Pause";
            }
        }

        private void homeTimeModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HomeTimeMode.Enabled)
            {
                homeTimeModToolStripMenuItem.Text = "HomeTime Mode = DISABLED";
                HomeTimeMode.Stop();
            }
            else
            {
                homeTimeModToolStripMenuItem.Text = "HomeTime Mode = ENABLED";
                HomeTimeMode.Start();
            }
        }

        private bool jurassic = false;
        private bool isPaused;

        private void HomeTimeMode_Tick(object sender, EventArgs e)
        {
            TimeSpan StartTime, EndTime;

            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                StartTime = new TimeSpan(16, 28, 00);
                EndTime = new TimeSpan(16, 30, 00);
            }
            else
            {
                StartTime = new TimeSpan(17, 58, 00);
                EndTime = new TimeSpan(18, 00, 00);
            }

            if (DateTime.Now.TimeOfDay > StartTime && DateTime.Now.TimeOfDay < EndTime)
            {
                if (jurassic == true)
                {
                    return;
                }
                try
                {
                    PlaylistOfSongs.Insert(0, HomeTimeItem);
                    FlowPlaylist.Controls.Add(HomeTimeItem);
                    FlowPlaylist.Controls.SetChildIndex(HomeTimeItem, 0);
                    NextSong();
                    jurassic = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, (_spotify == null).ToString());
                }

                //homeTimeModToolStripMenuItem.PerformClick();
            }
            else if (jurassic == true)
            {
                jurassic = false;
            }
        }

        private void PlaylistsFlowPanel_Resize(object sender, EventArgs e)
        {
            if (PlaylistsFlowPanel.Controls.Count > 0)
            {
                PlaylistsFlowPanel.Controls[0].Width = PlaylistsFlowPanel.Width - (PlaylistsFlowPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0);
            }
        }

        private void CheckForNewSongs_Tick(object sender, EventArgs e)
        {
            CheckForNewSongs.Stop();
            CheckSongsWorker.RunWorkerAsync();
        }

        private async void CheckSongsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (LastSong != "" && SelectedPlaylist != null)
                {
                    var tracks = _spotify.GetPlaylistTracks(SelectedPlaylist.Owner.Id, SelectedPlaylist.Id, null, 100, 0);
                    if (tracks.HasError())
                    {
                        doAuth();
                        tracks = _spotify.GetPlaylistTracks(SelectedPlaylist.Owner.Id, SelectedPlaylist.Id, null, 100, 0);

                    }
                    while (tracks.HasNextPage())
                    {
                        tracks = _spotify.GetNextPage(tracks);
                    }
                    List<PlaylistTrack> lasttracks = tracks.Items;
                    lasttracks.Reverse();
                    if (lasttracks.FirstOrDefault().Track.Name == Tracks.Items.LastOrDefault().Track.Name)
                    {
                        return;
                    }
                    else
                    {
                        List<PlaylistTrack> ToBeAdded = new List<PlaylistTrack>();
                        Random R = new Random();
                        foreach (PlaylistTrack T in lasttracks)
                        {
                            if (T.Track.Name != LastSong)
                            {
                                string SongURI = T.Track.Uri;
                                string SongName = T.Track.Name;
                                string AlbumName = T.Track.Album.Name;
                                string AlbumImage = T.Track.Album.Images.FirstOrDefault().Url;
                                string ArtistName = T.Track.Artists[0].Name;

                                this.Invoke((MethodInvoker)(() =>
                                {
                                    int randomnum = R.Next(0, FlowPlaylist.Controls.Count);
                                    PlaylistItem PI = new PlaylistItem(SongURI, AlbumImage, SongName, AlbumName, ArtistName, T.Track);
                                    PI.Height = 93;
                                    PlaylistOfSongs.Insert(randomnum, PI);
                                    FlowPlaylist.Controls.Add(PI);
                                    FlowPlaylist.Controls.SetChildIndex(PI, randomnum);
                                }));
                                total++;

                            }
                            else
                            {
                                SelectedPlaylist.Tracks.Total = total;
                                LastSong = lasttracks.FirstOrDefault().Track.Name;
                                break;
                            }
                        }
                    }
                }
                await getUserPlaylists();
            }
            catch (Exception)
            {
                e.Cancel = true;
                return;
            }

        }

        private void CheckSongsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                counter.Text = $"Song {current - 1} of {total}";
            }
            snackgiven = false; //reset every 10 seconds :P
            CheckForNewSongs.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            SpotifyAPIObject.Connect();
            SpotifyAPIObject.ListenForEvents = true;
            SpotifyAPIObject.OnTrackChange -= SpotifyAPIObject_OnTrackChange;
            SpotifyAPIObject.OnTrackTimeChange -= SpotifyAPIObject_OnTrackTimeChange;
            SpotifyAPIObject.OnTrackChange += SpotifyAPIObject_OnTrackChange;
            SpotifyAPIObject.OnTrackTimeChange += SpotifyAPIObject_OnTrackTimeChange;
            NextSong();

        }

        private void NoSkipTimer_Tick(object sender, EventArgs e)
        {
            NoSkipTimer.Stop();
        }

        private void RemoveSongTimer_Tick(object sender, EventArgs e)
        {
            RemoveSongTimer.Stop();
        }
    }
}
