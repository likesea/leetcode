using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz.DynamicProgramming
{
    /// <summary>
    /// 动态规划计数问题
    /// 问题的另一描述
    /// 整数划分问题是算法中的一个经典命题之一，有关这个问题的讲述在讲解到递归时基本都将涉及。所谓整数划分，是指把一个正整数n写成如下形式:
    /// n=m1+m2+...+mi; （其中mi为正整数，并且1 <= mi <= n），则{m1,m2,...,mi}为n的一个划分。
    /// 如果{m1,m2,...,mi}中的最大值不超过m，即max(m1,m2,...,mi)<=m，则称它属于n的一个m划分。这里我们记n的m划分的个数为f(n,m);
    /// 例如但n=4时，有5个划分，{0,0,0,4},{0,0,3,1},{0,0,2,2},{0,2,1,1},{1,1,1,1};
    /// 注意{0,0,1,3} 和 {0,0,3,1}被认为是同一个划分。
    /// 该问题是求出n的所有划分个数，即f(n, n)。下面我们考虑求f(n,m)的方法;
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
