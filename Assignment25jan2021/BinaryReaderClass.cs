using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * C# BinaryReader class is used to read binary information from stream. 
 * It is found in System.IO namespace. 
 * It also supports reading string in specific encoding.
 */


namespace Assignment25jan2021
{
    class BinaryReaderClass
    {
        static void WriteBinaryFile()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("H:\\binaryfile2.dat", FileMode.Create)))
            {

                bw.Write(12.5);
                bw.Write("this is string data");
                bw.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("H:\\binaryfile2.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }

            static void Main()
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();

        }
    }
}
