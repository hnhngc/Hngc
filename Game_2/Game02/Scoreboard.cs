using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Game02
{
    public partial class Scoreboard : Form
    {
        private string _username;
        public Scoreboard(string username)
        {
            InitializeComponent();
            _username = username;
        }

        public string PlayerName { get; set; }
        public int ScoreValue { get; set; }

        public Scoreboard(string playerName, int scoreValue)
        {
            PlayerName = playerName;
            ScoreValue = scoreValue;
        }
        public void UpdateTopPlayers(Dictionary<string, int> topPlayers)
        {
            if (topPlayers.Count != 3)
            {
                MessageBox.Show("Invalid number of top players!");
                return;
            }

            lbl_1st.Text = topPlayers.ElementAt(0).Key;
            lbl_S_1st.Text = $"Score: {topPlayers.ElementAt(0).Value}";

            lbl_2nd.Text = topPlayers.ElementAt(1).Key;
            lbl_S_2nd.Text = $"Score: {topPlayers.ElementAt(1).Value}";

            lbl_3rd.Text = topPlayers.ElementAt(2).Key;
            lbl_S_3rd.Text = $"Score: {topPlayers.ElementAt(2).Value}";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
