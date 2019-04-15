using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 7, 12, 5, 9, 15, 3 };
            int profit = GetMaxProfit(array);
            Console.WriteLine(profit); //prints 10

            int[] array2 = { 9, 7, 2, 12, 5, 79, 9, 15, 3 };
            profit = GetMaxProfit(array2);
            Console.WriteLine(profit); //prints 77

            Console.ReadLine();
        }

        private static int GetMaxProfit(int[] array)
        {
            int max_profit = 0;
            int local_min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                int profit = array[i] - local_min;

                if (profit > max_profit)
                {
                    max_profit = profit;
                }

                if (array[i] < local_min)
                {
                    local_min = array[i];
                }
            }

            return max_profit;
        }
    }
}
