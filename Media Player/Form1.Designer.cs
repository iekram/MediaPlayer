namespace Media_Player
{
    partial class media_player_001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(media_player_001));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.volumeButton = new ns1.BunifuFlatButton();
            this.listeningButton = new ns1.BunifuFlatButton();
            this.nowPlayingButton = new ns1.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_now_playing1 = new Media_Player.tab_now_playing();
            this.tab_volume1 = new Media_Player.tab_volume();
            this.tab_listening1 = new Media_Player.tab_listening();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(510, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(480, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // volumeButton
            // 
            this.volumeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.volumeButton.BackColor = System.Drawing.Color.Black;
            this.volumeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volumeButton.BorderRadius = 7;
            this.volumeButton.ButtonText = "Volume";
            this.volumeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeButton.DisabledColor = System.Drawing.Color.Gray;
            this.volumeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.volumeButton.Iconimage = null;
            this.volumeButton.Iconimage_right = null;
            this.volumeButton.Iconimage_right_Selected = null;
            this.volumeButton.Iconimage_Selected = null;
            this.volumeButton.IconMarginLeft = 0;
            this.volumeButton.IconMarginRight = 0;
            this.volumeButton.IconRightVisible = true;
            this.volumeButton.IconRightZoom = 0D;
            this.volumeButton.IconVisible = true;
            this.volumeButton.IconZoom = 1D;
            this.volumeButton.IsTab = true;
            this.volumeButton.Location = new System.Drawing.Point(200, 64);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Normalcolor = System.Drawing.Color.Black;
            this.volumeButton.OnHovercolor = System.Drawing.Color.Black;
            this.volumeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.volumeButton.selected = false;
            this.volumeButton.Size = new System.Drawing.Size(145, 31);
            this.volumeButton.TabIndex = 4;
            this.volumeButton.Text = "Volume";
            this.volumeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.volumeButton.Textcolor = System.Drawing.Color.White;
            this.volumeButton.TextFont = new System.Drawing.Font("Century Gothic", 11F);
            this.volumeButton.Click += new System.EventHandler(this.volumeButton_Click);
            // 
            // listeningButton
            // 
            this.listeningButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.listeningButton.BackColor = System.Drawing.Color.Black;
            this.listeningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listeningButton.BorderRadius = 7;
            this.listeningButton.ButtonText = "Listening";
            this.listeningButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listeningButton.DisabledColor = System.Drawing.Color.Gray;
            this.listeningButton.Iconcolor = System.Drawing.Color.Transparent;
            this.listeningButton.Iconimage = null;
            this.listeningButton.Iconimage_right = null;
            this.listeningButton.Iconimage_right_Selected = null;
            this.listeningButton.Iconimage_Selected = null;
            this.listeningButton.IconMarginLeft = 0;
            this.listeningButton.IconMarginRight = 0;
            this.listeningButton.IconRightVisible = true;
            this.listeningButton.IconRightZoom = 0D;
            this.listeningButton.IconVisible = true;
            this.listeningButton.IconZoom = 1D;
            this.listeningButton.IsTab = true;
            this.listeningButton.Location = new System.Drawing.Point(389, 64);
            this.listeningButton.Name = "listeningButton";
            this.listeningButton.Normalcolor = System.Drawing.Color.Black;
            this.listeningButton.OnHovercolor = System.Drawing.Color.Black;
            this.listeningButton.OnHoverTextColor = System.Drawing.Color.White;
            this.listeningButton.selected = false;
            this.listeningButton.Size = new System.Drawing.Size(145, 31);
            this.listeningButton.TabIndex = 5;
            this.listeningButton.Text = "Listening";
            this.listeningButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listeningButton.Textcolor = System.Drawing.Color.White;
            this.listeningButton.TextFont = new System.Drawing.Font("Century Gothic", 11F);
            this.listeningButton.Click += new System.EventHandler(this.listeningButton_Click);
            // 
            // nowPlayingButton
            // 
            this.nowPlayingButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.nowPlayingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.nowPlayingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nowPlayingButton.BorderRadius = 7;
            this.nowPlayingButton.ButtonText = "Now Playing";
            this.nowPlayingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nowPlayingButton.DisabledColor = System.Drawing.Color.Gray;
            this.nowPlayingButton.Iconcolor = System.Drawing.Color.Transparent;
            this.nowPlayingButton.Iconimage = null;
            this.nowPlayingButton.Iconimage_right = null;
            this.nowPlayingButton.Iconimage_right_Selected = null;
            this.nowPlayingButton.Iconimage_Selected = null;
            this.nowPlayingButton.IconMarginLeft = 0;
            this.nowPlayingButton.IconMarginRight = 0;
            this.nowPlayingButton.IconRightVisible = true;
            this.nowPlayingButton.IconRightZoom = 0D;
            this.nowPlayingButton.IconVisible = true;
            this.nowPlayingButton.IconZoom = 1D;
            this.nowPlayingButton.IsTab = true;
            this.nowPlayingButton.Location = new System.Drawing.Point(11, 64);
            this.nowPlayingButton.Name = "nowPlayingButton";
            this.nowPlayingButton.Normalcolor = System.Drawing.Color.Black;
            this.nowPlayingButton.OnHovercolor = System.Drawing.Color.Black;
            this.nowPlayingButton.OnHoverTextColor = System.Drawing.Color.White;
            this.nowPlayingButton.selected = true;
            this.nowPlayingButton.Size = new System.Drawing.Size(145, 31);
            this.nowPlayingButton.TabIndex = 6;
            this.nowPlayingButton.Text = "Now Playing";
            this.nowPlayingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nowPlayingButton.Textcolor = System.Drawing.Color.White;
            this.nowPlayingButton.TextFont = new System.Drawing.Font("Century Gothic", 11F);
            this.nowPlayingButton.Click += new System.EventHandler(this.nowPlayingButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tab_now_playing1);
            this.panel1.Controls.Add(this.tab_volume1);
            this.panel1.Controls.Add(this.tab_listening1);
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 425);
            this.panel1.TabIndex = 8;
            // 
            // tab_now_playing1
            // 
            this.tab_now_playing1.BackColor = System.Drawing.Color.Black;
            this.tab_now_playing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_now_playing1.Location = new System.Drawing.Point(0, 0);
            this.tab_now_playing1.Name = "tab_now_playing1";
            this.tab_now_playing1.Size = new System.Drawing.Size(522, 425);
            this.tab_now_playing1.TabIndex = 2;
            // 
            // tab_volume1
            // 
            this.tab_volume1.BackColor = System.Drawing.Color.Black;
            this.tab_volume1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_volume1.Location = new System.Drawing.Point(0, 0);
            this.tab_volume1.Name = "tab_volume1";
            this.tab_volume1.Size = new System.Drawing.Size(522, 425);
            this.tab_volume1.TabIndex = 0;
            // 
            // tab_listening1
            // 
            this.tab_listening1.BackColor = System.Drawing.Color.Black;
            this.tab_listening1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_listening1.Location = new System.Drawing.Point(0, 0);
            this.tab_listening1.Name = "tab_listening1";
            this.tab_listening1.Size = new System.Drawing.Size(522, 425);
            this.tab_listening1.TabIndex = 1;
            // 
            // media_player_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(545, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nowPlayingButton);
            this.Controls.Add(this.listeningButton);
            this.Controls.Add(this.volumeButton);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "media_player_001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuImageButton bunifuImageButton2;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuFlatButton volumeButton;
        private ns1.BunifuFlatButton nowPlayingButton;
        private ns1.BunifuFlatButton listeningButton;
        private System.Windows.Forms.Panel panel1;
        private tab_volume tab_volume1;
        private tab_listening tab_listening1;
        private tab_now_playing tab_now_playing1;
    }
}

