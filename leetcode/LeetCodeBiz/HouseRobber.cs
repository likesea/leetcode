using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    /// <summary>
    /// You are a professional robber planning to rob houses along a street. 
    /// Each house has a certain amount of money stashed, 
    /// the only constraint stopping you from robbing each of them is that 
    /// adjacent houses have security system connected and 
    /// it will automatically contact the police if two adjacent houses were broken into on the same night.
    /// Given a list of non-negative integers representing the amount of money of each house, 
    /// determine the maximum amount of money you can rob tonight without alerting the police.
    /// Credits:Special thanks to @ifanchu for adding this problem and creating all test cases. 
    /// Also thanks to @ts for adding additional test cases.
    /// </summary>
    public class HouseRobber
    {
        private int[] temp;
        public int Rob(int[] nums)
        {
            temp = new int[nums.Length];
            int result = RobCC(nums.Length,nums);

            return result;
        }

        private int RobCC(int n,int[] nums)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return nums[n - 1];
            }
            temp[0] = nums[0];
            if (n == 2)
            {
                return Math.Max(nums[n - 2], nums[n - 1]);
            }
            temp[1] = Math.Max(nums[1], nums[0]);
            for (int i = 2; i < n; i++)
            {
                temp[i]=Math.Max(temp[i-1], temp[i- 2]+ nums[i]);
            }

            return temp[n - 1];
        }
        
    }
}
