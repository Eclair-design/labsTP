using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task31
{
    public class Task31
    {
        public static void Main()
        {
            int[] array = new int[] { -4, 4, 2, -2};

            float maxPValue = 0;
            float asum = 0;
            float sum = 0;
            float r;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                r = Math.Abs(array[i]);
                if (maxPValue < r)
                {
                    maxPValue = r;
                    Console.WriteLine($"max = {maxPValue}; r = {r}");
                }
            }
            asum = sum / array.Length;
            Console.WriteLine($"Максимальное по модулю число в массиве: {maxPValue}");
            Console.WriteLine($"Среднее арифметическое число массива: {asum}");
        }
    }
}