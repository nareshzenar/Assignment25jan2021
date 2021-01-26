using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

/*
 *BufferedStream. With a buffer, we avoid executing writes and reads until a certain number of operations has been requested. 
 *Then we execute them all at once. 
 *By using BufferedStream, we achieved a performance boost. 
 *This would not be helpful on small streams or fewer writes.
 */

namespace Assignment25jan2021
{
    class BufferedStreamClass
    {
        static void Main()
        {
            var t1 = Stopwatch.StartNew();
            // Use BufferedStream to buffer writes to a MemoryStream.
            using (MemoryStream m = new MemoryStream())
            using (BufferedStream bs = new BufferedStream(m))
            {
                // Write a byte 5 million times.
                for (int i = 0; i < 5000000; i++)
                {
                    bs.WriteByte(5);
                }
            }
            t1.Stop();
            Console.WriteLine("BUFFEREDSTREAM TIME: " + t1.Elapsed.TotalMilliseconds);
        }
    }
}

