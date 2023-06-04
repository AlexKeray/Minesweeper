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
    public partial class Menu : Form
    {
        public Point initialPosition;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            this.StartPosition = FormStartPosition.CenterScreen;
            initialPosition = this.Location;
            chooseMenuSize();
        }

        private void chooseMenuSize()
        {
            this.Size = new Size(724, 592);
        }

        private void start_game(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = initialPosition;
            this.Hide();
            gameScreen.ShowDialog();
            this.Show();
        }

        private void go_to_options(object sender, EventArgs e)
        {
            OptionsMenu options = new OptionsMenu();
            options.StartPosition = FormStartPosition.Manual;
            options.Location = initialPosition;
            this.Hide();
            options.ShowDialog();
            this.Show();
        }

        private void exitApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void go_to_scoreboard(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.StartPosition = FormStartPosition.Manual;
            scoreboard.Location = initialPosition;
            this.Hide();
            scoreboard.ShowDialog();
            this.Show();
        }

        private void Menu_LocationChanged(object sender, EventArgs e)
        {
            initialPosition = ((Form)sender).Location;
        }
    }
}
