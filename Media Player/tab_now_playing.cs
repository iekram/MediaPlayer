using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Media_Player
{
    public partial class tab_now_playing : UserControl
    {
        private string _command;
        private bool isOpen;

        [DllImport("wimm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        public tab_now_playing()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }
        
        private void browseButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
            ofd.Filter = "mp3 files|*.mp3|All files (*.*)|*.*";
            ofd.Multiselect = true;
            
            //ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach(string f in ofd.FileNames)
                {
                    
                    FileInfo fi = new FileInfo(f);
                    ListViewItem item = new ListViewItem(fi.Name);

                    var onlyName = System.IO.Path.GetFileName(ofd.FileName);

                    //item.SubItems.Add(fi.FullName);
                    song_listView.ItemHeight = 20;
                    song_listView.Items.Add(onlyName.ToString());
                    //song_listView.ItemHeight = 20;
                    //song_listView.Items.Add(ofd.FileName.ToString()-ofd.fil);
                }

                //song_listView.ItemHeight = 20;
                //song_listView.Items.Add(ofd.FileName.ToString());
            }
        }

        public void Play(bool loop)
        {
            if (isOpen)
            {
                _command = "play MediaFile";
                if (loop)
                    _command += "REPEAT";
                mciSendString(_command, null, 0, IntPtr.Zero);
            }
        }

        public void OpenPlayer(string sFileName)
        {
            _command = "open\"" + sFileName + "\"type mpegvideo alias MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        public void ClosePlayer()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenPlayer(this.song_listView.Text);
                this.Play(false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClosePlayer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
