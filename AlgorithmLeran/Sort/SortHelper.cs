using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearn.Sort
{
    public class SortHelper
    {
        #region 排序辅助函数

        /// <summary>
        /// 产生一个随机int数组
        /// </summary>
        /// <param name="size">数组的长度</param>
        /// <returns></returns>
        public static int[] RandomArr(int size=10)
        {
            
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(0,size * 3);
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
