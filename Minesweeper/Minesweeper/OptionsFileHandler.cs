using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Minesweeper
{
    internal class OptionsFileHandler
    {
        public static void read_OptionsFile_and_initialise_difficulty_and_username(string filePath)
        {
            string[] options = File.ReadAllLines(filePath);
            Options.difficulty = options[0].ToString();
            Options.username = options[1].ToString();
        }

        public static void write_OptionsFile(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);

            StreamWriter writer = new StreamWriter(filePath);

            writer.WriteLine(Options.difficulty.ToString());
            writer.WriteLine(Options.username.ToString());

            writer.Close();

        }
    }

}
