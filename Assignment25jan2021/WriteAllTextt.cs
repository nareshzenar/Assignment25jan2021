using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment25jan2021
{
    class WriteAllTextt
    {
        static void Main()
        {
            // string data = "We are understanding the static class file";
            Console.WriteLine("Enter the text:");
            string data = Console.ReadLine();
            File.WriteAllText("dynamic.txt", data);
            Console.WriteLine("Contents of the file : " + File.ReadAllText("dynamic.txt"));
           // File.AppendAllText("static.txt", "New content appened in static file");
        }
    }
}
