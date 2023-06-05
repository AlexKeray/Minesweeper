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
    public partial class Options : Form
    {
        public static string difficulty; // Very important global variable, that is used in the GameScreen
        public static string username;   // This variable is used in the Scoreboard
        public Options()
        {
            InitializeComponent();
        }

        private void load_options(object sender, EventArgs e)
        {
            configure_Options_settings(); // Sets the settings from the last launch of the application

            OptionsFileHandler.read_OptionsFile_and_initialise_difficulty_and_username(@"OptionsFile.txt");

            usernameTextbox.Text = username;
            configure_difficulty_radiobuttons();
        }

        private void configure_Options_settings()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#d9d9d9");
            this.Size = new Size(724, 592);
        }

        private void configure_difficulty_radiobuttons() // Sets which button to appear selected
        {
            if (difficulty == "easy")
            {
                difficultyEasyRadioButton.Checked = true;
                difficultyMediumRadioButton.Checked = false;
                difficultyHardRadioButton.Checked = false;

            }
            else if (difficulty == "medium")
            {
                difficultyEasyRadioButton.Checked = false;
                difficultyMediumRadioButton.Checked = true;
                difficultyHardRadioButton.Checked = false;

            }
            else if (difficulty == "hard")
            {
                difficultyEasyRadioButton.Checked = false;
                difficultyMediumRadioButton.Checked = false;
                difficultyHardRadioButton.Checked = true;

            }
        }

        private void click_difficultyEasyRadioButton(object sender, EventArgs e) // Allows only 1 button th be selected at a time.
        {
            difficultyEasyRadioButton.Checked = true;
            difficultyMediumRadioButton.Checked = false;
            difficultyHardRadioButton.Checked = false;
        }

        private void click_difficultyMediumRadioButton(object sender, EventArgs e) // Allows only 1 button th be selected at a time.
        {
            difficultyEasyRadioButton.Checked = false;
            difficultyMediumRadioButton.Checked = true;
            difficultyHardRadioButton.Checked = false;
        }

        private void click_difficultyHardRadioButton(object sender, EventArgs e) // Allows only 1 button th be selected at a time.
        {
            difficultyEasyRadioButton.Checked = false;
            difficultyMediumRadioButton.Checked = false;
            difficultyHardRadioButton.Checked = true;
        }

        private void set_difficulty()
        {
            if (difficultyEasyRadioButton.Checked)
            {
                difficulty = "easy";
            }
            else if (difficultyMediumRadioButton.Checked)
            {
                difficulty = "medium";
            }
            else if (difficultyHardRadioButton.Checked)
            {
                difficulty = "hard";
            }
        }

        private void close_Options(object sender, EventArgs e)
        {
            set_difficulty();
            username = usernameTextbox.Text;
            OptionsFileHandler.write_OptionsFile(@"OptionsFile.txt");
            this.Close();
        }
    }
}
