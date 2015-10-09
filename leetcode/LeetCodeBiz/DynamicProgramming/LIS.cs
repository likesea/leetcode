using System;

namespace LeetCodeBiz.DynamicProgramming
{
    /// <summary>
    /// 最长上升
    /// </summary>
    public class LIS
    {
        public int Solve(int[] subseq)
        {
            int res = 0;
            int[] dp = new int [subseq.Length];
            for (int i = 0; i < subseq.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (subseq[j] < subseq[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                    
                }
                res = Math.Max(res, dp[i]);
            }
            return res;
        }

        public int Solve2(int[] subseq)
        {
            int[] dp = new int[subseq.Length];
            for (int i = 0; i < subseq.Length; i++)
            {
                dp[i] = Int32.MaxValue;
            }
            for (int i = 0; i < subseq.Length; i++)
            {
                Lower_bound(dp,subseq[i]);
            }
            return binarySearch(dp, Int32.MaxValue);
        }

        private void Lower_bound(int[] sub, int val)
        {
            int index = binarySearch(sub, val);
            sub[index] = val;
        }
        /// <summary>
        /// 类似于c++中的lower_bound,找出sub中大于或等于value的最小的那个位置
        /// </summary>
        /// <param name="sub"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int binarySearch(int[] sub, int value)
        {
            int begin = 0;
            int end = sub.Length;
            int bound = 0;
            while (begin <= end)
            {
                int mid = (begin + end) / 2;
                if (sub[mid] >= value)
                {
                    if (bound == mid)
                    {
                        break;
                    }
                    bound = mid;
                    end = mid;
                }
                else if(sub[mid]<value)
                {
                    if (bound == mid+1)
                    {
                        break;
                    }
                    bound = mid+1;
                    begin = mid;
                }
            }
            return bound;
        }
    }
}
