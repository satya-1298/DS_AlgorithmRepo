using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    public class BinarySearchWord
    {
        public void SearchWord(string path)
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            string read = File.ReadAllText(path);
            string[] word = read.Split(" ");
            foreach (string s in word)
            {
                Console.WriteLine(s);

            }
            foreach (string s in word)
            { 

                if (text == s)
                {
                    Console.WriteLine("Word found");
                }
                else { Console.WriteLine("Word not found"); }
            }

            
        }

    }
}
