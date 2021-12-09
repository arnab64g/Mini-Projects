namespace N4S_Player
{
    partial class A7_Music
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
            System.Windows.Forms.ColumnHeader st;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A7_Music));
            System.Windows.Forms.ColumnHeader td;
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.MusicList = new Syncfusion.Windows.Forms.Tools.DataListView();
            this.Browse = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.voltb = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 100);
            this.Duration = new System.Windows.Forms.Label();
            this.seek = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.playtime = new System.Windows.Forms.Timer(this.components);
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.vollbl = new System.Windows.Forms.Label();
            this.PlayImage = new System.Windows.Forms.PictureBox();
            this.TDuration = new System.Windows.Forms.Label();
            this.npl = new System.Windows.Forms.Label();
            this.repeat = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.ln = new System.Windows.Forms.Label();
            this.progressBarAdv2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Panel();
            this.progressBarAdv3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            st = new System.Windows.Forms.ColumnHeader("(none)");
            td = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).BeginInit();
            this.progressBarAdv2.SuspendLayout();
            this.progressBarAdv3.SuspendLayout();
            this.SuspendLayout();
            // 
            // st
            // 
            resources.ApplyResources(st, "st");
            // 
            // td
            // 
            td.Tag = "";
            resources.ApplyResources(td, "td");
            // 
            // MusicList
            // 
            resources.ApplyResources(this.MusicList, "MusicList");
            this.MusicList.BackColor = System.Drawing.Color.Firebrick;
            this.MusicList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MusicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            st,
            td});
            this.MusicList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicList.DataSource = ((object)(resources.GetObject("MusicList.DataSource")));
            this.MusicList.ForeColor = System.Drawing.Color.White;
            this.MusicList.FullRowSelect = true;
            this.MusicList.GridLines = true;
            this.MusicList.HoverSelection = true;
            this.MusicList.LabelEdit = true;
            this.MusicList.Name = "MusicList";
            this.MusicList.UseCompatibleStateImageBehavior = false;
            this.MusicList.View = System.Windows.Forms.View.Details;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Browse, "Browse");
            this.Browse.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Browse.FlatAppearance.BorderSize = 0;
            this.Browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Browse.ForeColor = System.Drawing.Color.Red;
            this.Browse.Image = global::N4S_Player.Properties.Resources.folder__1_;
            this.Browse.Name = "Browse";
            this.Browse.TabStop = false;
            this.Browse.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Name = "Title";
            this.Title.UseWaitCursor = true;
            // 
            // voltb
            // 
            this.voltb.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.voltb.BackColor = System.Drawing.Color.Transparent;
            this.voltb.BeforeTouchSize = new System.Drawing.Size(120, 20);
            this.voltb.ButtonColor = System.Drawing.Color.Red;
            this.voltb.ButtonSignColor = System.Drawing.Color.Fuchsia;
            this.voltb.ChannelHeight = 8;
            this.voltb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltb.DecreaseButtonSize = new System.Drawing.Size(0, 0);
            this.voltb.ForeColor = System.Drawing.Color.Purple;
            this.voltb.IncreaseButtonSize = new System.Drawing.Size(0, 0);
            resources.ApplyResources(this.voltb, "voltb");
            this.voltb.Name = "voltb";
            this.voltb.PushedButtonEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.voltb.ShowButtons = false;
            this.voltb.ThemeName = "Default";
            this.voltb.ThemeStyle.BackColor = System.Drawing.Color.Red;
            this.voltb.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.voltb.ThemeStyle.DisabledTrackBarColor = System.Drawing.Color.Maroon;
            this.voltb.TimerInterval = 100;
            this.voltb.Transparent = true;
            this.voltb.Value = 5;
            // 
            // Duration
            // 
            resources.ApplyResources(this.Duration, "Duration");
            this.Duration.BackColor = System.Drawing.Color.Olive;
            this.Duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Duration.Name = "Duration";
            // 
            // seek
            // 
            resources.ApplyResources(this.seek, "seek");
            this.seek.BackColor = System.Drawing.Color.Maroon;
            this.seek.BeforeTouchSize = new System.Drawing.Size(374, 20);
            this.seek.DecreaseButtonSize = new System.Drawing.Size(0, 0);
            this.seek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seek.IncreaseButtonSize = new System.Drawing.Size(0, 0);
            this.seek.Name = "seek";
            this.seek.ShowButtons = false;
            this.seek.ShowFocusRect = false;
            this.seek.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.seek.ThemeName = "Metro";
            this.seek.TimerInterval = 100;
            this.seek.Transparent = true;
            this.seek.Value = 0;
            // 
            // playtime
            // 
            this.playtime.Enabled = true;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Next, "Next");
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Next.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Next.Image = global::N4S_Player.Properties.Resources.next;
            this.Next.Name = "Next";
            this.Next.UseVisualStyleBackColor = false;
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Previous, "Previous");
            this.Previous.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Previous.FlatAppearance.BorderSize = 0;
            this.Previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Previous.Image = global::N4S_Player.Properties.Resources.previous;
            this.Previous.Name = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
           
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Stop.Image = global::N4S_Player.Properties.Resources.stop_button;
            this.Stop.Name = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            // 
            // Play
            // 
            resources.ApplyResources(this.Play, "Play");
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play.Image = global::N4S_Player.Properties.Resources.play__1_;
            this.Play.Name = "Play";
            this.Play.UseVisualStyleBackColor = false;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Pause, "Pause");
            this.Pause.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Pause.Image = global::N4S_Player.Properties.Resources.pause;
            this.Pause.Name = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            // 
            // vollbl
            // 
            this.vollbl.AutoEllipsis = true;
            resources.ApplyResources(this.vollbl, "vollbl");
            this.vollbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vollbl.ForeColor = System.Drawing.Color.Orange;
            this.vollbl.Name = "vollbl";
            // 
            // PlayImage
            // 
            this.PlayImage.BackColor = System.Drawing.Color.Transparent;
            this.PlayImage.Image = global::N4S_Player.Properties.Resources.pngegg2;
            resources.ApplyResources(this.PlayImage, "PlayImage");
            this.PlayImage.Name = "PlayImage";
            this.PlayImage.TabStop = false;
            // 
            // TDuration
            // 
            resources.ApplyResources(this.TDuration, "TDuration");
            this.TDuration.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.TDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDuration.ForeColor = System.Drawing.Color.Blue;
            this.TDuration.Name = "TDuration";
            // 
            // npl
            // 
            resources.ApplyResources(this.npl, "npl");
            this.npl.Name = "npl";
            // 
            // repeat
            // 
            this.repeat.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            activeStateCollection1.BackColor = System.Drawing.Color.Lime;
            activeStateCollection1.BorderColor = System.Drawing.Color.Maroon;
            activeStateCollection1.ForeColor = System.Drawing.Color.Red;
            activeStateCollection1.Text = "";
            this.repeat.ActiveState = activeStateCollection1;
            resources.ApplyResources(this.repeat, "repeat");
            this.repeat.BackgroundImage = global::N4S_Player.Properties.Resources.icons8_repeat_24;
            this.repeat.ForeColor = System.Drawing.SystemColors.ControlText;
            inactiveStateCollection1.Text = "";
            this.repeat.InactiveState = inactiveStateCollection1;
            this.repeat.Name = "repeat";
            sliderCollection1.Width = 10;
            this.repeat.Slider = sliderCollection1;
            this.repeat.ThemeName = "Metro";
            this.repeat.ThemeStyle.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.repeat.ThemeStyle.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.repeat.ThemeStyle.ActiveForeColor = System.Drawing.Color.Green;
            this.repeat.ThemeStyle.ActiveHoverBackColor = System.Drawing.Color.Lime;
            this.repeat.ThemeStyle.ActiveHoverBorderColor = System.Drawing.Color.Yellow;
            this.repeat.ThemeStyle.BorderThickness = 0;
            // 
            // ln
            // 
            resources.ApplyResources(this.ln, "ln");
            this.ln.Name = "ln";
            // 
            // progressBarAdv2
            // 
            this.progressBarAdv2.Controls.Add(this.label1);
            this.progressBarAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.progressBarAdv2, "progressBarAdv2");
            this.progressBarAdv2.Name = "progressBarAdv2";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Name = "label1";
            // 
            // progressBarAdv3
            // 
            this.progressBarAdv3.Controls.Add(this.label2);
            this.progressBarAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.progressBarAdv3, "progressBarAdv3");
            this.progressBarAdv3.Name = "progressBarAdv3";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Indigo;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // A7_Music
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarAdv3);
            this.Controls.Add(this.progressBarAdv2);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.npl);
            this.Controls.Add(this.TDuration);
            this.Controls.Add(this.PlayImage);
            this.Controls.Add(this.vollbl);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.seek);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.voltb);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.MusicList);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "A7_Music";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).EndInit();
            this.progressBarAdv2.ResumeLayout(false);
            this.progressBarAdv3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private Syncfusion.Windows.Forms.Tools.DataListView MusicList;
        private Button Browse;
        private Button Pause;
        private System.Windows.Forms.Label Title;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx voltb;
        private Button Play;
        private Button Stop;
        private System.Windows.Forms.Label Duration;
        public System.Windows.Forms.Timer playtime;
        private Button Previous;
        private Button Next;
        private System.Windows.Forms.Label vollbl;
        private System.Windows.Forms.PictureBox PlayImage;
        private System.Windows.Forms.Label TDuration;
        private ColumnHeader td;
        protected ColumnHeader st;
        private Label npl;
        private Syncfusion.Windows.Forms.Tools.ToggleButton  repeat;
        private Label ln;
        private Panel progressBarAdv2;
        private Panel progressBarAdv3;
        internal Syncfusion.Windows.Forms.Tools.TrackBarEx seek;
        private Panel label2;
        private Panel label1;
        private Label label3;
    }
}
