using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLeran.Sort
{
    /// <summary>
    /// 高级排序算法
    /// </summary>
    public class AdvanceSort
    {

        #region 希尔排序
        /// <summary>
        /// 希尔排序
        /// </summary>
        /// <param name="arr">待排序数组</param>
        public static void ShellSort(int[] arr)
        {
            // 求解Knuth序列在此长度的数组中最大的h(跨度)
            int h = 1;
            while (h <= arr.Length / 3)
            {
                h = h * 3 + 1;
            }

            // 最外层循环 控制希尔排序中的增量序列 
            for (int gap = h; gap > 0; gap = (gap-1)/3)
            {
                // 变种的插入排序，插入排序的插入步长由增量序列控制
                for (int i = gap; i < arr.Length; i++)
                {
                    for (int j = i; j > gap - 1; j -= gap)
                    {
                        if (arr[j] < arr[j - gap])
                        {
                            SortHelper.Swap(arr, j, j - gap);
                        }
                    }
                }
            }
        }
        #endregion

        #region 归并排序
        public static void Merge(int[]arr, int leftPtr,  int rightPtr, int rightBound)
        {
            int[] temp = new int[rightBound - leftPtr + 1];
            int mid = rightPtr - 1;
            int i = leftPtr;
            int j = rightPtr;
            int k = 0;

            while (i <= mid && j <= rightBound)
            {
                temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
            }
            
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= rightBound)
            {
                temp[k++] = arr[j++];
            }

            SortHelper.Print(temp);
        }
        #endregion
    }
}
