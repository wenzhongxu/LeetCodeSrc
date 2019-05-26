using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOther
{
    /// <summary>
    /// 一些日常学习中碰到的查找算法
    /// </summary>
    public class SearchAlgorithm
    {
        /// <summary>
        /// 二分查找算法
        /// </summary>
        /// <param name="arr">原数组</param>
        /// <param name="key">查找目标值</param>
        /// <returns>目标查找值所在位置下标，找不到则返回-1</returns>
        public int BinarySearch(int[] arr, int key)
        {
            int low = 0; //定义最低下标为记录首位
            int high = arr.Length; // 定义最高下标为记录末位

            while (low <= high)
            {
                int mid = (low + high) / 2; // 折半
                if (key < arr[mid])
                {
                    high = mid - 1;
                }
                else if (key > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
