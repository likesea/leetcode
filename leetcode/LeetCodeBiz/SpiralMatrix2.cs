using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class SpiralMatrix2
    {
        public int[,] GenerateMatrix(int n)
        {
            int[] loopNum = new int[(int) Math.Sqrt(n)];
            for (int i = 0; i < (int)Math.Sqrt(n); i++)
            {
                loopNum[i] = 2*n + 2*(n - 2);
                n -= 2;
            }
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var minInt = Math.Min(i, j);
                    for (int k = 1; k < minInt; k++)
                    {
                        matrix[i, j] = loopNum[k - 1];
                    }
                    matrix[i,j]+
                }
            }
        }
    }
}
