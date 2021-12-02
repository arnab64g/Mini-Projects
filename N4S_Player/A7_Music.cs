using NAudio.Wave;
namespace N4S_Player
{
    public partial class A7_Music : Form
    {
        bool run = false;
        int count = 0, ci = 0, duration, ct;
        private AudioFileReader ws;
        private WaveOut wo = new WaveOut();
        TimeSpan ts;
        string[] S = new string[100];
        Details[] D = new Details[100];
        public A7_Music()
        {
            InitializeComponent();
            count = Settings.load_Playlist(S);
            Song_List.StringSepr(S, D, count);
            playtime.Start();
            playtime.Interval = 1000;
            playtime.Tick += Update_Bar;
            
            for (int i = 0; i < count; i++)
            {
                ws = new AudioFileReader(D[i].pathdetails);
                duration = ((int)ws.TotalTime.TotalSeconds);
                TimeSpan ts = TimeSpan.FromSeconds(duration);
                string s = ts.ToString(@"mm\:ss");
                ListViewItem item = new ListViewItem();
                item.Text = D[i].name;
                item.SubItems.Add(s);
                MusicList.Items.Add(item);
            }
            Browse.Click += Browse_Music;
            Play.Click += Play_Music;
            voltb.Value = Settings.volume();
            ln.Text = voltb.Value.ToString();
            voltb.Scroll += Lavel_Volume;
            Stop.Click += Stop_Current;
            Pause.Click += Push_Music;
            MusicList.MouseClick += Play_Music_s;
            seek.Scroll += Seek_Music;
            Previous.Click += Play_Prev;
            Next.Click += Play_Next;
            
        }
        private void Close_Prog(object? sender, EventArgs e)
        {
            ws.Dispose();
            wo.Dispose();
            playtime.Dispose();
            this.Close();
        }
        private void Play_Prev(object? sender, EventArgs e)
        {
            MusicList.SelectedItems.Clear();
            Stop.PerformClick();
            if (ci > 0)
            {
                ci--;
                MusicList.Items[ci].Selected = true;
                Play.PerformClick();
            }
            else
            {
                MusicList.Items[ci].Selected = true;
                Play.PerformClick();
            }
        }
        private void Play_Next(object? sender, EventArgs e)
        {
            MusicList.SelectedItems.Clear();
            if (ci == count - 1)
            {
                if (repeat.Checked == true)
                {
                    ci = 0;
                    MusicList.Items[ci].Selected = true;
                }
                else return;
            }
            else if(count != 0)
            {
                ci++;
                MusicList.Items[ci].Selected = true;
            }
            Stop.PerformClick();
            Play.PerformClick();
        }
        private void Seek_Music(object? sender, EventArgs e)
        {
            ws.Position = seek.Value * ws.WaveFormat.AverageBytesPerSecond;
        }
        public void Play_Music(Object? sender, EventArgs e)
        {

            if (MusicList.SelectedItems.Count == 0)
            {
                ci = 0;
            }
            else
            {
                ci = MusicList.SelectedIndices[0];
            }
            if (run)
            {
                wo.Resume();
                Play.Visible = true;
                Pause.Visible = false;
            }
            else if(count != 0)
            {
                ws = new AudioFileReader(D[ci].pathdetails);
                wo = new WaveOut();
                wo.Volume = (float)voltb.Value / 100;
                duration = ((int)ws.TotalTime.TotalSeconds);
                TimeSpan ts = TimeSpan.FromSeconds(duration);
                TDuration.Text = ts.ToString(@"mm\:ss");
                seek.Maximum = duration;
                wo.Init(ws);
                wo.Play();
                try
                {
                    var taglb = TagLib.File.Create(D[ci].pathdetails);

                    var bin = (byte[])(taglb.Tag.Pictures[0].Data.Data);
                    PlayImage.Image = Image.FromStream(new MemoryStream(bin));
                }
                catch
                {
                    PlayImage.Image = global::N4S_Player.Properties.Resources.pngegg;
                }
            }
            Pause.Visible = true;
            Play.Visible = false;
            Stop.Visible = true;
            run = true;
        }
        private void Update_Bar(object? sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(@"MMMM dd, yyyy  ddddd   hh:mm:ss tt");
            
            if (run && count != 0)
            {
                npl.Text = "Now Playing: " + D[ci].name;
                ct = ((int)ws.CurrentTime.TotalSeconds);
                ts = TimeSpan.FromSeconds(ct);
                Duration.Text = ts.ToString(@"mm\:ss");
                Duration.Visible = true;
                TDuration.Visible = true;
                TDuration.Visible = true;
                seek.Value = ct;
            }
            if (ct == duration)
            {
                Next.PerformClick();
            }
        }
        private void Push_Music(object? sender, EventArgs e)
        {
            wo.Pause();
            Pause.Visible = false;
            Play.Visible = true;
        }
        private void Stop_Current(object? sender, EventArgs e)
        {
          
            wo.Stop();
            wo.Dispose();
            PlayImage.Image = global::N4S_Player.Properties.Resources.pngegg;
            Pause.Visible = false;
            Play.Visible = true;
            Stop.Visible = false;
            run = false;
            Duration.Visible = false;
            TDuration.Visible = false;
            
           
        }

       

        private void Play_Music_s(object? sender, MouseEventArgs e)
        {
            if (run)
            {
                Stop.PerformClick();
            }
            Play.PerformClick();
        }
        private void Lavel_Volume(object? sender, EventArgs e)
        {
            ln.Text = voltb.Value.ToString();
            wo.Volume = (float)voltb.Value / 100;
            Settings.Update_Volume(voltb.Value);
        }
        public void Browse_Music(Object? sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "A7 Music Player";
            opf.Multiselect = true;
            opf.ShowDialog();
            while (MusicList.Items.Count > 0)
            {
                MusicList.Items.Clear();
            }
            count = 0;
            foreach (var item in opf.FileNames)
            {
                S[count++] = item;
            }
            Settings.save_playlist(S, count);
            Song_List.StringSepr(S, D, count);
            for (int i = 0; i < count; i++)
            {
                ws = new AudioFileReader(D[i].pathdetails);
                duration = ((int)ws.TotalTime.TotalSeconds);
                TimeSpan ts = TimeSpan.FromSeconds(duration);
                string s = ts.ToString(@"mm\:ss");
                ListViewItem item = new ListViewItem();
                item.Text = D[i].name;
                item.SubItems.Add(s);
                MusicList.Items.Add(item);
            }
        }
    }
}