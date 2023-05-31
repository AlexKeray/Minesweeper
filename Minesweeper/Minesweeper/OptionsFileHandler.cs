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
        public static string difficulty;
        public static string username;
        
        public static void ReadTextFile(string filePath)
        {
            string[] options = File.ReadAllLines(filePath);
            difficulty = options[0].ToString();
            username = options[1].ToString();
        }

        public static void WriteTextFile(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);

            StreamWriter writer = new StreamWriter(filePath);

            writer.WriteLine(difficulty.ToString());
            writer.WriteLine(username.ToString());

            writer.Close();

        }
    }

}
