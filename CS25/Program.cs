//Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы, от меньшего до большего.
//Нельзя использовать Array.Sort. Можно найти подходящий алгоритм сортировки и использовать его для задачи
using System;

namespace CS25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -50, 6, 66, 7, 9, 10, 4, 3, 2, 1 };
            int value = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int t = 0; t < array.Length - 1 - i; t++)
                {
                    if (array[t] > array[t + 1])
                    {
                        value = array[t];
                        array[t] = array[t + 1];
                        array[t + 1] = value;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
