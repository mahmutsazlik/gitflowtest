using System;

namespace ProfitMaximizer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stations = { 3, -5, 2, 11, -8, 9, -5 };
            int value = findMostProfitable(stations);
            Console.WriteLine(value);
            Console.ReadKey();
        }

        private static int findMostProfitable(int[] stations)
        {
            int most = int.MinValue;
            int sum = 0;
            for (int i = 0; i < stations.Length - 1; i++)
            {
                sum = stations[i];
                for (int j = i + 1; j < stations.Length; j++)
                {
                    sum += stations[j];
                    if (sum > most)
                    {
                        most = sum;
                    }
                }
            }
            return most;
        }
    }
}
