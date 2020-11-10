using System;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] a = new long[n + 2];
            for (int i = 0; i < n; i++)
            {
                a[i] = 0;
            }
            for (int j = 0; j < queries.Length; j++)
            {
                int lowIndex = queries[j][0];
                int highIndex = queries[j][1];
                int k = queries[j][2];
                a[lowIndex] = a[lowIndex] + k;
                a[highIndex + 1] = a[highIndex + 1] - k;

            }
            long max = int.MinValue;
            long sum = 0;
            for (int k = 0; k < a.Length; k++)
            {
                sum += a[k];
                max = Math.Max(sum, max);
            }
            return max;

        }
    }
}
