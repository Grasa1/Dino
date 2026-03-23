using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino
{
    internal class FileManager
    {
        public static List<Dino> ReadFile(string fileName)
        {
            List<Dino> dinok = new List<Dino>();
            try
            {
                foreach (string item in File.ReadAllLines(fileName, Encoding.UTF8))
                    dinok.Add(new Dino(item.Split(';')));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
            return dinok;
        }
    }
}
