using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите количество чисел в массиве");
                int[] arr = new int[ReadSize()];
                Console.WriteLine("Поочерёдно введите элементы массива");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ReadNumber();
                }

                Console.Write("Введёный массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Ответ: " + FindAnswer(arr));
                Console.WriteLine();
            }
        }

        static int ReadNumber()
        {
            int number = 0;
            string s = Console.ReadLine();
            try
            {
                number = int.Parse(s);
                
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Элемент массива должен быть целым числом");
                Console.WriteLine(ex.Message);
                number = ReadNumber();
            }
            return number;
        }

        static int FindAnswer(int[] arr)
        {
            int secondHighestValue = int.MinValue;
            int highestValue = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] > highestValue))
                {
                    secondHighestValue = highestValue;
                    highestValue = arr[i];
                    continue;
                }
                if (arr[i] > secondHighestValue)
                {
                    secondHighestValue = arr[i];
                }
            }
            if ((secondHighestValue == highestValue) | (arr.Length == 1))
                Console.WriteLine("Все числа в массиве - это " + highestValue);
            if (secondHighestValue == int.MinValue)
            {
                return highestValue;
            }
            return secondHighestValue;
        }
        static int ReadSize()
        {
            int size = 0;
            string s = Console.ReadLine();
            try
            {
                size = int.Parse(s);
                if (size <= 0)
                {
                    Console.WriteLine("Введите натуральное число");
                    size = ReadSize();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Введите натуральное число");
                Console.WriteLine(ex.Message);
                size = ReadSize();
            }
            return size;
        }
    }
}