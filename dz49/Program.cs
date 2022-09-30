using System;

namespace Project
{
    class Project
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; int i = 0, result = 0; string a = "561";

            Print(array, i);
            Sum(array, i, result);
            SumOfNumbers(a, i, result);
        }

        static void Print(int[] array, int i)
        {
            if(i >= array.Length)
                return;

            Console.Write(array[i] + " ");
            i++;
            Print(array, i);
        }

        static void Sum(int[] array, int i, int result)
        {
            if (i >= array.Length)
            {
                Console.WriteLine("\nSum = " + result);
                return;
            }

            result += array[i];
            i++;
            Sum(array, i, result);
        }

        static void SumOfNumbers(string a, int i, int result)
        {
            if (i >= a.Length)
            {
                Console.WriteLine("SumOfNumbers = " + result);
                return;
            }

            result += a[i] - '0';
            i++;
            SumOfNumbers(a, i, result);
        }
    }
}