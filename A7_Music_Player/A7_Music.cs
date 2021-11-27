using NAudio.Wave;
namespace A7_Music_Player
{
    public partial class A7_Music : Form
    {
        bool run = false;
        int count = 0, ci = 0, duration, ct;
        private AudioFileReader ws;
        private WaveOut wo;
        TimeSpan ts;
        string[] S = new string[100];
        Details[] D = new Details[100];
        public A7_Music()
        {
            InitializeComponent();
            Browse.Click += Browse_Music;
            Play.Click += Play_Music;
            voltb.Value = 67;
            voltb.Scroll += Lavel_Volume;
            Stop.Click += Stop_Current;
            Pause.Click += Push_Music;
            MusicList.MouseClick += Play_Music_s;
            seek.Scroll += Seek_Music;
            Previous.Click += Play_Prev;
            Next.Click += Play_Next;
        }
        private void Play_Prev(object sender, EventArgs e)
        {
            Stop.PerformClick();
            if (ci > 0)
            {
                ci--;
                MusicList.SelectedIndex = ci;
                Play.PerformClick();
            }
            else
            {
                MusicList.SelectedIndex = 0;
                Play.PerformClick();
            }
        }
        private void Play_Next(object sender, EventArgs e)
        {
            if (ci == count-1)
            {
                if (repeat.Checked == true)
                {
                    ci = 0;
                    MusicList.SelectedIndex = ci;
                }
                else return;
            }
            else
            {
                ci++;
                MusicList.SelectedIndex = ci;
            }
            Stop.PerformClick();
            Play.PerformClick();
        }
        private void Seek_Music(object sender, EventArgs e)
        {
            ws.Position = seek.Value * ws.WaveFormat.AverageBytesPerSecond;         
        }
        public void Play_Music(Object sender, EventArgs e)
        {
            string s;
            if (MusicList.SelectedIndex == -1)
            {
                s = MusicList.Items[0].ToString();
                ci = 0;
            }
            else
            {
                s = MusicList.SelectedItem.ToString();
                ci = MusicList.SelectedIndex;
            }
            if (run)
            {
                wo.Resume();
                Play.Visible = true;
                Pause.Visible = false;
            }
            else
            {
                ws = new AudioFileReader(D[ci].pathdetails);
                wo = new WaveOut();
                wo.Volume = (float)voltb.Value / 100;
                TagLib.File f = TagLib.File.Create(D[ci].pathdetails, TagLib.ReadStyle.Average);
                duration = (int)f.Properties.Duration.TotalSeconds;
                TimeSpan ts = TimeSpan.FromSeconds(duration);
                TDuration.Text = ts.ToString(@"mm\:ss");
                TDuration.Visible = true;
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
                }
                playtime.Start();
                playtime.Interval = 1000;
                playtime.Tick += Update_Bar;
            }
            Pause.Visible = true;
            Play.Visible = false;
            Stop.Visible = true;
            run = true;
        }
        private void Update_Bar(object sender, EventArgs e)
        {
            npl.Text = "Now Playing: " + D[ci].name;
            if (run)
            {
                ct = (int) ws.Position / ws.WaveFormat.AverageBytesPerSecond;
                ts = TimeSpan.FromSeconds(ct);
                Duration.Text = ts.ToString(@"mm\:ss");
                Duration.Visible = true;
                seek.Value = ct;
            }
            if (ct == duration)
            {
                Next.PerformClick();
            }
        }
        private void Push_Music(object sender, EventArgs e)
        {
            wo.Pause();
            Pause.Visible = false;
            Play.Visible = true;
        }
        private void Stop_Current(object sender, EventArgs e)
        {
            Pause.Visible = false;
            Play.Visible = true;
            Stop.Visible = false;
            wo.Stop();
            wo.Dispose();
            run = false;
        }
        private void Play_Music_s(object sender, MouseEventArgs e)
        {
            if (run)
            {
                Stop.PerformClick();
            }
            Play.PerformClick();
        }
        private void Lavel_Volume(object sender, EventArgs e)
        {
            wo.Volume = (float)voltb.Value/100;
        }
        public void Browse_Music(Object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "A7 Music Player";
            opf.Multiselect = true;
            opf.ShowDialog();
            foreach (var item in opf.FileNames)
            {
                S[count++] = item;
            }
            Song_list.list_make(S, D, count);
            for (int i = 0; i < count; i++)
                MusicList.Items.Add(D[i].name);
        }
    }
}