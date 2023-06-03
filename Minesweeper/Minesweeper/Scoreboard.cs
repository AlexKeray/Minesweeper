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

        private void scoreboardToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            ScoreboardDataManager.createDataTable();
            ScoreboardDataManager.readRecords();
            scoreboardTable.DataSource = ScoreboardDataManager.dataTable;

        }
    }
}
