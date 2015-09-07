using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LeetCodeBiz;
using LeetCodeBiz.DynamicProgramming;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            //new Queen().SolveQueens(8);
            //Console.WriteLine(new MinCost(15, new int[] {2,3,4,5,1}).Solve());
            //Console.WriteLine(new LCS("asfdkkk","adfkkk").Solve());
            //Console.WriteLine(new BagProblem(new []{3,4,2},new int[]{4,5,3},7 ).SolveCompleteBagProblem());
            //Console.WriteLine(new BagProblem(new[] { 3, 5, 8 }, new int[] { 3, 2, 2 }, 17).SolveBagProblem2());
            //Console.WriteLine(new LIS().Solve2(new int[]{4,2,3,1,5}));
            new LIS().binarySearch(new int[]{1,2,3,4,4,4,4,5},4 );
        }
        static void TestSpiralMatrix2(int m)
        {
            var obj = new SpiralMatrix2();
            obj.GenerateMatrix(m);
        }
        static void TestTreeToList()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(5);
            root.right.right = new TreeNode(6);
            new FlattenBinaryTreetoLinkedList().Flatten(root);
        }

        static void TestListCycle()
        {
            ListNode root = new ListNode(1);
            root.next = new ListNode(2);
            root.next.next = root;
            new LinkedListCycle2().DetectCycle(root);
        }

        static void TestSortList()
        {
            ListNode root = new ListNode(5);
            root.next = new ListNode(8);
            new SortListSolution().SortList(root);
        }

        static void TestGrayCode()
        {
            var list = new GrayCodeSolution().GrayCode(3);
            Console.WriteLine("aa");
        }

        static void TestSingleNumber()
        {
            int[] list = new[] {1, 2, 3, 4, 4, 2, 1};
            var re = new SingleNumberSol().SingleNumber(list);
        }
    }
}
