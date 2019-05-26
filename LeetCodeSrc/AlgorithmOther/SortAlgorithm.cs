using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOther
{
    /// <summary>
    /// 一些日常学习中碰到的排序算法
    /// </summary>
    public class SortAlgorithm
    {
        /// <summary>
        /// 快排
        /// 核心思想：两端向中间比较，并交换顺序
        /// 不稳定，O(nlog2n)
        /// </summary>
        /// <param name="arr">待排序数组</param>
        /// <param name="left">左边界</param>
        /// <param name="right">右边界</param>
        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right;
                int x = arr[i];

                while (i < j)
                {
                    while (i < j && arr[j] > x)
                    {
                        j--; // 从右向左找第一个小于x的数
                    }
                    if (i < j)
                    {
                        arr[i++] = arr[j];
                    }
                    while (i < j && arr[i] < x)
                    {
                        i++; // 从左向右找第一个大于x的数
                    }
                    if (i < j)
                    {
                        arr[j--] = arr[i];
                    }
                }

                arr[i] = x;
                QuickSort(arr, left, i - 1); // 递归调用
                QuickSort(arr, i + 1, right); // 递归调用
            }
        }
    }
}
