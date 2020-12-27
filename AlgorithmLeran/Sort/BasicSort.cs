using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearn.Sort
{
    /// <summary>
    /// 基础排序算法
    /// </summary>
    public class BasicSort
    {

        #region 冒泡排序
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr">一个int类型的数组</param>
        public static void BubbleSort(int[] arr)
        {
            // 冒泡排序的外层循环 控制一共有多少轮的挨个交换
            // 每次一轮挨个交换之后，最后一个都应该被舍弃 
            for(int i = arr.Length-1; i > 0; i--) 
            {
                // 每一轮的挨个比对和交换
                for(int j = 0; j < i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        SortHelper.Swap(arr, j, j+1);
                    }
                }
            }
        }
        #endregion

        #region 选择排序
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectionSort(int[] arr)
        {
            // 最外层循环，控制排序空间 没完成一轮内层循环排序空间的长度就-1
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int minIdx = i;
                // 内层循环，在排序空间内选择最小的元素 和有序空间的最后一个元素交换
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                SortHelper.Swap(arr, i, minIdx);
            }
        }
        #endregion

        #region 插入排序
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="arr">待排序数据</param>
        public static void InsertionSort(int[] arr)
        {
            // 最外层循环 这里的arr[i]就是每一次新入手的那张牌
            for(int i = 1; i < arr.Length; i++)
            {
                // 内存循环，这里的arr[j] 到 arr[0] 都已经是有序的 相当于已经在我们手里的牌
                for(int j = i; j > 0; j--)
                {
                    if(arr[j] < arr[j - 1])
                    {
                        SortHelper.Swap(arr, j, j - 1);
                    }
                }
            }
        }
        #endregion 
    }
}
