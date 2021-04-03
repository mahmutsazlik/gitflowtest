using System;

namespace ProfitMaximizer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stations = { 3, -5, 2, 11, -8, 9, -5 };
            printArray(stations);
            int value = findMostProfitable(stations);
            Console.WriteLine("Max Profit : " + value);
            int max = findMaxRecursive(stations, stations.Length);
            Console.WriteLine("Max Value : " + max);
            int min = findMinRecursive(stations, stations.Length);
            Console.WriteLine("Min Value : " + min);
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
        private static int findMaxRecursive(int[] stations, int size)
        {
            if (size == 0)
            {
                return int.MinValue;
            }
            else if (size == 1)
            {
                return stations[0];
            }
            else
            {
                return Math.Max(stations[size - 1], findMaxRecursive(stations, size - 1));
            }
        }
        private static int findMinRecursive(int[] stations, int size)
        {
            if (size == 0)
            {
                return int.MinValue;
            }
            else if (size == 1)
            {
                return stations[0];
            }
            else
            {
                return Math.Min(stations[size - 1], findMinRecursive(stations, size - 1));
            }
        }
        public static void printArray(int[] arr)
        {
            Console.Write("Arr: [");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Length - 1) Console.Write(",");
            }
            Console.WriteLine("]");

        }

    }
}
