﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LeetCodeBiz;
using LeetCodeBiz.DynamicProgramming;
using LeetCodeBiz.Queue;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            var inverseTree = new InverseBinaryTree();
            var tree = GetBinaryTree();
            inverseTree.InverseTree(tree);

        }
        static Node GetBinaryTree()
        {
            var root = new Node() {Val = 9};
            root.Right= new Node() {Val = 8};
            root.Left = new Node() {Val = 7};
            var rootLeft = root.Left;
            rootLeft.Right = new Node() {Val = 6};
            rootLeft.Left = new Node() {Val =5};
            return root;
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
