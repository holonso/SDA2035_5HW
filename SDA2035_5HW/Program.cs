using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_5HW
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            float S = 0;
            Console.WriteLine("Введите {0} чисел:", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое = {0:f2}", S / n);
            Console.ReadKey();
        }
    }
}
