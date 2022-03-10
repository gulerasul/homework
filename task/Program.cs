using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 13, 15, 26, 38, 49, 52 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("");

            Change(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void Change (int []numbers)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])   
                {
                    min =i;
                }
                if (max<numbers[i])
                {
                    max = i;
                }
            }
            numbers[max] = numbers[min] + numbers[max];
            numbers[min] = numbers[max] - numbers[min];
            numbers[max] = numbers[max] - numbers[min];

        }

    }
}
