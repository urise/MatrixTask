using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace MatrixTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter number: ");
                var input = Console.ReadLine();
                try
                {
                    long n = long.Parse(input, NumberStyles.Integer);
                    Console.WriteLine($"Result: {Garmonic.Search(n, 100000)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
