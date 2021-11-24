using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите значение N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] x = new int[N, N];
            x[0, 0] = 1;                                        //можно указать и 0 как стартовое значение массива
            Console.Write("{0,2} ", x[0, 0]);
            for (int j = 1; j < N; j++)                         //создание референсной строки (1 0 1 0 1..)
            {
                if (x[0, j - 1] == 1)
                {
                    x[0, j] = 0;
                    Console.Write("{0,2} ", x[0, j]);
                }
                else
                {
                    x[0, j] = 1;
                    Console.Write("{0,2} ", x[0, j]);
                }
            }
            Console.WriteLine();
            for (int i = 1; i < N; i++)                         //остальные строки танцуют уже от предыдущей
            {
                for (int j = 0; j < N; j++)
                {
                    if (x[i - 1, j] == 1)
                    {
                        x[i, j] = 0;
                    }
                    else
                    {
                        x[i, j] = 1;
                    }
                    Console.Write("{0,2} ", x[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
