using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin___tke
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btn_GamePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Player ap = new Admin_Player();   
            ap.ShowDialog();
        }
    }
}
