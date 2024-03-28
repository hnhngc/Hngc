using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Game02
{
    public partial class MainMenu : Form
    {
        
        private Options option;
        private SoundManager soundManager;
        private string _username;

        public MainMenu(string username)
        {
            InitializeComponent();
            _username = username;
            lbl_Username.Text = _username;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += MainMenu_Load;

            // Khởi tạo đối tượng option
            option = new Options(_username);
            soundManager = SoundManager.GetInstance();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            // Kiểm tra trạng thái âm thanh từ Options và bắt đầu hoặc dừng phát âm thanh tương ứng
            if (soundManager.IsPlaying())
            {
                soundManager.Play();
            }
            else
            {
                soundManager.Stop();
            }
        }
        private void ShowScoreboard()
        {
            Scoreboard scoreboardForm = new Scoreboard(_username);

            using (SqlConnection sqlConnection = admin___tke.Kết_nối.getConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(
                        "SELECT TOP 3 U.UserName, G.Score " +
                        "FROM (" +
                            "SELECT MAX(Score) as Score, UserID " +
                            "FROM GameSessions " +
                            "WHERE GameID = 2 " +
                            "GROUP BY UserID " +
                        ") G JOIN Users U ON G.UserID = U.UserID " +
                        "ORDER BY G.Score DESC", sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    Dictionary<string, int> topPlayers = new Dictionary<string, int>();

                    while (reader.Read())
                    {
                        string playerName = reader["UserName"].ToString();
                        int score = Convert.ToInt32(reader["Score"]);

                        topPlayers.Add(playerName, score);
                    }

                    scoreboardForm.UpdateTopPlayers(topPlayers);
                }
            }

            scoreboardForm.ShowDialog();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            soundManager.Stop();
        }

        private void btn_Opt_Click(object sender, EventArgs e)
        {
            Options optionsForm = new Options(_username);
            optionsForm.Show();
            this.Hide();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            CharSelect charSelectForm = new CharSelect(_username);
            this.Hide();
            charSelectForm.Show();
        }

        private void btn_Score_Click(object sender, EventArgs e)
        {
            ShowScoreboard();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainMenu mainMn = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if(mainMn != null)
            {
                mainMn.Hide();
            }
            this.Close();
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }
    }
}
