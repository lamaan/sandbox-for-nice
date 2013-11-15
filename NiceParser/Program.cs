using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("please pass in the expression as the first commannd line argument");
            }
            else
            {
                try
                {
                    Console.Write(NiceCalculator.Evaluate(args[0]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
