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
    public partial class Support : Form
    {
        private string _username;
        public Support(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu(_username);
            mainMenu.ShowDialog();
            this.Close();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu(_username);
            mn.ShowDialog();
            this.Close();
        }
    }
}
