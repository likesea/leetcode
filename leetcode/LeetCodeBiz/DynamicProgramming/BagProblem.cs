using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz.DynamicProgramming
{
    public class BagProblem
    {
        private int[] weights;
        private int[] values;
        private int n;//总背包数
        private int maxWeight;
        private int[,] temp;
        /// <summary>
        /// 每个背包重量和价值，以及允许的最大重量
        /// </summary>
        /// <param name="w"></param>
        /// <param name="v"></param>
        /// <param name="allW"></param>
        public BagProblem(int[] w, int [] v,int allW)
        {
            this.weights = w;
            this.values = v;
            this.n = weights.Length;
            this.maxWeight = allW;
            this.temp = new int[weights.Length+1,weights.Length+1];
            for (int i = 0; i < weights.Length; i++)
            {
                for (int j = 0; j < weights.Length; j++)
                {
                    temp[i, j] = -1;
                }
            }
            
        }
        public int Solve()
        {
            return rec(0, maxWeight);
        }
        /// <summary>
        /// 从第i个背包开始，选择重量小于j的背包
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private int rec(int i, int j)
        {
            if (temp[i,j] >= 0)
            {
                return temp[i, j];
            }
            int res = 0;
            if (i == n)
            {
                return res;
            }
            else if (weights[i] > j) //如果i的重量大于剩余的重量数，则跳过该背包
            {
                res = rec(i + 1, j);
            }
            else
            {
                res = Math.Max(rec(i + 1, j), rec(i + 1, j - weights[i]) + values[i]);
            }
            return temp[i,j]=res;
        }

        public int SolveCompleteBagProblem()
        {
            int[,] dp = new int[n + 1, maxWeight + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= maxWeight; j++)
                {
                    if (j < weights[i])
                    {
                        dp[i + 1, j] = dp[i, j];

                    }
                    else
                    {
                        dp[i + 1, j] = Math.Max(dp[i, j], dp[i + 1,j - weights[i]]+values[i]);
                    }
                    //for (int k = 0; k*weights[i] <=j; k++)
                    //{
                    //    dp[i + 1, j] = Math.Max(dp[i+1, j], dp[i, j - k*weights[i]] + k*values[i]);
                    //}
                }
            }
            return dp[n, n];
        }
        /// <summary>
        /// 多重部分和
        /// </summary>
        /// <returns></returns>
        public int SolveBagProblem2()
        {
            int[] dp = new int[maxWeight + 1];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = -1;
            }
            dp[0] = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= maxWeight; j++)
                {
                    if (dp[j] >= 0)
                    {
                        dp[j] = values[i];
                    }else if (j < weights[i] || dp[j - weights[i]] <= 0)
                    {
                        dp[j] = -1;
                    }
                    else
                    {
                        dp[j] = dp[j - weights[i]] - 1;
                    }
                }
            }
            return dp[maxWeight];
        }
    }
}
