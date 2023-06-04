using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void return_to_menu_from_scoreboard(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.CenterScreen;
            ScoreboardDataManager.createDataTables();
            ScoreboardDataManager.readRecords();
            scoreboardTable.DataSource = ScoreboardDataManager.dataTable;
            scoreboardFormat();
            chooseScoreboardSize();
        }

        private void chooseScoreboardSize()
        {
            this.Size = new Size(724, 592);
        }
        private void scoreboardFormat()
        {
            scoreboardTable.ColumnHeadersVisible = true;         //removing the extra stuff
            scoreboardTable.RowHeadersVisible = false;            //removing the extra stuff
            scoreboardTable.ReadOnly = true;                      //blocking unwanted midification from the user
            scoreboardTable.ScrollBars = ScrollBars.None;         //blocking unwanted midification from the user
            scoreboardTable.AllowUserToResizeRows = false;        //blocking unwanted midification from the user
            scoreboardTable.AllowUserToResizeColumns = false;     //blocking unwanted midification from the user
            scoreboardTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;   //centering content of the squares
            scoreboardTable.Enabled = true;
            scoreboardTable.AllowUserToAddRows = false;
        }
    }
}
