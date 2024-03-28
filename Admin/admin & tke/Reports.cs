using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace admin___tke
{
    public partial class Reports : Form
    {
        private static Reports _instance;
        private static readonly object _lock = new object();

        public static Reports Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Reports();
                        }
                    }
                }

                return _instance;
            }
        }

        public Reports()
        {
            InitializeComponent();

            using (SqlConnection sqlConnection = Kết_nối.getConnection())
            {
                sqlConnection.Open();

                string query = "SELECT MAX(userid) FROM users";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                int lastUserId = (int)command.ExecuteScalar();

                label2.Text = $"{lastUserId}";

                sqlConnection.Close();
            }

            // Tạo biểu đồ mới cho dữ liệu trò chơi hàng đầu
            Chart chart = new Chart();

            // Đặt thuộc tính Dock của biểu đồ thành Fill để chiếm toàn bộ biểu mẫu
            chart.Dock = DockStyle.Fill;

            // Đặt thuộc tính ChartArea của biểu đồ thành ChartArea mới
            chart.ChartAreas.Add(new ChartArea());

            // Đặt thuộc tính Sê-ri của biểu đồ thành Sê-ri mới
            chart.Series.Add(new Series { ChartType = SeriesChartType.Pie });

            // Nhận dữ liệu trò chơi hàng đầu
            using (SqlConnection sqlConnection = Kết_nối.getConnection())
            {
                sqlConnection.Open();

                string query = "SELECT TOP 3 g.GameName, COUNT(*) FROM GameSessions gs " +
                                "JOIN Games g ON gs.GameID = g.GameID " +
                                "GROUP BY g.GameName " +
                                "ORDER BY COUNT(*) DESC";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string game = reader.GetString(0);
                        int count = reader.GetInt32(1);

                        // Thêm dữ liệu trò chơi hàng đầu vào biểu đồ
                        chart.Series[0].Points.Add(new DataPoint { Label = game, YValues = new double[] { count } });
                    }
                }

                sqlConnection.Close();
            }

            // Thêm biểu đồ vào điều khiển guna2Panel3
            guna2Panel3.Controls.Add(chart);

            // Tạo biểu đồ mới cho những người chơi hàng đầu
            Chart playerChart = new Chart();

            // Đặt thuộc tính Dock của biểu đồ thành Fill để chiếm toàn bộ biểu mẫu
            playerChart.Dock = DockStyle.Fill;

            // Đặt thuộc tính ChartArea của biểu đồ thành ChartArea mới
            playerChart.ChartAreas.Add(new ChartArea());

            // Đặt thuộc tính Sê-ri của biểu đồ thành Sê-ri mới
            playerChart.Series.Add(new Series { ChartType = SeriesChartType.Pie });

            // Nhận 5 người chơi hàng đầu dựa trên ID người dùng
            using (SqlConnection sqlConnection = Kết_nối.getConnection())
            {
                sqlConnection.Open();

                string query = "SELECT TOP 5 u.username, COUNT(*) FROM GameSessions gs " +
                                "JOIN users u ON gs.userid = u.userid " +
                                "GROUP BY u.username " +
                                "ORDER BY COUNT(*) DESC";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = reader.GetString(0);
                        int count = reader.GetInt32(1);

                        // Thêm dữ liệu người chơi hàng đầu vào biểu đồ
                        playerChart.Series[0].Points.Add(new DataPoint { Label = username, YValues = new double[] { count } });
                    }
                }

                sqlConnection.Close();
            }

            // Thêm biểu đồ vào điều khiển guna2Panel4
            guna2Panel4.Controls.Add(playerChart);

            Chart userPerDayChart = new Chart();
            userPerDayChart.Dock = DockStyle.Fill;

            ChartArea userPerDayArea = new ChartArea();
            userPerDayArea.Name = "UserPerDayArea";
            userPerDayChart.ChartAreas.Add(userPerDayArea);

            Series userPerDaySeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "UserPerDaySeries"
            };
            userPerDayChart.Series.Add(userPerDaySeries);

            // Lấy số lượng người dùng tham gia mỗi ngày
            using (SqlConnection sqlConnection = Kết_nối.getConnection())
            {
                sqlConnection.Open();

                string query = "SELECT COUNT(*) as count, CAST(NGAYTHAMGIA as DATE) as date " +
                               "FROM Users " +
                               "WHERE NGAYTHAMGIA IS NOT NULL " +
                               "GROUP BY CAST(NGAYTHAMGIA as DATE) " +
                               "ORDER BY CAST(NGAYTHAMGIA as DATE)";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(1);
                        int count = reader.GetInt32(0);

                        // Convert the DateTime value to a double value using the ToOADate method
                        double xValue = date.ToOADate();

                        // Thêm số lượng người dùng tham gia mỗi ngày vào biểu đồ
                        userPerDaySeries.Points.Add(new DataPoint(xValue, count));
                    }
                }

                sqlConnection.Close();
            }

            // Set the X-value type to Date
            userPerDaySeries.XValueType = ChartValueType.Date;

            // Format the X-axis labels to display the date in the format "dd/MM/yyyy"
            userPerDayChart.ChartAreas["UserPerDayArea"].AxisX.LabelStyle.Format = "dd/MM/yyyy";

            // Add the chart to the pnl_c3 control
            pnl_c3.Controls.Add(userPerDayChart);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Down_Click(object sender, EventArgs e)
        {

        }

        private void btn_GamePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Player ap = new Admin_Player();
            ap.ShowDialog();
        }
    }
}