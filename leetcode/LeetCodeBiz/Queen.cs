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
            for (int i = 0; i < n; i++)
            {
                queInts[i] = -1;
            }
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
            
            for (int i = queens[current]+1; i < queens.Length; i++)
            {
                if (CanPut(current, queens, i))
                {
                    queens[current] = i;
                    Solve(current+1, queens);
                    queens[current] = -1;//能够运行该语句，说明需要回溯，把以前记录清除
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
        private bool CanPut(int current, int[] queens, int position)
        {
            for (int i = 0; i < current; i++)
            {
                if (queens[i] != position && Math.Abs(i - current) != Math.Abs(position - queens[i]))
                {
                    continue;
                }
                 return false;
            }
            return true;
        }
    }
}
