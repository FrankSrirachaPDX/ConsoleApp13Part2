using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Class holder = new Class();
            int x;
            int y;
            string temp;

            Console.WriteLine("Enter the first number!");
            temp = Console.ReadLine();
            x = Convert.ToInt32(temp);

            Console.WriteLine("Enter the second number!");
            temp = Console.ReadLine();
            y = Convert.ToInt32(temp);


            Class.Math(x, y);

            Class.Math();

            Console.ReadLine();
        }
    }
}
