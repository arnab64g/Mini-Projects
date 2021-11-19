using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using WMPLib;
namespace A_Music_Player
{
    public partial class Form1 : Form
    {
        double pos = 0;
        bool run = false;
        int count = 0, ci = 0;   
        WindowsMediaPlayer wpl = new WindowsMediaPlayer();
        string[] s = new string[100];
        details[] d = new details[100];
        public Form1()
        {
            InitializeComponent();
            button1.Click += Browse_Music;
            button2.Click += Play_Music;
            trackBar1.Value = 67;
            trackBar2.Value = 0;
            wpl.settings.volume = trackBar1.Value;
            trackBar1.Scroll += TrackBar1_Scroll;
            trackBar2.Scroll += Fo_Music;
            button3.Click += Push_Music;
            MusicList.MouseClick += Play_Music_s;
            button4.Click += Stop_Current;
            button6.Click += Play_Next;
            button5.Click += Play_Prev;
        }
        private void Play_Prev(object sender, EventArgs e)
        {
            ci--;
            wpl.controls.stop();
            if (ci < 0)
            {
                ci = count - 1;
                if (checkBox1.Checked == false)
                    button4.PerformClick();
                else{
                    MusicList.SelectedIndex = ci;
                    button2.PerformClick();
                }
            }
            else{
                MusicList.SelectedIndex = ci;
                button2.PerformClick();
            }
        }
        private void Play_Next(object sender, EventArgs e)
        {
            wpl.controls.stop();
            if (ci == count){
                ci = 0;
                if (checkBox1.Checked == false)
                    button4.PerformClick();
                else{
                    MusicList.SelectedIndex = ci;
                    button2.PerformClick();
                }
            }
            else{
                MusicList.SelectedIndex = ci;
                button2.PerformClick();
            }
        }
        private void Play_Music_s(object sender, MouseEventArgs e)
        {
            run = false;
            Console.WriteLine("Clicked");
            wpl.controls.stop();
            button2.PerformClick();
        }
        private void Push_Music(object sender, EventArgs e)
        {
            timer1.Stop();
            pos = wpl.controls.currentPosition;
            wpl.controls.pause();
            button2.Visible = true;
            button3.Visible = false;
        }
        private void Stop_Current(object sender, EventArgs e)
        {
            run = false;
            pos = 0;
            wpl.controls.stop();
            button2.Text = "Play";
            timer1.Stop();
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
        }
        private void Fo_Music(object sender, EventArgs e)
        {
            wpl.controls.currentPosition = (double) (trackBar2.Value * wpl.controls.currentItem.duration)/100;
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            wpl.settings.volume = trackBar1.Value;
        }
        public void Browse_Music(Object sender, EventArgs e)
        {   
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "A Music Player";
            opf.Multiselect = true;
            opf.ShowDialog();
            foreach (var item in opf.FileNames){
                s[count++] = item;
            }
            Song_list.list_make(s, d, count);
            for (int i = 0; i < count; i++)
                MusicList.Items.Add(d[i].name);
        }
        public void Play_Music(Object sender, EventArgs e)
        {
            string s;
            if (MusicList.SelectedIndex == -1){
                s = MusicList.Items[0].ToString();
                ci = 0;
            }
            else{
                s = MusicList.SelectedItem.ToString();
                ci = MusicList.SelectedIndex;
            }
            if (!run)
                wpl.URL = Song_list.getPath(s, d, count);
            wpl.controls.play();
            try
            {
                var taglb = TagLib.File.Create(wpl.URL);
                var bin = (byte[])(taglb.Tag.Pictures[0].Data.Data);
                pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            { 
            }
            wpl.controls.currentPosition = pos;
            
            timer1.Start();
            timer1.Interval = 100;
            timer1.Tick += Update_bar;
            label2.Text = wpl.status;   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Update_bar(object sender, EventArgs e)
        {
            label2.Text = "Now Playing: " + wpl.controls.currentItem.name;
            if (wpl.controls.currentItem.duration > 0){
                var t = TimeSpan.FromSeconds(wpl.controls.currentPosition);
                label3.Text = t.ToString(@"mm\:ss");
                label5.Text = wpl.controls.currentItem.durationString.ToString();
                trackBar2.Value = (int)((wpl.controls.currentPosition * 100) / wpl.controls.currentItem.duration);
            }
            Console.WriteLine(wpl.playState.ToString());
            if(wpl.playState == WMPPlayState.wmppsPlaying){
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = true;
            }
            else if (wpl.playState != WMPPlayState.wmppsPlaying){
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
            }
            if(wpl.playState == WMPPlayState.wmppsStopped){
                ci++;
                button6.PerformClick();
            } 
        }
    }
}
