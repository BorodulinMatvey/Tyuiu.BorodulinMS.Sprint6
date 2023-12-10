using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           string path = @"C:\DataSprint6\InPutFileTask7V16.csv";
            char[] ar = path.ToCharArray();
            Console.WriteLine(ar);
            Console.ReadKey();
        }
    }
}
