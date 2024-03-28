using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Game02
{
    public partial class Options : Form
    {
        private string _username;
        private SoundManager soundManager;

        public Options(string username)
        {
            InitializeComponent();
            _username = username;
            soundManager = SoundManager.GetInstance();
            UpdateButtonState();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu(_username);
            mn.ShowDialog();
            this.Close();
        }

        private void btn_Sp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Support support = new Support(_username);
            support.ShowDialog();
            this.Close();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            // Bật hoặc tắt âm thanh
            soundManager.ToggleSound();

            // Cập nhật trạng thái của nút
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // Cập nhật văn bản của nút dựa trên trạng thái hiện tại của âm thanh
            if (soundManager.IsPlaying())
            {
                btn_Play.Text = "Pause Sound";
            }
            else
            {
                btn_Play.Text = "Play Sound";
            }
        }
    }
}
