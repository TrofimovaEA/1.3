using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, a = 0, b = 0, s = 1, c = 1;
            Console.WriteLine("Введите количество элементов массива:");
            n = int.Parse(Console.ReadLine());
            double[] Matrix = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Элемент [" + (i + 1) + "]: ");
                Matrix[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
                Console.Write(Matrix[i] + " ");
            Console.Write(" ");
            double min = Matrix[0];
            k = n;
            double[] Matrix_1 = new double[k];
            for (int j = 0; j < k; j++)
            {
                min = Matrix[0];
                a = 0;
                for (int i = 0; i < n; i++)
                    if (Matrix[i] < min)
                    {
                        min = Matrix[i];
                        a = i;
                    }
                for (int i = a; i < n - 1; i++)
                    Matrix[i] = Matrix[i + 1];
                n--;
                if (s % 2 != 0)
                {
                    Matrix_1[0 + b] = min;
                    b++;
                }
                else
                {
                    Matrix_1[k - c] = min;
                    c++;
                }
                s++;
            }
            Console.WriteLine("\nОтсортированный массив:\n");
            for (int i = 0; i < k; i++)
                Console.Write(Matrix_1[i] + " ");
            Console.ReadKey();

        }
    }
}

