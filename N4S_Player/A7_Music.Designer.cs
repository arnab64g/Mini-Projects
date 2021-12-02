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
            this.MusicList = new System.Windows.Forms.ListView();
            this.Browse = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.voltb = new System.Windows.Forms.TrackBar();
            this.Duration = new System.Windows.Forms.Label();
            this.seek = new System.Windows.Forms.TrackBar();
            this.playtime = new System.Windows.Forms.Timer(this.components);
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.vollbl = new System.Windows.Forms.Label();
            this.PlayImage = new System.Windows.Forms.PictureBox();
            this.TDuration = new System.Windows.Forms.Label();
            this.darkDockPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bps = new System.Windows.Forms.Label();
            this.npl = new System.Windows.Forms.Label();
            this.repeat = new System.Windows.Forms.CheckBox();
            this.ln = new System.Windows.Forms.Label();
            st = new System.Windows.Forms.ColumnHeader("(none)");
            td = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.voltb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
            this.darkDockPanel1.SuspendLayout();
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
            this.MusicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            st,
            td});
            this.MusicList.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Browse.FlatAppearance.BorderSize = 0;
            this.Browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.Browse, "Browse");
            this.Browse.ForeColor = System.Drawing.Color.Transparent;
            this.Browse.Image = global::N4S_Player.Properties.Resources.folder__1_1;
            this.Browse.Name = "Browse";
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
            this.voltb.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.voltb, "voltb");
            this.voltb.Maximum = 100;
            this.voltb.Name = "voltb";
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
            this.seek.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.seek, "seek");
            this.seek.Name = "seek";
            // 
            // playtime
            // 
            this.playtime.Enabled = true;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.Next, "Next");
            this.Next.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Next.Image = global::N4S_Player.Properties.Resources.next;
            this.Next.Name = "Next";
            this.Next.UseVisualStyleBackColor = false;
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            this.Previous.FlatAppearance.BorderSize = 0;
            this.Previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.Previous, "Previous");
            this.Previous.Image = global::N4S_Player.Properties.Resources.previous;
            this.Previous.Name = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.Image = global::N4S_Player.Properties.Resources.stop_button;
            this.Stop.Name = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            // 
            // Play
            // 
            resources.ApplyResources(this.Play, "Play");
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.Play.Image = global::N4S_Player.Properties.Resources.play__1_;
            this.Play.Name = "Play";
            this.Play.UseVisualStyleBackColor = false;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.Pause, "Pause");
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
            // darkDockPanel1
            // 
            this.darkDockPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.darkDockPanel1.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.darkDockPanel1, "darkDockPanel1");
            this.darkDockPanel1.Controls.Add(this.label1);
            this.darkDockPanel1.ForeColor = System.Drawing.Color.Red;
            this.darkDockPanel1.Name = "darkDockPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // bps
            // 
            resources.ApplyResources(this.bps, "bps");
            this.bps.BackColor = System.Drawing.Color.Olive;
            this.bps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bps.Name = "bps";
            // 
            // npl
            // 
            resources.ApplyResources(this.npl, "npl");
            this.npl.Name = "npl";
            // 
            // repeat
            // 
            resources.ApplyResources(this.repeat, "repeat");
            this.repeat.BackColor = System.Drawing.Color.Transparent;
            this.repeat.FlatAppearance.BorderSize = 0;
            this.repeat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.repeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.repeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.repeat.ForeColor = System.Drawing.Color.GreenYellow;
            this.repeat.Image = global::N4S_Player.Properties.Resources.icons8_repeat_24;
            this.repeat.Name = "repeat";
            this.repeat.UseVisualStyleBackColor = false;
            // 
            // ln
            // 
            resources.ApplyResources(this.ln, "ln");
            this.ln.Name = "ln";
            // 
            // A7_Music
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.ln);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.npl);
            this.Controls.Add(this.bps);
            this.Controls.Add(this.darkDockPanel1);
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
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.voltb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).EndInit();
            this.darkDockPanel1.ResumeLayout(false);
            this.darkDockPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ListView MusicList;
        private Button Browse;
        private Button Pause;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TrackBar voltb;
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
        private System.Windows.Forms.Panel darkDockPanel1;
        protected TrackBar seek;
        private Label label1;
        private Label bps;
        private Label npl;
        private CheckBox  repeat;
        private Label ln;
    }
}

