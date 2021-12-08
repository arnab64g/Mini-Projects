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
            this.voltb = new Krypton.Toolkit.KryptonTrackBar();
            this.Duration = new System.Windows.Forms.Label();
            this.seek = new Krypton.Toolkit.KryptonTrackBar();
            this.playtime = new System.Windows.Forms.Timer(this.components);
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.vollbl = new System.Windows.Forms.Label();
            this.PlayImage = new System.Windows.Forms.PictureBox();
            this.TDuration = new System.Windows.Forms.Label();
            this.bps = new System.Windows.Forms.Label();
            this.npl = new System.Windows.Forms.Label();
            this.repeat = new System.Windows.Forms.CheckBox();
            this.ln = new System.Windows.Forms.Label();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv2 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv3 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            st = new System.Windows.Forms.ColumnHeader("(none)");
            td = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).BeginInit();
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
            this.voltb.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.voltb.BackStyle = Krypton.Toolkit.PaletteBackStyle.ControlCustom1;
            this.voltb.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.voltb, "voltb");
            this.voltb.Maximum = 100;
            this.voltb.Name = "voltb";
            this.voltb.OverrideFocus.Track.Color1 = System.Drawing.Color.Maroon;
            this.voltb.StateCommon.Position.Color1 = System.Drawing.Color.Yellow;
            this.voltb.StateCommon.Position.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.voltb.StateCommon.Tick.Color2 = System.Drawing.Color.Olive;
            this.voltb.StateCommon.Track.Color2 = System.Drawing.Color.Blue;
            this.voltb.StateNormal.Position.Color1 = System.Drawing.Color.OrangeRed;
            this.voltb.StateNormal.Position.Color3 = System.Drawing.Color.Yellow;
            this.voltb.StateNormal.Tick.Color1 = System.Drawing.Color.DarkOrange;
            this.voltb.StateNormal.Tick.Color2 = System.Drawing.Color.Red;
            this.voltb.StateNormal.Tick.Color3 = System.Drawing.Color.Olive;
            this.voltb.StateNormal.Tick.Color4 = System.Drawing.Color.Maroon;
            this.voltb.StateNormal.Tick.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.voltb.StateNormal.Track.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.voltb.StateNormal.Track.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.voltb.StateNormal.Track.Color3 = System.Drawing.Color.Navy;
            this.voltb.StateNormal.Track.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.voltb.StateNormal.Track.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.voltb.StateTracking.Position.Color1 = System.Drawing.Color.Red;
            this.voltb.StateTracking.Position.Color2 = System.Drawing.Color.Red;
            this.voltb.StateTracking.Position.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.voltb.StateTracking.Position.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.voltb.StateTracking.Position.Color5 = System.Drawing.Color.Maroon;
            this.voltb.ToolTipValues.EnableToolTips = true;
            this.voltb.ToolTipValues.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("resource.ImageTransparentColor")));
            this.voltb.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.AbsolutePoint;
            this.voltb.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.voltb.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large;
            this.voltb.VolumeControl = true;
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
            this.seek.BackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderDockActive;
            this.seek.Name = "seek";
            this.seek.OverrideFocus.Tick.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seek.OverrideFocus.Tick.Color5 = System.Drawing.Color.Tomato;
            this.seek.OverrideFocus.Track.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seek.OverrideFocus.Track.Color5 = System.Drawing.Color.Maroon;
            this.seek.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeDarkMode;
            this.seek.StateCommon.Position.Color1 = System.Drawing.Color.LawnGreen;
            this.seek.StateCommon.Position.Color2 = System.Drawing.Color.Olive;
            this.seek.StateCommon.Position.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seek.StateCommon.Position.Color4 = System.Drawing.Color.Green;
            this.seek.StateCommon.Position.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seek.StateCommon.Tick.Color1 = System.Drawing.Color.Purple;
            this.seek.StateCommon.Tick.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.seek.StateCommon.Tick.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.seek.StateCommon.Tick.Color4 = System.Drawing.Color.Fuchsia;
            this.seek.StateCommon.Tick.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.seek.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.seek.StateCommon.Track.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seek.StateCommon.Track.Color3 = System.Drawing.Color.Red;
            this.seek.StateCommon.Track.Color4 = System.Drawing.Color.OrangeRed;
            this.seek.StateCommon.Track.Color5 = System.Drawing.Color.Yellow;
            this.seek.StateDisabled.Position.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seek.StateDisabled.Tick.Color1 = System.Drawing.Color.Green;
            this.seek.StateNormal.Position.Color1 = System.Drawing.Color.Blue;
            this.seek.StateNormal.Position.Color2 = System.Drawing.Color.Blue;
            this.seek.StateNormal.Position.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.seek.StateNormal.Position.Color4 = System.Drawing.Color.Navy;
            this.seek.StateNormal.Position.Color5 = System.Drawing.Color.Purple;
            this.seek.StateNormal.Tick.Color1 = System.Drawing.Color.OrangeRed;
            this.seek.StateNormal.Tick.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seek.StateNormal.Tick.Color3 = System.Drawing.Color.Olive;
            this.seek.StateNormal.Tick.Color4 = System.Drawing.Color.Yellow;
            this.seek.StateNormal.Tick.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seek.StateNormal.Track.Color1 = System.Drawing.Color.Orange;
            this.seek.StateNormal.Track.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seek.StateNormal.Track.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seek.StateNormal.Track.Color4 = System.Drawing.Color.Yellow;
            this.seek.StateNormal.Track.Color5 = System.Drawing.Color.Olive;
            this.seek.StateTracking.Position.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seek.StateTracking.Position.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seek.StateTracking.Position.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seek.StateTracking.Position.Color4 = System.Drawing.Color.Green;
            this.seek.StateTracking.Position.Color5 = System.Drawing.Color.Teal;
            this.seek.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.seek.ToolTipValues.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("resource.ImageTransparentColor1")));
            this.seek.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Small;
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
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.ForeColor = Color.FromArgb(254, 10, 150);
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.ForeSegments = false;
            resources.ApplyResources(this.progressBarAdv1, "progressBarAdv1");
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.TextVisible = false;
            this.progressBarAdv1.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.progressBarAdv1.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBarAdv1.Value = 0;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // progressBarAdv2
            // 
            this.progressBarAdv2.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv2.BackSegments = false;
            this.progressBarAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.progressBarAdv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv2.CustomText = null;
            this.progressBarAdv2.CustomWaitingRender = false;
            this.progressBarAdv2.ForeColor = Color.FromArgb(254, 0, 0);
            this.progressBarAdv2.ForegroundImage = null;
            this.progressBarAdv2.ForeSegments = false;
            resources.ApplyResources(this.progressBarAdv2, "progressBarAdv2");
            this.progressBarAdv2.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv2.Name = "progressBarAdv2";
            this.progressBarAdv2.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv2.SegmentWidth = 12;
            this.progressBarAdv2.TextVisible = false;
            this.progressBarAdv2.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.progressBarAdv2.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBarAdv2.Value = 0;
            this.progressBarAdv2.WaitingGradientWidth = 400;
            progressBarAdv2.Width = 20;
            progressBarAdv2.Height = 225;
            // 
            // progressBarAdv3
            // 
            this.progressBarAdv3.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.BackSegments = false;
            this.progressBarAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.progressBarAdv3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv3.CustomText = null;
            this.progressBarAdv3.CustomWaitingRender = false;
            this.progressBarAdv3.ForeColor = Color.FromArgb(254, 0, 0);
            this.progressBarAdv3.ForegroundImage = null;
            this.progressBarAdv3.ForeSegments = false;
            resources.ApplyResources(this.progressBarAdv3, "progressBarAdv3");
            this.progressBarAdv3.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.Name = "progressBarAdv3";
            this.progressBarAdv3.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv3.SegmentWidth = 12;
            this.progressBarAdv3.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv3.TextVisible = false;
            this.progressBarAdv3.ThemeStyle.BackColor = System.Drawing.Color.Maroon;
            this.progressBarAdv3.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBarAdv3.ThemeStyle.BorderThickness = 0;
            this.progressBarAdv3.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarAdv3.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarAdv3.ThemeStyle.DisabledFillColor = System.Drawing.Color.Green;
            this.progressBarAdv3.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBarAdv3.Value = 0;
            this.progressBarAdv3.WaitingGradientWidth = 400;
            progressBarAdv3.Width = 20;
            progressBarAdv3.Height = 225;
            // 
            // A7_Music
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.progressBarAdv3);
            this.Controls.Add(this.progressBarAdv2);
            this.Controls.Add(this.progressBarAdv1);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.npl);
            this.Controls.Add(this.bps);
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
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ListView MusicList;
        private Button Browse;
        private Button Pause;
        private System.Windows.Forms.Label Title;
        private Krypton.Toolkit.KryptonTrackBar voltb;
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
        protected Krypton.Toolkit.KryptonTrackBar seek;
        private Label bps;
        private Label npl;
        private CheckBox  repeat;
        private Label ln;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv2;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv3;
    }
}

