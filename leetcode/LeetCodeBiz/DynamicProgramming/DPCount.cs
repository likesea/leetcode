using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz.DynamicProgramming
{
    /// <summary>
    /// 动态规划计数问题
    /// </summary>
    public class DPCount
    {
        /// <summary>
        /// 总数
        /// </summary>
        private int count;
        /// <summary>
        /// 被分不超过多少份
        /// </summary>
        private int groups;

        private int mod;
        public DPCount(int n, int m,int M)
        {
            count = n;
            groups = m;
            mod = M;
        }
        /// <summary>
        /// 考虑a(1)+a(2).....+a(m)=n, 为n的m划分，如果所有a(i)>0,那么{a(i)-1} 就对应n-m的m划分，如果有
        /// a(i)=0,则对应n的m-1划分
        /// </summary>
        /// <returns></returns>
        public int Solve()
        {
            int [,] dp = new int[groups+1,count+1];
            dp[0, 0] = 1;
            for (int i = 1; i <=groups; i++)
            {
                for (int j = 0; j <= count; j++)
                {
                    if (j >= i)
                    {
                        dp[i, j] = (dp[i, j - i] + dp[i - 1, j])%mod;
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }
            return dp[groups, count];
        }
    }
}
