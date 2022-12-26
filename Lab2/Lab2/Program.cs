using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task21
{
    public class Task21
    {
        public static void Main()
        {
            Console.WriteLine("x y");

            for (var x = -8; x <= 8; x++)
            {
                if (x <= -5)
                {
                    var y = -3;
                    Console.WriteLine($"{x} {y}");
                }
                if (x <= -3 & x >= -5)
                {
                    var y = 3 / 3 * (x + 3);
                    Console.WriteLine($"{x} {y}");
                }
                if (x >= -3 & x <= 0)
                {
                    var y = Math.Sqrt(9 - x * x);
                    Console.WriteLine($"{x} {y}");
                }
                if (x >= 0 & x <= 3)
                {
                    var y = Math.Sqrt(9 - x * x);
                    Console.WriteLine($"{x} {y}");
                }
                if (x >= 3 & x <= 8)
                {
                    var y = (3.0 / 5.0) * (x - 3.0);
                    Console.WriteLine($"{x} {y}");
                }
                if (x >= 8 & x <= 10)
                {
                    var y = 3;
                    Console.WriteLine($"{x} {y}");
                }
            }
            Console.ReadLine();
        }
    }
}