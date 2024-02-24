using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lvl_a start = new lvl_a(SelectChar);
            this.Hide();
            start.Show();
        }
        public void CharChanged()
        {
            if(SelectChar == 1)
            {
                picP1.BorderStyle = BorderStyle.Fixed3D;
                picP2.BorderStyle = BorderStyle.None;
            }
            else if (SelectChar == 2)
            {
                picP1.BorderStyle = BorderStyle.None;
                picP2.BorderStyle = BorderStyle.Fixed3D;
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
