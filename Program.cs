using System.Collections;
using System.Collections.Generic;

namespace advc_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //range<double> r = new range<double>(11.1, 111.2);
            //;
            //Console.WriteLine(r.Length());


            #region q2

            //    ArrayList al1 = new ArrayList();
            //    al1.Add(1);
            //    al1.Add(2);
            //    al1.Add(7);
            //    al1.Add(3);
            //    al1.Add(4);
            //    int temp = 0;

            //    for (int i = 0, j = al1.Count - 1; i < (int)al1.Count / 2; i++, j--)
            //    {
            //        temp = (int)al1[i];
            //        al1[i] = al1[j];
            //        al1[j] = temp;

            //    }
            //    foreach (var item in al1)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion


            #region q3
            //You are given a list of integers.Your task is to find and return
            //a new list containing only the even numbers from the given list.
            List<int> l1 = new List<int>();
            List<int> lEven = new List<int>();
            l1.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            foreach (var item in l1)
            {
                if (item % 2 == 0)
                {
                    lEven.Add(item);
                }
            }
            foreach (var item in lEven)
            {
                Console.WriteLine(item);
            }


            #endregion
        }
    }
}