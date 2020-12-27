using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLeran.Sort
{
    public class SortHelper
    {
        #region 排序辅助函数

        public static int[] RandomArr(int size=10)
        {
            Random rand = new Random(size);
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(size);
            }
            return arr;
        }


        /// <summary>
        /// 交换两个数值
        /// </summary>
        /// <param name="a">数值1</param>
        /// <param name="b">数值2</param>
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// 打印一个数组
        /// </summary>
        /// <param name="arr"></param>
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]},");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
