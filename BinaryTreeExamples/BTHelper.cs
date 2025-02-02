﻿using System;
using System.Reflection;
//using System.Collections.Generic;
using System.Text;
using System.Threading;
using DataStructureCore;

namespace BinaryTreeExamples
{
    //כאן יופיעו כל הפעולות העזר עבור עצים
    class BTHelper
    {

        #region יצירת עץ
        public static BinNode<int> CreateTree()
        {
            BinNode<int> root;
            BinNode<int> left;
            BinNode<int> right;
            //קליטת הנתון
            int val = InputData();
            //אם נקלט null
            if (val == -1)
                return null;
            //אחרת צור את השורש
            root = new BinNode<int>(val);
            //צור את תת העץ השמאלי
            left = CreateTree();
            //צור את תת העץ הימני
            right = CreateTree();
            //חבר את תת העץ השמאלי לשורש
            root.SetLeft(left);
            //חבר את תת העץ הימני לשורש
            root.SetRight(right);
            //החזר את שורש תת העץ/שורש העץ
            return root;
        }

        /// <summary>
        /// פעולה היוצרת עץ רנדומלי בגובה
        /// height
        /// ערך כל צומת בטווח שבין max ל min
        /// </summary>
        /// <param name="height"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static BinNode<int> CreateRandomTree(int height, int min, int max)
        {
            Random rnd = new Random();
            BinNode<int> root;
            BinNode<int> left;
            BinNode<int> right;

            if (height == -1)
                return null;
            int val = rnd.Next(min, max + 1);
            root = new BinNode<int>(val);
            left = CreateRandomTree(height - 1, min, max);
            right = CreateRandomTree(height - 1, min, max);
            root.SetLeft(left);
            root.SetRight(right);
            return root;
        }

        private static int InputData()
        {
            Console.WriteLine("Please enter Value, enter -1 for null value (end Branch)");
            return int.Parse(Console.ReadLine());
        }


        #endregion


        #region סריקות
        #region סריקה תחילית
        /// <summary>
        /// פעולה המדפיסה עץ בינארי בסריקה תחילית
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        public static void PrintPreOrder<T>(BinNode<T> root)
        {
            if (root == null) return;

            Console.WriteLine(root.GetValue());
            PrintPreOrder(root.GetLeft());
            PrintPreOrder(root.GetRight());
        }
        #endregion

        #region סריקה תוכית
        /// <summary>
        /// פעולה המדפיסה עץ בינארי בסריקה תוכית
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        public static void PrintInOrder<T>(BinNode<T> root)
        {
            if (root == null) return;

            PrintPreOrder(root.GetLeft());
            Console.WriteLine(root.GetValue());
            PrintPreOrder(root.GetRight());
        }
        #endregion

        #region סריקה סופית
        /// <summary>
        /// פעולה המדפיסה עץ בינארי בסריקה סופית
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        public static void PrintPostOrder<T>(BinNode<T> root)
        {
            if (root == null) return;

            PrintPreOrder(root.GetLeft());
            PrintPreOrder(root.GetRight());
            Console.WriteLine(root.GetValue());
        }
        #endregion
        #endregion



        #region האם עלה
        /// <summary>
        /// פעולה הבודקת האם הצומת הוא עלה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns>אמת אם עלה ושקר אחרת</returns>
        public static bool IsLeaf<T>(BinNode<T> root)
        {
            if (root == null) return false;
            return !root.HasLeft() && !root.HasRight();
        }

        #endregion


        #region פעולות על עצים
        #region ספירת צמתים
        /// <summary>
        /// פעולה המקבלת שורש של עץ ומחזירה את כמות הצמתים בעץ
        /// n- מספר הצמתים
        /// הפעולה מבקרת בכל צומת בדיוק פעם אחת
        /// ולכן O(n)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CountTreeNodes<T>(BinNode<T> root)
        {
            if (root == null) return 0;
            return 1 + CountTreeNodes(root.GetLeft()) + CountTreeNodes(root.GetRight());
        }

        #endregion

        #region האם ערך קיים בעץ



        public static bool IsExistsInTree<T>(BinNode<T> root, T val)
        {
            if (root == null) return false;

            return root.GetValue().Equals(val) || IsExistsInTree(root.GetLeft(), val) || IsExistsInTree(root.GetRight(), val);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsEachTwoChildren<T>(BinNode<T> root)
        {
            if (root == null) return false;

            return IsLeaf(root) || (root.HasLeft() && root.HasRight());
        }

        /// <summary>
        /// עמ 176 שאלה 9 מהספר
        /// </summary>
        /// <param name="root"></param>
        public static void IncrementCharValues(BinNode<char> root)
        {
            if (root == null) return;

            root.SetValue(IncrementLetter(root.GetValue()));
            IncrementCharValues(root.GetLeft());
            IncrementCharValues(root.GetRight());
        }

        public static char IncrementLetter(char ch)
        {
            return (char)((ch + 1 - 'a') % ('z' - 'a') + 'a');
        }

        /// <summary>
        /// תרגיל 14
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CountLeavesInTree<T>(BinNode<T> root)
        {
            if (root == null) return 0;
            if (IsLeaf(root)) return 1;
            return CountLeavesInTree(root.GetLeft()) + CountLeavesInTree(root.GetRight());
        }

        /// <summary>
        /// שאלה 12
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>


        //24
        public static bool IsParentToOnlyChild<T>(BinNode<T> root)
        {
            if(root == null) return false;
            return (root.HasLeft() || root.HasRight()) && !(root.HasLeft() && root.HasRight());
        }

        public static int CountOnlyChildren<T>(BinNode<T> root)
        {
            if(root == null) return 0;
            int value = 0;
            if (IsParentToOnlyChild(root)) value = 1;

            return value + CountOnlyChildren(root.GetLeft()) + CountOnlyChildren(root.GetRight());
        }

        public static int CountOnlyChildrenWithOnlychildren(BinNode<int> root)
        {
            if (root == null) return 0;
            int value = 0;
            if (IsParentToOnlyChild(root) && (IsParentToOnlyChild(root.GetRight()) || IsParentToOnlyChild(root.GetLeft())))
                value = 1;

            return value + CountOnlyChildren(root.GetLeft()) + CountOnlyChildren(root.GetRight());
        }

        //38
        public static void PrintLevel<T>(BinNode<T> root, int level)
        {
            if (root == null) return;
            Queue<int> levelQ = new Queue<int>();
            Queue<BinNode<T>> q = new Queue<BinNode<T>>();
            q.Insert(root);
            levelQ.Insert(0);
            while (!q.IsEmpty() && levelQ.Head() <= level)
            {
                BinNode<T> node = q.Remove();
                int l = levelQ.Remove();

                if (l == level)
                    Console.WriteLine(node.GetValue());

                if (root.HasLeft())
                {
                    q.Insert(root.GetLeft());
                    levelQ.Insert(l + 1);
                }
                if (root.HasRight())
                {
                    q.Insert(root.GetRight());
                    levelQ.Insert(l + 1);
                }
            }
        }

        public static void BreadthOrder<T>(BinNode<T> root)
        {
            if (root == null) return;
            Queue<int> levelQ = new Queue<int>();
            Queue<BinNode<T>> q = new Queue<BinNode<T>>();
            q.Insert(root);
            levelQ.Insert(0);
            while (!q.IsEmpty())
            {
                BinNode<T> node = q.Remove();
                int level = levelQ.Remove();

                //something

                if (root.HasLeft())
                {
                    q.Insert(root.GetLeft());
                    levelQ.Insert(level + 1);
                }
                if (root.HasRight())
                {
                    q.Insert(root.GetRight());
                    levelQ.Insert(level + 1);
                }
            }
        }

        public static int LevelDifference<T>(BinNode<T> root, T x, T y)
        {
            int xLevel = -1;
            int yLevel = -1;
            Queue<BinNode<T>> q = new Queue<BinNode<T>>();
            Queue<int> level = new Queue<int>();
            q.Insert(root);
            level.Insert(0);
            while (!q.IsEmpty() && (xLevel == -1 || yLevel == -1))
            {
                BinNode<T> node = q.Remove();
                int l = level.Remove();
                if (node.GetValue().Equals(x))
                    xLevel = l;
                if (node.GetValue().Equals(y))
                    yLevel = l;

                if (root.HasLeft())
                {
                    q.Insert(root.GetLeft());
                    level.Insert(l + 1);
                }
                if (root.HasRight())
                {
                    q.Insert(root.GetRight());
                    level.Insert(l + 1);
                }
            }

            return xLevel - yLevel;
        }

        public static bool IsMeirTree(BinNode<int> root)
        {
            if (root == null) return false;
            if(IsLeaf<int>(root)) return true;
            if(!root.HasLeft() || !root.HasRight()) return false;

            return Math.Abs(root.GetLeft().GetValue() - root.GetRight().GetValue()) <= 2 
                && IsMeirTree(root.GetLeft()) && IsMeirTree(root.GetRight());
        }

        public static bool IsBalancedTree<T>(BinNode<T> root)
        {
            if (root == null) return false;
            return CountTreeNodes(root.GetRight()) == CountTreeNodes(root.GetLeft());
        }

        public static bool IsZigzag<T>(BinNode<T> root, bool isLeft)
        {
            if (IsLeaf(root)) return true;
            bool left = false, right = false, returnVal = true;
            if (isLeft)            
                right = root.HasRight();            
            else
                left = root.HasLeft();

            if (root.HasLeft())
                returnVal &= IsZigzag(root.GetLeft(), true);
            if (root.HasRight())
                returnVal &= IsZigzag(root.GetRight(), false);

            //return returnVal && (right ^ left);
            return returnVal && (right || left);
        }

        public static bool IsZigzag<T>(BinNode<T> root)
        {
            if (root == null) return false;
            if (IsLeaf(root)) return false;
            return IsZigzag(root.GetLeft(), true) && IsZigzag(root.GetRight(), false);
        }

        public static bool IsBreadthSorted(BinNode<int> root)
        {
            if (root == null) return true;
            Queue<int> levelQ = new Queue<int>();
            Queue<BinNode<int>> q = new Queue<BinNode<int>>();
            levelQ.Insert(0);
            q.Insert(root);

            int currLevel = 0;
            int prevSum = 0;
            int currSum = 0;
            while (!q.IsEmpty())
            {
                BinNode<int> node = q.Remove();
                int level = levelQ.Remove();

                if (level == currLevel)
                    currSum += node.GetValue();
                if (level > currLevel)
                {
                    if (currSum <= prevSum) return false;

                    currLevel++;
                    prevSum = currSum;
                    currSum = node.GetValue();
                }

                if (node.HasLeft())
                {
                    q.Insert(node.GetLeft());
                    levelQ.Insert(level + 1);
                }
                if (node.HasRight())
                {
                    q.Insert(node.GetRight());
                    levelQ.Insert(level + 1);
                }
            }
            return true;
        }

        public static bool IsBoserTree(BinNode<int> root)
        {
            if (root == null) return false;
            if(IsLeaf(root)) return true;

            if (!root.HasLeft() || !root.HasRight()) 
                return false;
            int left = root.GetLeft().GetValue();
            int right = root.GetRight().GetValue();
            if (!(right > left && left > root.GetValue()))
                return false;
            return IsBoserTree(root.GetLeft()) && IsBoserTree(root.GetRight());
        }

        public static bool IsOmegaTree(BinNode<int> root)
        {
            if (root == null) return false;
            if (IsLeaf(root)) return true;
            if (!root.HasLeft() || !root.HasRight()) return false;
            return root.GetValue() <= Sum(root.GetLeft()) && root.GetValue() >= Sum(root.GetRight()) 
                && IsOmegaTree(root.GetLeft()) && IsOmegaTree(root.GetRight());
        }

        public static int Sum(BinNode<int> root)
        {
            if (root == null) return 0;
            return root.GetValue() + Sum(root.GetLeft()) + Sum(root.GetRight());
        }

        public static bool WordFromRoot(BinNode<char> tree, string str)
        {
            if (tree == null) return true;
            if (str == "") return true;
            if (tree.GetValue() != str[0]) return false;
            return WordFromRoot(tree.GetLeft(), str.Remove(str.Length - 1)) || WordFromRoot(tree.GetRight(), str.Remove(str.Length - 1));
        }

        public static void PrintAll(BinNode<int> tree)
        {
            if (tree == null) return;
            PrintAll(tree, "");
        }
        public static void PrintAll(BinNode<int> tree, string st)
        {            
            st += tree.GetValue();
            if (IsLeaf(tree))
            {
                Console.WriteLine(st);
            }
            else
            {
                if (tree.HasLeft())
                    PrintAll(tree.GetLeft(), st);
                if (tree.HasRight())
                    PrintAll(tree.GetRight(), st);
            }   
        }

        public static bool Exist(BinNode<int> t, int x)
        {
            if (t == null) return false;
            if (t.GetValue() == x) return true;
            return Exist(t.GetLeft(), x) || Exist(t.GetRight(), x);
        }

        public static Node<int> Check(BinNode<int> t1, BinNode<int> t2)
        {
            Node<int> first = new Node<int>(-1);
            first = Check(t1, t2, first);
            return first.GetNext();
        }

        public static Node<int> Check(BinNode<int> t1, BinNode<int> t2, Node<int> list)
        {
            if (t1 == null) return null;
            if (!Exist(t2, t1.GetValue()))
            {
                Node<int> next = list.GetNext();
                list.SetNext(new Node<int>(t1.GetValue()));
                list.GetNext().SetNext(next);
            }
            Check(t1.GetLeft(), t2, list);
            Check(t1.GetRight(), t2, list);
            return list;
        }

        #endregion


        #region גובה עץ
        /// <summary>
        /// פעולה המחשבת את גובה העץ בסריקה סופית
        /// גובה תת עץ שמאל, גובה תת עץ ימין ואז הגובה של העץ כולו הינו
        /// 1+ גובה המקסימלי מבין שני תתי העצים
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int HeightOfTree<T>(BinNode<T> root)
        {
            if (root == null) return 0;
            return Math.Max(HeightOfTree(root.GetLeft()), HeightOfTree(root.GetRight())) + 1;
        }

        #endregion

        #region הדפסת רמה בעץ

        #region פעולת המעטפת
        /// <summary>
        /// הדפסת הצמתים ברמה מסוימת בעץ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="targetLevel"></param>

        #endregion

        #region פעולת ההדפסה
        /// <summary>
        /// הפעולה תדפיס את ערך הצומת ברמה המבוקשת
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="targetLevel">הרמה שנרצה להדפיס</param>
        /// <param name="currentLevel">הרמה הנוכחית שאליה הגענו בסריקה</param>

        #endregion
        #endregion

        #region חישוב רוחב של עץ

        #region פעולת ראשית
        /// <summary>
        /// פעולה מחשבת את רוחב העץ- הרמה שמכילה את הכי הרבה צמתים
        /// הפעולה תחזיר מערך בגודל 2 - בתא 0 יוחזר הרמה שמכילה את הכי הרבה צמתים
        /// ובתא 1 - הרוחב של העץ
        /// נגדיר h - גובה של העץ
        /// נגדיר n- כמות הצמתים בעץ
        /// CountNodesInLevel -  O(n)
        /// הפעולה מחשבת גובה ואז רצה בלולאה כגובה העץ ולכן נקבל
        /// 
        /// o(h)+(o(h) * O(n)).
        /// ==>(o(h) * O(n))
        /// במקרה הגרוע זה עץ שרשרת (כמו שרשרת חוליות רגילה)
        /// במקרה כזה 
        /// h==n
        /// ולכן
        /// O(n^2)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int[] Breadth<T>(BinNode<T> root)
        {
            int[] arr = { 0, 0 };
            for (int i = 0; i < HeightOfTree(root); i++)
            {
                int breadth = BreadthOfLevel(root, i);
                if (breadth > arr[1])
                {
                    arr[1] = breadth;
                    arr[0] = i;
                }
            }
            return arr;
        }
        #endregion


        #region פעולות עזר
        /// <summary>
        /// פעולת מעטפת המקבלת רמה בעץ ומחזירה כמה צמתים יש באותה רמה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="currentTreeLevel"></param>
        /// <returns></returns>
        public static int BreadthOfLevel<T>(BinNode<T> root, int targetLevel)
        {
            int counter = 0;

        Queue<BinNode<T>> q = new Queue<BinNode<T>>();
        Queue<int> levelQ = new Queue<int>();
        q.Insert(root);
            levelQ.Insert(0);

            while (!q.IsEmpty())
            {
                BinNode<T> node = q.Remove();
        int level = levelQ.Remove();

                if (level == targetLevel)
                    counter++;
                if (level <= targetLevel)
                {
                    if (root.HasLeft())
                    {
                        q.Insert(root.GetLeft());
                        levelQ.Insert(level + 1);
                    }
                    if (root.HasRight())
                    {
                        q.Insert(root.GetRight());
                        levelQ.Insert(level + 1);
                    }
                }                
            }
            return counter;
        }

        #endregion

        #endregion

        #region חישוב רוחב של עץ באמצעות מערך מונים
        /// <summary>
        /// n= כמות הצמתים
        /// CountNodesInLevel- מבצעת סריקה אחת על העץ ולכן O(n)
        /// FindMax- במקרה של עץ שרשרת (כמו שרשרת חוליות)- O(n)
        /// ולכן קיבלנו
        /// O(n) + O(n)=O(n)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>


        #region פעולות עזר
        /// <summary>
        /// הפעולה מקבלת שורש עץ
        /// מערך מונים בגודל גובה העץ
        /// ורמה נוכחית
        /// הפעולה תוסיף 1 בתא המייצג את מספר הרמה בתהליך הסריקה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="treeLevels"></param>
        /// <param name="currentLevel"></param>


        /// <summary>
        /// מציאת מקסימום במערך.
        /// הפעולה מחזירה מערך בגודל 2
        /// תא הראשון המיקום של הערך המקסימלי
        /// והתא השני הערך המקסימלי במערך
        /// </summary>
        /// <param name="treeLevels"></param>
        /// <returns></returns>

        #endregion
        #endregion

        #region Binary Search Tree

        #region הוספת ערך לעץ חיפוש

        #endregion

        #region מקסימום/מינימום בעץ חיפוש

        #endregion

        #region האם עץ חיפוש

        /// <summary>
        /// כל צומת צריך להיות גדול יותר מהכי גדול בתת העץ השמאלי שלו
        /// ויותר קטן מהכי קטן בתת עץ הימני שלו
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>






        #endregion

        #region מצא הורה בעץ חיפוש

        #endregion

        #region מחיקת ערך בעץ חיפוש
        //            The node has no children(it's a leaf node). You can delete it. ...
        //The node has just one child.To delete the node, replace it with that child. ...
        //The node has two children.In this case, find the MAX in the LEFT Side of the node. (or MIN of the RIGHT SIDE OF THE NODE)

    }





    #endregion
    #endregion


}
