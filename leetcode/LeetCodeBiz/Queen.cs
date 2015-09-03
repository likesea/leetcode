using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class Queen
    {
        private int count = 0;


        public void SolveQueens(int n)
        {
            int [] queInts = new int[n];
            Solve(0,queInts);
            Console.WriteLine(count);
        }
        private void Solve(int current, int[] queens)
        {
            if (current == queens.Length)
            {
                count++;
                CW(queens);
                return;
            }
            for (int i = 0; i < queens.Length; i++)
            {
                queens[current] = i;
                if (CanPut(current, queens))
                {
                    Solve(current+1, queens);//递归时，current值会随着递归深度变化，不能写成单独语句current++; 这样
                }
            }
        }

        private void CW(int[] queInts)
        {
            for (int i = 0; i < queInts.Length; i++)
            {
                for (int j = 0; j < queInts.Length; j++)
                {
                    Console.Write(j == queInts[i] ? "*" : "-");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }
        private bool CanPut(int current, int[] queens)
        {
            for (int i = 0; i < current; i++)
            {
                if (queens[i] != queens[current] && Math.Abs(i - current) != Math.Abs(queens[current] - queens[i]))
                {
                    continue;
                }
                 return false;
            }
            return true;
        }
    }
}
