using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz.DynamicProgramming
{
    /// <summary>
    /// 多重集组合数
    /// </summary>
    public class MultiSetCombin
    {
        private int num;
        private int groups;
        private int mod;
        private int[] a;
        public MultiSetCombin(int n, int m, int[] a,int M)
        {
            num = n;
            groups = m;
            mod = M;
            this.a = a;
        }

        public int Solve()
        {
            int[,] dp = new int[num+1,groups+1];
            for (int i = 0; i <= num; i++)
            {
                dp[i, 0] = 1;
            }
            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j <= groups; j++)
                {
                    if (j >= 1 + a[i])
                    {
                        //加上mod避免出现负数
                        dp[i + 1, j] = (dp[i + 1, j - 1] + dp[i, j] - dp[i, j - 1 - a[i]]+mod)%mod;
                    }
                    else
                    {
                        dp[i + 1, j] = (dp[i + 1, j - 1] + dp[i, j])%mod;
                    }
                }
            }
            return dp[num , groups];
        }
    }
}
