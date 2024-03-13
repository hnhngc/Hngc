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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharSelect charSelect = new CharSelect();
            charSelect.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            mainMenu.StartPosition = FormStartPosition.CenterParent;
            mainMenu.BringToFront();
            this.Close();
        }
    }
}
