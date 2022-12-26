using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task12
{
    public class Task12
    {
        public static void Main()
        {
            Console.WriteLine("Запишите значения через Enter a,b,x:");
            var a = Int32.Parse(Console.ReadLine());
            var b = Int32.Parse(Console.ReadLine());
            var x = Int32.Parse(Console.ReadLine());
            var y = 0.0;
            if (Math.Sqrt(a + b) < x)
            {
                y = a * Math.Pow(x, 2) + b * Math.Log10(Math.Abs(2 * x));
            }
            if (Math.Sqrt(a + b) >= x)
            {
                y = Math.Sqrt(a + Math.Sin(2 * x));
            }
            Console.WriteLine(y);
        }
    }
}