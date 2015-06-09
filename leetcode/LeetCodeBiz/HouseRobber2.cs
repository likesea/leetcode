using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class HouseRobber2
    {
        /// <summary>
        /// After robbing those houses on that street, 
        /// the thief has found himself a new place for his thievery 
        /// so that he will not get too much attention. This time, 
        /// all houses at this place are arranged in a circle. 
        /// That means the first house is the neighbor of the last one. 
        /// Meanwhile, the security system for these houses remain the same as for those in the previous street.
        /// Given a list of non-negative integers representing the amount of money of each house, 
        /// determine the maximum amount of money you can rob tonight without alerting the police.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Rob(int[] nums)
        {
            int length = nums.Length;
            List<int> newList = null;
            int[] resultInts = new int[length];
            if (length == 0)
            {
                return 0;
            }
            if (length == 1)
            {
                return nums[0];
            }
            if (length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            var temp = nums.ToList();
            for (int i = 0; i < length; i++)
            {
                
                
                newList = temp.GetRange(i+1, length - i-1);    
                newList.AddRange(temp.GetRange(0, i));
                resultInts[i] = RobCC(newList.Count, newList);
            }
           
            return resultInts.ToList().Max();
        }

      
      
        /// <summary>
        /// 这里n>2
        /// </summary>
        /// <param name="n"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        private int RobCC(int n, List<int> nums)
        {
            int[] temp = new int[n];
           
            temp[0] = nums[0];
           
            temp[1] = Math.Max(nums[1], nums[0]);
            for (int i = 2; i < n; i++)
            {
                temp[i] = Math.Max(temp[i - 1], temp[i - 2] + nums[i]);
            }

            return temp[n - 1];
        }
    }
}
