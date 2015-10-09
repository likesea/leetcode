using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz.DynamicProgramming
{
    /// <summary>
    /// 最长公共子序列
    /// </summary>
    public class LCS
    {
        private string s1;
        private string s2;
        private int[,] dp;
        public LCS(string s1, string s2)
        {
            this.s1 = s1;
            this.s2 = s2;
            dp=new int[s1.Length+1,s2.Length+1];
        }

        public int Solve()
        {
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                    }
                    else
                    {
                        dp[i + 1, j + 1] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                    }
                }
            }
            return dp[s1.Length , s2.Length];
        }
    }
}
