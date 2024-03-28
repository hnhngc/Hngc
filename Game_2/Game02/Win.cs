using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Game02
{
    public partial class Win : Form
    {
        private int score;
        private string _username;

        public Win(string username)
        {
            InitializeComponent();
            _username = username;
            lbl_Username.Text = _username;
            InsertGameSession();
        }

        private int GetUserId(string username)
        {
            int userId = -1;

            using (SqlConnection sqlConnection = admin___tke.Kết_nối.getConnection())
            {
                sqlConnection.Open();
                string query = "SELECT UserID FROM Users WHERE UserName = @username";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }
                }
            }

            return userId;
        }


        private void InsertGameSession()
        {
            DateTime date = DateTime.Now;
            DateTime currentDate = DateTime.Now;
            int userId = GetUserId(_username);
            int gameId = 2;
            using (SqlConnection sqlConnection = admin___tke.Kết_nối.getConnection())
            {
                sqlConnection.Open();
                // Get max GameSessionID
                int maxGameSessionID = 0;
                string query = "SELECT MAX(GameSessionID) FROM GameSessions";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    maxGameSessionID = reader.GetInt32(0);
                }
                reader.Close();

                
                // Format the startDate and endDate
                string dateString = date.ToString("yyyy-MM-dd HH:mm:ss");
                string currentDateString = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

                // Insert new GameSession row with incremented GameSessionID
                query = "INSERT INTO GameSessions (GameSessionID, GameID, UserID, StartDate, EndDate, Score) VALUES (@gameSessionID, @gameId, @userId, @startDate, @endDate, @score)";
                command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@gameSessionID", maxGameSessionID + 1);
                command.Parameters.AddWithValue("@gameId", gameId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@startDate", dateString);
                command.Parameters.AddWithValue("@endDate", currentDateString);
                command.Parameters.AddWithValue("@score", score);

                command.ExecuteNonQuery();
            }
        }

        public void SetScore(int score)
        {
            this.score = score;
            lblScore.Text = "Your score: " + score.ToString();
        }

        private void btn_NewG_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharSelect charSelect = new CharSelect(_username);
            charSelect.Show();
            this.Close();
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            InsertGameSession();
            this.Hide();
            MainMenu menu = new MainMenu(_username);
            menu.ShowDialog();
            this.Close();
        }
    }
}