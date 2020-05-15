using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> wordLibrary = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };




            var queryWordsByLetterCombination = wordLibrary.Where(w => w.Contains("th")).ToList();
            foreach (var word in queryWordsByLetterCombination)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }
            




        }
    }
}
