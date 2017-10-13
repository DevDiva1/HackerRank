using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    class TileStacking
    {
        static int TileStackingProblem(int n, int m, int k)
        {
            // Complete this function
            if (n == 0)
            {
                return 1;
            }
            if (m == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i <= k; i++)
            {
                int subSum = TileStackingProblem(n - i, m - 1, Math.Min(k, n - i));
                sum += subSum;
                sum = sum % 1000000007;
            }
            return sum;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            int k = Convert.ToInt32(tokens_n[2]);
            int result = TileStackingProblem(n, m, k);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
