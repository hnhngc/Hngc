using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Game02
{
    public partial class Options : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();
        public bool isPlaying = true;
        
        
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Support support = new Support();
            support.ShowDialog();
            this.Close();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                soundPlayer.Stop();
                btn_Play.Text = "Play";
            }
            else
            {
                soundPlayer.Play();
                btn_Play.Text = "Stop";
            }

            isPlaying = !isPlaying;
            
        }

    }
}
