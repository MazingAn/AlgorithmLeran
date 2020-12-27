using System;

namespace AlgorithmLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("冒泡排序：");
            int[] arr = Sort.SortHelper.RandomArr();
            Console.WriteLine("Before Sort:");
            Sort.SortHelper.Print(arr);
            Console.WriteLine("AfterSort");
            Sort.BasicSort.BubbleSort(arr);
            Sort.SortHelper.Print(arr);
            Console.WriteLine("=====================================");

            Console.WriteLine("选择排序：");
            arr = Sort.SortHelper.RandomArr();
            Console.WriteLine("Before Sort:");
            Sort.SortHelper.Print(arr);
            Sort.BasicSort.SelectionSort(arr);
            Console.WriteLine("AfterSort");
            Sort.SortHelper.Print(arr);
            Console.WriteLine("=====================================");


            Console.WriteLine("插入排序：");
            arr = Sort.SortHelper.RandomArr();
            Console.WriteLine("Before Sort:");
            Sort.SortHelper.Print(arr);
            Sort.BasicSort.InsertionSort(arr);
            Console.WriteLine("AfterSort");
            Sort.SortHelper.Print(arr);
            Console.WriteLine("=====================================");

            Console.WriteLine("希尔排序：");
            arr = Sort.SortHelper.RandomArr();
            Console.WriteLine("Before Sort:");
            Sort.SortHelper.Print(arr);
            Sort.AdvanceSort.ShellSort(arr);
            Console.WriteLine("AfterSort:");
            Sort.SortHelper.Print(arr);
            Console.WriteLine("=====================================");

            Console.WriteLine("归并排序：");
            arr = Sort.SortHelper.RandomArr(16);
            Console.WriteLine("Before Sort:");
            Sort.SortHelper.Print(arr);
            Sort.AdvanceSort.MergeSort(arr, 0, arr.Length-1);
            Console.WriteLine("AfterSort:");
            Sort.SortHelper.Print(arr);
            Console.WriteLine("=====================================");

            Console.ReadKey();
        }

    }
}
