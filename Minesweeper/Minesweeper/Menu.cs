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
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void start_game(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            this.Hide();
            gameScreen.ShowDialog();
            this.Show();
        }

        private void go_to_options(object sender, EventArgs e)
        {
            Options options = new Options();
            this.Hide();
            options.ShowDialog();
            this.Show();
        }
    }
}
