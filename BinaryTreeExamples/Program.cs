using System;
using DataStructureCore;
namespace BinaryTreeExamples
{
    class Program
    {
        public static int Multiple(int[] arr)
        {
            int multiple = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                multiple *= arr[i];
            }
            return multiple;
        }
        public static int[] findmaxakdad()
        {
            int[] bigNums = { 5, 6, 7, 8, 9 };
            int[] smallNums = { 0, 1, 2, 3, 4 };
            int max = 0;
            int[] maxArr = {};

            int[] arr = new int[5];
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[j] = 10 * bigNums[j] + smallNums[(j + i) % 5];
                    Console.Write(arr[j] + " ");                    
                }
                int m = Multiple(arr);
                if(m > max)
                {
                    max = m;
                    maxArr = arr;
                }    
                Console.WriteLine();
            }
            for (int i = 0; i < maxArr.Length; i++)
            {
                Console.WriteLine(maxArr[i]);
            }
            return maxArr;
        }
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine(
            1/(1/double.Epsilon)  );
            Console.WriteLine(Math.Cos(double.MaxValue));
            findmaxakdad();
            //Console.WriteLine(BTHelper.IncrementLetter('a'));
            //Console.WriteLine(BTHelper.IncrementLetter('x'));
            //Console.WriteLine(BTHelper.IncrementLetter('z'));


            //  BinNode<int> root = new BinNode<int>(54);
            //  BinNode<int> left = new BinNode<int>(null, 77, new BinNode<int>(55));
            //  BinNode<int> right = new BinNode<int>(new BinNode<int>(63), 48, null);
            //  root.SetRight(right);
            //  root.SetLeft(left);
            //  Console.WriteLine("InOrder:");
            //  BTHelper.PrintInOrder(root);
            //  Console.WriteLine();
            //  Console.WriteLine("PreOrder:");
            //  BTHelper.PrintPreOrder(root);
            //  Console.WriteLine();
            //  Console.WriteLine("PostOrder:");
            //  BTHelper.PrintPostOrder(root);
            //  Console.WriteLine();

            //  Console.WriteLine("does 63 exsists in tree?");
            //  Console.WriteLine(BTHelper.IsExistsInTree(root,63));
            //  Console.WriteLine($"There are {BTHelper.CountTreeNodes(root)} Nodes in tree" );
            //  Console.WriteLine($"Max in tree is {BTHelper.FindMax(root)}");
            //  Console.WriteLine(($"Min in tree is {BTHelper.FindMin(root)}"));


            //  Console.WriteLine("Print Random Tree");
            //  BinNode<int> rootRandom = BTHelper.CreateRandomTree(2, 10, 99);
            //  Console.WriteLine("InOrder:");
            //  BTHelper.PrintInOrder(rootRandom);
            //  Console.WriteLine();
            //  Console.WriteLine("PreOrder:");
            //  BTHelper.PrintPreOrder(rootRandom);
            //  Console.WriteLine();
            //  Console.WriteLine("PostOrder:");
            //  BTHelper.PrintPostOrder(rootRandom);
            //  Console.WriteLine();
            //  Console.WriteLine("does 63 exsists in tree?");
            //  Console.WriteLine(BTHelper.IsExistsInTree(rootRandom, 63));
            //  Console.WriteLine($"There are {BTHelper.CountTreeNodes(rootRandom)} Nodes in tree");


            // int [] width = BTHelper.BinTreeWidthVersion2(rootRandom);
            //  Console.WriteLine($" Now with a Counter Array Function Width Level is {width[0]} and width of this tree is {width[1]}");
            //  Console.WriteLine();
            //  Console.WriteLine("\nPress any Key To continue...");
            //  Console.ReadKey();
            //  Console.Clear();
            //  Console.WriteLine("The Nodes in Tree Width level are:");
            //  BTHelper.PrintNodesInLevel(rootRandom, width[0]);
            //  Console.WriteLine("\nPress any Key To continue...");
            //  Console.ReadKey();
            //  Console.Clear();

            //  Console.WriteLine("Create BST");
            //  Console.WriteLine("Enter Root of tree");
            //  BinNode<int> BSTRoot = new BinNode<int>(int.Parse(Console.ReadLine()));
            //  for (int i = 0; i < 7; i++)
            //  {
            //      Console.WriteLine("Enter a key");
            //      BTHelper.AddToBST(BSTRoot, int.Parse(Console.ReadLine()));


            //  }
            //  Console.WriteLine(BTHelper.IsBST(root));
            //  Console.WriteLine(BTHelper.IsBST(BSTRoot));
            //  Console.WriteLine(BSTRoot);
            ////  Console.WriteLine(BTHelper.FindParent(BSTRoot, BSTRoot.GetLeft().GetLeft().GetRight()).GetValue());
            //  Console.WriteLine("What value to Delete");
            //  BTHelper.RemoveFromBST(BSTRoot, int.Parse(Console.ReadLine()));
            //  Console.WriteLine(BSTRoot);

            //  Console.WriteLine("What value to Delete");
            //  BTHelper.RemoveFromBST(BSTRoot, int.Parse(Console.ReadLine()));
            //  Console.WriteLine(BSTRoot);




        }
    }
}
