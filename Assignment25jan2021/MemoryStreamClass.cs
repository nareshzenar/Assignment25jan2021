using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
* The MemoryStream class creates streams that have memory as a backing store instead of a disk or a network connection. 
* MemoryStream encapsulates data stored as an unsigned byte array. 
* The encapsulated data is directly accessible in memory.
 */

namespace Assignment25jan2021
{
    class MemoryStreamClass
    {
		public static void UseMemoryStream()
		{
			byte[] fileContents = File.ReadAllBytes("test.txt");
			using (MemoryStream ms = new MemoryStream(fileContents))
			{
				using (TextReader tr = new StreamReader(ms))
				{
					string line;
					while ((line = tr.ReadLine()) != null)
						Console.WriteLine(line);
				}
			}
		}
		static void Main()
        {
			UseMemoryStream();
        }
    }
}
