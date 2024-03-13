using System;
using System.Windows.Forms;

namespace Game02
{
    public partial class CharSelect : Form
    {
        int SelectChar = 0;

        public CharSelect()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lvl_a lvla = new lvl_a(SelectChar);
            lvla.FormClosed += (s, args) => this.Close(); // Đóng form hiện tại sau khi form mới đã đóng
            this.Hide();
            lvla.Show();
            
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
