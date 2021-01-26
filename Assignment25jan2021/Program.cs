using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment25jan2021
{
    class Program                              //C# BinaryWriter class is used to write binary information into stream. It is found in System.IO namespace. 
    {                                           //It also supports writing string in specific encoding.
        static void Main(string[] args)
        {
            string fileName = "H:\\binaryfile.dat";
            using (BinaryWriter bw = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                bw.Write(2.5);
                bw.Write("this is string data");
                bw.Write(true);
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
