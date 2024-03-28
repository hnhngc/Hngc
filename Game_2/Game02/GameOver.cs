using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Game02
{
    public partial class GameOver : Form
    {
        private string _username;
        private int _userID;
        public GameOver()
        {
            InitializeComponent();
        }

        private void btn_NewG_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharSelect charSelect = new CharSelect(_username);
            charSelect.ShowDialog();
            this.Close();
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu(_username);
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
