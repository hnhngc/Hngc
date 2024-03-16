using System;
using System.Windows.Forms;

namespace Game02
{
    public partial class MainMenu : Form
    {
        private Options optionsForm;
        private CharSelect charSelectForm;

        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (optionsForm != null )
            {
                optionsForm.Show(); // Hiển thị lại form Options nếu nó chưa bị dispose
            }
            else if (charSelectForm != null)
            {
                charSelectForm = new CharSelect(); // Tạo một thể hiện mới của form CharSelect
                charSelectForm.Show(); // Hiển thị form CharSelect mới
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            /*try
            {
                SoundManager.Play(@"C:\Users\Dell\Downloads\27-Chill.wav");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phát âm thanh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundManager.Stop();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            optionsForm = new Options();
            optionsForm.Show();
            this.Hide(); // Ẩn form MainMenu khi hiển thị form Options
        }

        private void button1_Click(object sender, EventArgs e)
        {
            charSelectForm = new CharSelect();
            this.Hide(); // Ẩn form MainMenu khi hiển thị form CharSelect
            charSelectForm.Show();
        }

       
        

    }
}
