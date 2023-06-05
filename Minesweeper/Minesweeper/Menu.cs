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

        private void load_menu(object sender, EventArgs e)
        {
            configure_menu_settings();
            set_initial_windows_position(); // All windows start where the Menu stars.
        }

        private void configure_menu_settings()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(724, 592);
        }

        private void set_initial_windows_position()
        {
            initialPosition = this.Location;
        }

        private void change_initial_windows_position(object sender, EventArgs e) // When the Menu position is changed, the others windows start at
        {                                                                        // the new location
            initialPosition = ((Form)sender).Location;
        }

        private void swap_windows(Form pFormInstance)
        {
            pFormInstance.StartPosition = FormStartPosition.Manual;
            pFormInstance.Location = initialPosition;
            this.Hide();
            pFormInstance.ShowDialog();
            this.Show();
        }

        private void go_to_GameScreen(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            swap_windows(gameScreen);
        }

        private void go_to_Options(object sender, EventArgs e)
        {
            Options options = new Options();
            swap_windows(options);

        }

        private void go_to_Scoreboard(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            swap_windows(scoreboard);
        }

        private void go_to_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
