using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task11
{
    public class Task11
    {
        public static void Main()
        {
            Console.WriteLine("Напишите значение а");
            var a = Int32.Parse(Console.ReadLine());
            var z1 = Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
            var z2 = (double)1 / 4 - (double)1 / 4 * Math.Sin(Math.PI / 4 + 2 * a);
            Console.WriteLine($"{z1} {z2}");
            Console.ReadLine();
        }
    }
}
