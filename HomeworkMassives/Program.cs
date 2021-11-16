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
                int[] arr = new int[ReadSize()]; // добавить проверку нулевого и отрицательного ввода
                Console.WriteLine("DIBAG " + arr.Length);
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ReadNumber();
                }

                Console.Write("DIBAG ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("finally, " + FindAnswer(arr));
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
            if (secondHighestValue == highestValue)
                Console.Write("Все числа в массиве - это " + highestValue);
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
                    //Console.WriteLine("Введите натуральное число");
                    //ReadSize();
                    int.Parse("k");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Введите натуральное число");
                size = ReadSize();
            }
            return size;
        }
    }
}