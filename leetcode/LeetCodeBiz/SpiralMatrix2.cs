using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class SpiralMatrix2
    {
        private static int flag = 0;
        public int[,] GenerateMatrix(int n)
        {
            int [,]result = new int[n,n];
            int[,] move = new int[,]{{0,1},{1,0},{0,-1},{-1,0}};
            int totalNum = n*n;
            int m = n;
            int [] pos = new int[2]{0,-1};
            int dir = 0;
            int i = 0;
            while (i<totalNum)
            {
                for (int j = 0; j < m; j++)
                {
                    pos[0] += move[dir, 0];
                    pos[1] += move[dir, 1];
                    result[pos[0], pos[1]] = ++i;
                }
                m = GetFlag(m);
                dir = (dir + 1)%4;
            }
            return result;
        }

        private int GetFlag(int m)
        {

            switch (flag)
            {
                case 0:
                    flag = 1;
                    m--;
                    break;
                case 1:
                    flag = 0;
                    break;
            }
            
            return m;
        }
    }
}
