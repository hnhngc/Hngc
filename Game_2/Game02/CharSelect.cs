using System;
using System.Windows.Forms;

namespace Game02
{
    public partial class CharSelect : Form
    {
        private string _username;
        private int _userID;
        int SelectChar = 0;

        public CharSelect(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (SelectChar != 0)
            {
                lvl_a lvla = new lvl_a(SelectChar, _username);
                lvla.FormClosed += (s, args) => this.Close(); // Đóng form hiện tại sau khi form mới đã đóng
                this.Hide();
                lvla.Show();
            }
            else
            {
                MessageBox.Show("Choose a character to enter game!", "Select Character", MessageBoxButtons.OK); 
            }
            
        }

        public void CharChanged()
        {
            if (!IsDisposed)
            {
                picP1.BorderStyle = (SelectChar == 1) ? BorderStyle.Fixed3D : BorderStyle.None;
                picP2.BorderStyle = (SelectChar == 2) ? BorderStyle.Fixed3D : BorderStyle.None;
            }
        }

        private void picP1_Click(object sender, EventArgs e)
        {
            SelectChar = 1;
            CharChanged();
        }

        private void picP2_Click(object sender, EventArgs e)
        {
            SelectChar = 2;
            CharChanged();
        }
    }
}
