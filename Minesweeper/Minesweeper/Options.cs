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
        public Options()
        {
            InitializeComponent();
        }

        private void return_to_menu_from_options(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
