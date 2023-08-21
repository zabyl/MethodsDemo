using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int average = Average(9, 36, 18);
            
            Methods print = new Methods();
            print.PrintToConsole(Convert.ToString(average));

            Console.ReadLine();
            
        }

        static int Average(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) / 3;
        }

    }

    class Methods
    {
        public void PrintToConsole(string data)
        {
            Console.WriteLine(data);
        }
    }
}
