using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearn.Sort
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
        public static void MergeSort(int[] arr, int left, int right)
        {
            // 只有一个元素 直接返回
            if (left == right) return;
            int mid = left + (right - left) / 2;
            // 排序左半部分
            MergeSort(arr, left, mid);
            // 排序右半部分
            MergeSort(arr, mid + 1, right);
            // 合并左右两部分
            Merge(arr, left, mid, right);
        }
        
        private static void Merge(int[]arr, int left,  int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left;
            int j = mid + 1;
            int k = 0;

            // 左半部分还没有放完  右半部分也没有放完  取左半部分当前位置和右半部分当前位置最小的一个放入k的位置中
            while (i <= mid && j <= right)
            {
                temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
            }
            
            // 左半部分还没有放完 右半部分已经放完了 左半部分剩下的全部顺序放入 k以后的位置
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            // 右半部分还么有放完  左半部分已经全部访问 右半部分剩下的全部顺序放入k以后的位置
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            // 拷贝合并后的内容到原始数组中对应的位置上去  这一个小区间就已经排好序了
            for(int m = 0; m < temp.Length; m++)
            {
                arr[left + m] = temp[m];
            }
        }
        #endregion
    }
}
