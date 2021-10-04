using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы(целое число):");
            int size = Convert.ToInt32(Console.ReadLine());

            double[,] array = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("array[" + i + "," + j + "]: ");
                    array[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                
                Console.WriteLine();
            }
            Console.WriteLine();

            double min;
            double max_min = array[0, 0];

            for (int j = 0; j < size; j++)
            {
                min = array[0, j];

                for (int i = 0; i < size; i++)
                {
                    if(array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }

                if (min > max_min)
                {
                    max_min = min;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine($"Максимум из всех минимальных элементов матрицы по столбцам {max_min}");

            Console.ReadLine();

        }
    }
}
