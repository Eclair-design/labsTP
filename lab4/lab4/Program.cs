using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task4
{
    public class Task4
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (int i in list)
                Console.Write(i + " ");
            list.Add(6);

            Console.WriteLine();

            foreach (int i in list)
                Console.Write(i + " ");

            Console.WriteLine();

            List<int> list2 = new List<int>() { 1, 2, 3 };
            foreach (int i in list2) //i - число 1,2,3
                Console.Write(i + " ");

            Console.WriteLine();

            list.InsertRange(2, list2);
            foreach (int i in list)
                Console.Write(i + " ");

            Console.WriteLine();

            Console.WriteLine($"Количество элементов: {list.Count}");

            Console.WriteLine($"Максимум: {list.Max()}");
            Console.WriteLine($"Минимум: {list.Min()}");

            int[] array = list2.ToArray();
            foreach (int i in array)
                Console.Write(i + " ");

            Console.WriteLine();

            list2.RemoveAt(1);
            foreach (int i in list2) //i - число 1,2,3
                Console.Write(i + " ");
        }
    }
}