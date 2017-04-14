namespace Media_Player
{
    partial class tab_now_playing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab_now_playing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.song_listView = new System.Windows.Forms.ListBox();
            this.stopButton = new ns1.BunifuImageButton();
            this.nextButton = new ns1.BunifuImageButton();
            this.playButton = new ns1.BunifuImageButton();
            this.previousButton = new ns1.BunifuImageButton();
            this.browseButton = new ns1.BunifuImageButton();
            this.list_view1 = new Media_Player.list_view();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.list_view1);
            this.panel1.Controls.Add(this.song_listView);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 425);
            this.panel1.TabIndex = 0;
            // 
            // song_listView
            // 
            this.song_listView.BackColor = System.Drawing.Color.Black;
            this.song_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.song_listView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.song_listView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.song_listView.FormattingEnabled = true;
            this.song_listView.ItemHeight = 21;
            this.song_listView.Location = new System.Drawing.Point(118, 33);
            this.song_listView.Name = "song_listView";
            this.song_listView.Size = new System.Drawing.Size(307, 294);
            this.song_listView.TabIndex = 10;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Black;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageActive = null;
            this.stopButton.Location = new System.Drawing.Point(364, 360);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(21, 21);
            this.stopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopButton.TabIndex = 9;
            this.stopButton.TabStop = false;
            this.stopButton.Zoom = 10;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Black;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageActive = null;
            this.nextButton.Location = new System.Drawing.Point(309, 360);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(21, 21);
            this.nextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextButton.TabIndex = 8;
            this.nextButton.TabStop = false;
            this.nextButton.Zoom = 10;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageActive = null;
            this.playButton.Location = new System.Drawing.Point(246, 360);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(21, 21);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 7;
            this.playButton.TabStop = false;
            this.playButton.Zoom = 10;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Black;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.ImageActive = null;
            this.previousButton.Location = new System.Drawing.Point(190, 360);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(21, 21);
            this.previousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previousButton.TabIndex = 6;
            this.previousButton.TabStop = false;
            this.previousButton.Zoom = 10;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Black;
            this.browseButton.Image = ((System.Drawing.Image)(resources.GetObject("browseButton.Image")));
            this.browseButton.ImageActive = null;
            this.browseButton.Location = new System.Drawing.Point(138, 360);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(21, 21);
            this.browseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.browseButton.TabIndex = 5;
            this.browseButton.TabStop = false;
            this.browseButton.Zoom = 10;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click_1);
            // 
            // list_view1
            // 
            this.list_view1.BackColor = System.Drawing.Color.Black;
            this.list_view1.Location = new System.Drawing.Point(407, 21);
            this.list_view1.Name = "list_view1";
            this.list_view1.Size = new System.Drawing.Size(200, 425);
            this.list_view1.TabIndex = 11;
            // 
            // tab_now_playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Name = "tab_now_playing";
            this.Size = new System.Drawing.Size(522, 425);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton stopButton;
        private ns1.BunifuImageButton nextButton;
        private ns1.BunifuImageButton playButton;
        private ns1.BunifuImageButton previousButton;
        private ns1.BunifuImageButton browseButton;
        private System.Windows.Forms.ListBox song_listView;
        private list_view list_view1;
    }
}
