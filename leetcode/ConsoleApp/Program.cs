using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LeetCodeBiz;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new HouseRobber2();
            int[] nums = new[] {6,4,3,9,5,9};
            Console.WriteLine(test.Rob(nums));

            
        }
    }
}
