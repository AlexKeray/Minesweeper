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
    public partial class OptionsMenu : Form
    {
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void return_to_menu_from_options(object sender, EventArgs e)
        {
            configure_options();
            OptionsFileHandler.WriteTextFile(@"OptionsFile.txt");
            this.Close();

        }

        private void configure_options()
        {
            if(difficultyEasy.Checked)
            {
                OptionsFileHandler.difficulty = "easy";
            }
            else if(difficultyMedium.Checked)
            {
                OptionsFileHandler.difficulty = "medium";
            }
            else if(difficultyMedium.Checked)
            {
                OptionsFileHandler.difficulty = "hard";
            }
            OptionsFileHandler.username = usernameTextbox.Text;
        }

        private void difficultyEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (!difficultyEasy.Checked)
            {
                difficultyEasy.Checked = true;
                difficultyMedium.Checked = false;
                difficultyHard.Checked = false;
                configure_options();
            }
        }

        private void difficultyMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (!difficultyMedium.Checked)
            {
                difficultyEasy.Checked = false;
                difficultyMedium.Checked = true;
                difficultyHard.Checked = false;
                configure_options();

            }
        }

        private void difficultyHard_CheckedChanged(object sender, EventArgs e)
        {
            if (!difficultyHard.Checked)
            {
                difficultyEasy.Checked = false;
                difficultyMedium.Checked = false;
                difficultyHard.Checked = true;
                configure_options();

            }
        }

        private void change_username(object sender, EventArgs e)
        {
            OptionsFileHandler.username = usernameTextbox.Text;
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {
            usernameTextbox.Text = OptionsFileHandler.username;

            if (OptionsFileHandler.difficulty == "easy")
            {
                difficultyEasy.Checked = true;
                difficultyMedium.Checked = false;
                difficultyHard.Checked = false;
                configure_options();

            }
            else if(OptionsFileHandler.difficulty == "medium")
            {
                difficultyEasy.Checked = false;
                difficultyMedium.Checked = true;
                difficultyHard.Checked = false;
                configure_options();

            }
            else if(OptionsFileHandler.difficulty == "medium")
            {
                difficultyEasy.Checked = false;
                difficultyMedium.Checked = false;
                difficultyHard.Checked = true;
                configure_options();

            }
        }
    }
}
