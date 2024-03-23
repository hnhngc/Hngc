using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Game02
{
    public partial class MainMenu : Form
    {
        private SoundPlayer soundPlayer;
        private Options option;
        private bool PlaySound;

        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += MainMenu_Load;

            // Khởi tạo đối tượng option
            option = new Options();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra trạng thái của option.isPlaying
                if (option.isPlaying)
                {
                    // Khởi tạo đối tượng SoundPlayer
                    soundPlayer = new SoundPlayer();

                    // Lấy đường dẫn thư mục của ứng dụng
                    string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string filePath = Path.Combine(directory, "Chill.wav");

                    // Kiểm tra xem tệp âm thanh có tồn tại không
                    if (File.Exists(filePath))
                    {
                        // Đặt đường dẫn âm thanh cho SoundPlayer và phát
                        soundPlayer.SoundLocation = filePath;
                        soundPlayer.Play();
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy tệp âm thanh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phát tệp âm thanh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dừng phát âm thanh khi form đóng
            soundPlayer?.Stop();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Options optionsForm = new Options();
            optionsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CharSelect charSelectForm = new CharSelect();
            this.Hide();
            charSelectForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Scoreboard sb = new Scoreboard();
            this.Hide();
            sb.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
