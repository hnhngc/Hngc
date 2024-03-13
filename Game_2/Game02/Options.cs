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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            
        }

        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Support support = new Support();
            support.ShowDialog();
            this.Close();
        }
    }
}
