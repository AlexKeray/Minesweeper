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

        private void OptionsMenu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            OptionsFileHandler.ReadTextFile(@"OptionsFile.txt");

            usernameTextbox.Text = OptionsFileHandler.username;

            load_difficulty_radiobuttons();
            chooseOptionsMenuSize();
        }

        private void chooseOptionsMenuSize()
        {
            this.Size = new Size(724, 592);
        }

        private void return_to_menu_from_options(object sender, EventArgs e)
        {
            save_difficulty_options();
            OptionsFileHandler.WriteTextFile(@"OptionsFile.txt");
            this.Close();

        }

        private void save_difficulty_options()
        {
            if(difficultyEasy.Checked)
            {
                OptionsFileHandler.difficulty = "easy";
            }
            else if(difficultyMedium.Checked)
            {
                OptionsFileHandler.difficulty = "medium";
            }
            else if(difficultyHard.Checked)
            {
                OptionsFileHandler.difficulty = "hard";
            }
        }


        private void change_username(object sender, EventArgs e)
        {
            OptionsFileHandler.username = usernameTextbox.Text;
        }

        

        private void load_difficulty_radiobuttons()
        {
            if (OptionsFileHandler.difficulty == "easy")
            {
                difficultyEasy.Checked = true;
                difficultyMedium.Checked = false;
                difficultyHard.Checked = false;

            }
            else if (OptionsFileHandler.difficulty == "medium")
            {
                difficultyEasy.Checked = false;
                difficultyMedium.Checked = true;
                difficultyHard.Checked = false;

            }
            else if (OptionsFileHandler.difficulty == "hard")
            {
                difficultyEasy.Checked = false;
                difficultyMedium.Checked = false;
                difficultyHard.Checked = true;

            }
        }

        private void click_difficultyEasy_radioBtn(object sender, EventArgs e)
        {
            difficultyEasy.Checked = true;
            difficultyMedium.Checked = false;
            difficultyHard.Checked = false;
        }

        private void click_difficultyMedium_radioBtn(object sender, EventArgs e)
        {
            difficultyEasy.Checked = false;
            difficultyMedium.Checked = true;
            difficultyHard.Checked = false;
        }

        private void click_difficultyHard_radioBtn(object sender, EventArgs e)
        {
            difficultyEasy.Checked = false;
            difficultyMedium.Checked = false;
            difficultyHard.Checked = true;
        }
    }
}
