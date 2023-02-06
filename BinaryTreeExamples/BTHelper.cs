using System;
using System.Collections.Generic;
using System.Text;
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
     
        #endregion

        #region האם ערך קיים בעץ
       
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        

        /// <summary>
        /// עמ 176 שאלה 9 מהספר
        /// </summary>
        /// <param name="root"></param>
      

        /// <summary>
        /// תרגיל 14
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>

       
        /// <summary>
        /// שאלה 12
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        
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
       
        #endregion


        #region פעולות עזר
        /// <summary>
        /// פעולת מעטפת המקבלת רמה בעץ ומחזירה כמה צמתים יש באותה רמה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="currentTreeLevel"></param>
        /// <returns></returns>
     

        /// <summary>
        /// פעולה המקבלת שורש עץ, את הרמה שאליה נרצה להגיע והרמה הנוכחית בה אנו נמצאים
        /// הפעולה תחזיר את כמות הצמתים ברמה המבוקשת
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <param name="targetTreeLevel">הרמה המבוקשת</param>
        /// <param name="currentLevel"> הרמה הנוכחית בעץ</param>
        /// <returns></returns>
       
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
