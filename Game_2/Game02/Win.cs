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
    public partial class Win : Form
    {
        private int score;
        public Win()
        {
            InitializeComponent();
        }
        public void SetScore(int score)
        {
            this.score = score;
            lblScore.Text = "Your score: " + score.ToString(); // Giả sử lblScore là tên của Label để hiển thị điểm số
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CharSelect charSelect = new CharSelect();
            charSelect.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
