using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Minesweeper
{
    internal class ScoreboardDataManager
    {
        
        private static string connectionString = "Data Source=KEROSWIFT\\SQLEXPRESS;Initial Catalog=MinesweeperScoreboard;Integrated Security=True";
        public static DataTable dataTable;

        public static void createDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Place", typeof(int));
            dataTable.Columns.Add("Score", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
        }
        public static void readRecords()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string selectQuery = "SELECT * FROM Scoreboard";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();     
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int retrievedScore = reader.GetInt32(1);
                string retrievedUsername = reader.GetString(2);
                DateTime retrievedDate = reader.GetDateTime(3);

                DataRow dataRow = dataTable.NewRow();
                dataRow["Place"] = id;
                dataRow["Score"] = retrievedScore;
                dataRow["Username"] = retrievedUsername;
                dataRow["Date"] = retrievedDate;
                dataTable.Rows.Add(dataRow);
            }
            reader.Close();
            connection.Close();
        }
    }
}
