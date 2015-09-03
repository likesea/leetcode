using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
//    Given an array of integers, every element appears three times except for one. Find that single one.
//Note:
//Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
    public class SingleNumberSol2
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                result ^= nums[i];
            }
            result = (result*3 - sum)/2;
            return result;
        }
    }
}
