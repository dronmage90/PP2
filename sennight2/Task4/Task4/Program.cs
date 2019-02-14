using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFile = File.Create(@"C:\Users\Андрей\Desktop\PP2\sennight2\Folder\Ex.txt");
            myFile.Close();
            //System.IO.File.Create(@"C:\Users\Андрей\Desktop\PP2\sennight2\Folder\Ex.txt");
            System.IO.File.WriteAllText(@"C:\Users\Андрей\Desktop\PP2\sennight2\Folder\Ex.txt", "Hello!");
            File.Copy(@"C:\Users\Андрей\Desktop\PP2\sennight2\Folder\Ex.txt", @"C:\Users\Андрей\Desktop\PP2\sennight2\Folder1\Ex.txt", true);
            System.IO.File.Delete(@"C:\Users\Андрей\Desktop\PP2\sennight2\Folder\Ex.txt");
            //myFile.Close();

        }
    }
}
