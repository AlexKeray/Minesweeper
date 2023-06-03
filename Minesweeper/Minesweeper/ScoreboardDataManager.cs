using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Minesweeper
{
    internal class ScoreboardDataManager
    {

        //private static string connectionString = "Data Source=ScoreboardSQLite.db;";
        private static string connectionString = "Data Source=ScoreboardDB.db;";

        public static DataTable dataTable;

        public static void createDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Place", typeof(int));
            dataTable.Columns.Add("Score", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));
        }
        public static void readRecords()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            string selectQuery = "SELECT * FROM ScoreboardTable";
            SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();     
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int retrievedScore = reader.GetInt32(1);
                string retrievedUsername = reader.GetString(2);
                string retrievedDate = reader.GetString(3);

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

        public static void writeRecord(int score, string date)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            string insertQuery = "INSERT INTO ScoreboardTable (Score, Username, Date) VALUES (@Score, @Username, @Date)";
            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Score", score);
            command.Parameters.AddWithValue("@Username", OptionsFileHandler.username);
            command.Parameters.AddWithValue("@Date", date);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
