using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class tab_listening : UserControl
    {
        public tab_listening()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            movie_mode1.BringToFront();
        }

        private void musicModeButton_Click(object sender, EventArgs e)
        {
            music_mode1.BringToFront();
        }
    }
}
