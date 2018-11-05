using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithArrays();
            return;
        }

        static void WorkWithArrays()
        {
            try
            {
                Console.Write("Введите количество строк массива X:");
                int lengthX = int.Parse(Console.ReadLine());

                Console.Write("Введите количество столбцов массива Y:");
                int lengthY = int.Parse(Console.ReadLine());

                Console.WriteLine("Ввод первого массива:");
                int[,] arr1 = InputArray(lengthX, lengthY);

                Console.WriteLine("Первый массив");
                PrintArray(arr1);

                Console.WriteLine("Ввод второго массива:");
                int[,] arr2 = InputArray(lengthX, lengthY);

                Console.WriteLine("Второй массив");
                PrintArray(arr2);

                int[,] summArr = CalculateSummArrays(arr1, arr2);

                Console.WriteLine("Вывод результата:");
                PrintArray(summArr);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: {0}", ex.Message);
                Console.ReadKey();
            }
        }

        static int[,] InputArray(int lengthX, int lengthY)
        {
            int[,] arr = new int[lengthX, lengthY];

            for (int i = 0; i < lengthX; i++)
            {
                for (int j = 0; j < lengthY; j++)
                {
                    Console.Write("Введите значение массива ({0},{1}):", i.ToString(), j.ToString());
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return arr;
        }

        static int[,] CalculateSummArrays(int[,] arr1, int[,] arr2)
        {
            int[,] arr = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return arr;
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
    }

