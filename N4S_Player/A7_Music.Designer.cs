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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A7_Music));
            this.MusicList = new System.Windows.Forms.ListBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.voltb = new System.Windows.Forms.TrackBar();
            this.npl = new System.Windows.Forms.Label();
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
            this.repeat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.voltb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicList
            // 
            this.MusicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicList.BackColor = System.Drawing.Color.Gray;
            this.MusicList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MusicList.Cursor = System.Windows.Forms.Cursors.Default;
            this.MusicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MusicList.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MusicList.ItemHeight = 16;
            this.MusicList.Location = new System.Drawing.Point(396, 88);
            this.MusicList.Margin = new System.Windows.Forms.Padding(6);
            this.MusicList.Name = "MusicList";
            this.MusicList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MusicList.Size = new System.Drawing.Size(396, 354);
            this.MusicList.TabIndex = 0;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Browse.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Browse.ForeColor = System.Drawing.Color.Coral;
            this.Browse.Location = new System.Drawing.Point(396, 464);
            this.Browse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(88, 27);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(396, 59);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(89, 20);
            this.Title.TabIndex = 4;
            this.Title.Text = "Music List";
            this.Title.UseWaitCursor = true;
            // 
            // voltb
            // 
            this.voltb.Location = new System.Drawing.Point(336, 370);
            this.voltb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.voltb.Maximum = 100;
            this.voltb.Name = "voltb";
            this.voltb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.voltb.Size = new System.Drawing.Size(45, 120);
            this.voltb.TabIndex = 5;
            // 
            // npl
            // 
            this.npl.AutoSize = true;
            this.npl.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.npl.ForeColor = System.Drawing.Color.Red;
            this.npl.Location = new System.Drawing.Point(14, 15);
            this.npl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.npl.Name = "npl";
            this.npl.Size = new System.Drawing.Size(0, 18);
            this.npl.TabIndex = 7;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.BackColor = System.Drawing.Color.Olive;
            this.Duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Duration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Duration.Location = new System.Drawing.Point(14, 301);
            this.Duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(16, 23);
            this.Duration.TabIndex = 10;
            this.Duration.Text = " ";
            this.Duration.Visible = false;
            // 
            // seek
            // 
            this.seek.Location = new System.Drawing.Point(14, 330);
            this.seek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.seek.Maximum = 100;
            this.seek.Name = "seek";
            this.seek.Size = new System.Drawing.Size(374, 45);
            this.seek.TabIndex = 11;
            // 
            // playtime
            // 
            this.playtime.Enabled = true;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Gray;
            this.Next.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Next.Image = global::N4S_Player.Properties.Resources.icons8_fast_forward_48;
            this.Next.Location = new System.Drawing.Point(245, 413);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(44, 39);
            this.Next.TabIndex = 15;
            this.Next.UseVisualStyleBackColor = false;
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Gray;
            this.Previous.Image = global::N4S_Player.Properties.Resources.icons8_rewind_48;
            this.Previous.Location = new System.Drawing.Point(96, 413);
            this.Previous.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(44, 39);
            this.Previous.TabIndex = 14;
            this.Previous.Text = " ";
            this.Previous.UseVisualStyleBackColor = false;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stop.Image = global::N4S_Player.Properties.Resources.icons8_stop_48;
            this.Stop.Location = new System.Drawing.Point(163, 473);
            this.Stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(54, 53);
            this.Stop.TabIndex = 9;
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Visible = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.LightSlateGray;
            this.Play.Image = global::N4S_Player.Properties.Resources.icons8_play_48;
            this.Play.Location = new System.Drawing.Point(148, 392);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(88, 74);
            this.Play.TabIndex = 8;
            this.Play.UseVisualStyleBackColor = false;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Gainsboro;
            this.Pause.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pause.Image = global::N4S_Player.Properties.Resources.icons8_pause_48;
            this.Pause.Location = new System.Drawing.Point(148, 393);
            this.Pause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(88, 74);
            this.Pause.TabIndex = 3;
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Visible = false;
            // 
            // vollbl
            // 
            this.vollbl.AutoSize = true;
            this.vollbl.Font = new System.Drawing.Font("PMingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vollbl.Location = new System.Drawing.Point(332, 494);
            this.vollbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vollbl.Name = "vollbl";
            this.vollbl.Size = new System.Drawing.Size(44, 11);
            this.vollbl.TabIndex = 16;
            this.vollbl.Text = "Volume";
            // 
            // PlayImage
            // 
            this.PlayImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PlayImage.ErrorImage")));
            this.PlayImage.Image = global::N4S_Player.Properties.Resources.avatars_000606604806_j6ghpm_t500x500;
            this.PlayImage.Location = new System.Drawing.Point(76, 59);
            this.PlayImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlayImage.Name = "PlayImage";
            this.PlayImage.Size = new System.Drawing.Size(252, 265);
            this.PlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayImage.TabIndex = 17;
            this.PlayImage.TabStop = false;
            // 
            // TDuration
            // 
            this.TDuration.AutoSize = true;
            this.TDuration.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.TDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDuration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TDuration.ForeColor = System.Drawing.Color.Blue;
            this.TDuration.Location = new System.Drawing.Point(336, 301);
            this.TDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TDuration.Name = "TDuration";
            this.TDuration.Size = new System.Drawing.Size(2, 23);
            this.TDuration.TabIndex = 18;
            this.TDuration.Visible = false;
            // 
            // repeat
            // 
            this.repeat.AutoSize = true;
            this.repeat.Location = new System.Drawing.Point(26, 394);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(62, 19);
            this.repeat.TabIndex = 19;
            this.repeat.Text = "Repeat";
            this.repeat.UseVisualStyleBackColor = true;
            // 
            // A7_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(807, 570);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.TDuration);
            this.Controls.Add(this.PlayImage);
            this.Controls.Add(this.vollbl);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.seek);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.npl);
            this.Controls.Add(this.voltb);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.MusicList);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "A7_Music";
            this.Text = "A Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.voltb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TrackBar voltb;
        private System.Windows.Forms.Label npl;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.TrackBar seek;
        public System.Windows.Forms.Timer playtime;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label vollbl;
        private System.Windows.Forms.PictureBox PlayImage;
        private System.Windows.Forms.Label TDuration;
        private CheckBox repeat;
    }
}

