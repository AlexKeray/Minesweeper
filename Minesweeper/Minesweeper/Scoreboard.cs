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
            this.MaximizeBox = false;
            this.BackColor = ColorTranslator.FromHtml("#d9d9d9");
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
            scoreboardTable.DefaultCellStyle.Font = new Font("Microsoft Serif", 12, FontStyle.Regular);
            scoreboardTable.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Serif", 12, FontStyle.Regular);
            scoreboardTable.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            scoreboardTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            scoreboardTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            scoreboardTable.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            scoreboardTable.Columns[0].Width = 100;
            scoreboardTable.Columns[1].Width = 200;
            scoreboardTable.Columns[2].Width = 235;
            scoreboardTable.Columns[3].Width = 150;
            for(int i=0; i<10; i++)
            {
                scoreboardTable.Rows[i].Height = 42;
            }
            
        }
    }
}
