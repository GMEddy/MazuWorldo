using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_Fight
{
    class Text_Labyrinth
    {
        static void Main(string[] args)
            {
                
                // Read the file as one string.
                string text = System.IO.File.ReadAllText(@"C:\Users\DCP\Documents\Labyrinth\laby_test.txt");

                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
                System.Console.ReadKey();
             // Example #2
             // Read each line of the file into a string array. Each element
             // of the array is one line of the file.
                 string[] lines = System.IO.File.ReadAllLines(@"C:\Users\DCP\Documents\Labyrinth\WriteLines2.txt");

                 // Display the file contents by using a foreach loop.
                 System.Console.WriteLine("Contents of WriteLines2.txt = ");
                 foreach (string line in lines)
                 {
                     // Use a tab to indent each line of the file.
                     Console.WriteLine("\t" + line);
                 }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
            }
        }
}
