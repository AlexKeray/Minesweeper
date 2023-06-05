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

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            configure_scoreboard_settings();
            load_scoreboardTable();                   // This is the actual scoreboard
            configure_scoreboardTable_settings();
        }

        private void configure_scoreboard_settings()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            this.Size = new Size(724, 592);
        }

        private void load_scoreboardTable()
        {
            ScoreboardDataBaseManager.createDataTable();
            ScoreboardDataBaseManager.readScoreboardDB_and_populateDataTable();
            scoreboardTable.DataSource = ScoreboardDataBaseManager.dataTable;
        }
        private void configure_scoreboardTable_settings()
        {
            scoreboardTable.ColumnHeadersVisible = true;         
            scoreboardTable.RowHeadersVisible = false;            
            scoreboardTable.ReadOnly = true;                      
            scoreboardTable.ScrollBars = ScrollBars.None;         
            scoreboardTable.AllowUserToResizeRows = false;        
            scoreboardTable.AllowUserToResizeColumns = false;     
            scoreboardTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;   
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
        private void close_Scoreboard(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
