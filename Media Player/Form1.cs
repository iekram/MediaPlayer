using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class media_player_001 : Form
    {
        public media_player_001()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void volumeButton_Click(object sender, EventArgs e)
        {
            tab_volume1.BringToFront();
        }

        private void listeningButton_Click(object sender, EventArgs e)
        {
            tab_listening1.BringToFront();
        }
        

        private void nowPlayingButton_Click_1(object sender, EventArgs e)
        {
            tab_now_playing1.BringToFront();
        }
    }
}
