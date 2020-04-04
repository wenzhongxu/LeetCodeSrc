using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSrc.WeeklySolution
{
    public class DoubleWeekSolution23
    {
        /// <summary>
        /// 给你一个整数 n 。请你先求出从 1 到 n 的每个整数 10 进制表示下的数位和（每一位上的数字相加），然后把数位和相等的数字放到同一个组中。
        /// 请你统计每个组中的数字数目，并返回数字数目并列最多的组有多少个。
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CountLargestGroup(int n)
        {
            int i = 1;
            Dictionary<int, List<int>> sumList = new Dictionary<int, List<int>>();
            while (i <= n)
            {
                List<int> arr = new List<int>();
                int sum = 0;
                int temp = i;
                while (temp >= 1)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if (sumList.ContainsKey(sum))
                {
                    sumList[sum].Add(i);
                }
                else
                {
                    arr.Add(i);
                    sumList[sum] = arr;
                }
                i++;
            }

            return sumList.Count(p => p.Value.Count == sumList.Max(q => q.Value.Count));
        }

        /// <summary>
        /// 给你一个字符串 s 和一个整数 k 。请你用 s 字符串中 所有字符 构造 k 个非空 回文串 。
        /// 如果你可以用 s 中所有字符构造 k 个回文字符串，那么请你返回 True ，否则返回 False 。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool CanConstruct(string s, int k)
        {
            return true;
        }

        /// <summary>
        /// 给你一个以 (radius, x_center, y_center) 表示的圆和一个与坐标轴平行的矩形 (x1, y1, x2, y2)，其中 (x1, y1) 是矩形左下角的坐标，(x2, y2) 是右上角的坐标。
        /// 如果圆和矩形有重叠的部分，请你返回 True ，否则返回 False 。
        /// 换句话说，请你检测是否 存在 点(xi, yi) ，它既在圆上也在矩形上（两者都包括点落在边界上的情况）。
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="x_center"></param>
        /// <param name="y_center"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public bool CheckOverlap(int radius, int x_center, int y_center, int x1, int y1, int x2, int y2)
        {
            return true;
        }

        /// <summary>
        /// 一个厨师收集了他 n 道菜的满意程度 satisfaction ，这个厨师做出每道菜的时间都是 1 单位时间。
        /// 一道菜的 「喜爱时间」系数定义为烹饪这道菜以及之前每道菜所花费的时间乘以这道菜的满意程度，也就是 time[i]*satisfaction[i] 。
        /// 请你返回做完所有菜 「喜爱时间」总和的最大值为多少。
        /// 你可以按 任意 顺序安排做菜的顺序，你也可以选择放弃做某些菜来获得更大的总和。
        /// </summary>
        /// <param name="satisfaction"></param>
        /// <returns></returns>
        public int MaxSatisfaction(int[] satisfaction)
        {
            return 0;
        }
    }
}
