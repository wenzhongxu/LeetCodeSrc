using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSrc.WeeklySolution
{
    public class WeeklySolution183
    {
        /// <summary>
        /// 给你一个数组 nums，请你从中抽取一个子序列，满足该子序列的元素之和 严格 大于未包含在该子序列中的各元素之和。
        /// 如果存在多个解决方案，只需返回 长度最小 的子序列。如果仍然有多个解决方案，则返回 元素之和最大 的子序列。
        /// 与子数组不同的地方在于，「数组的子序列」不强调元素在原数组中的连续性，也就是说，它可以通过从数组中分离一些（也可能不分离）元素得到。
        /// 注意，题目数据保证满足所有约束条件的解决方案是 唯一 的。同时，返回的答案应当按 非递增顺序 排列。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> MinSubsequence(int[] nums)
        {
            int max;
            int count = nums.Length;
            for (int i = 0; i < count - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (nums[j] > nums[max])
                    {
                        max = j;
                    }
                }
                int t = nums[max];
                nums[max] = nums[i];
                nums[i] = t;
            }

            int sum = 0;
            for (int n = 0; n < count; n++)
            {
                sum += nums[n];
            }

            List<int> result = new List<int>
            {
                nums[0]
            };

            int m = 0;
            while (sum - result.Sum() >= result.Sum())
            {
                result.Add(nums[m + 1]);
                m++;
            }

            return result;
        }

        /// <summary>
        /// 给你一个以二进制形式表示的数字 s 。请你返回按下述规则将其减少到 1 所需要的步骤数：
        /// 如果当前数字为偶数，则将其除以 2 。
        /// 如果当前数字为奇数，则将其加上 1 。
        /// 题目保证你总是可以按上述规则将测试用例变为 1 。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int NumSteps(string s)
        {
            var num = Convert.ToUInt64(s, 2);
            int step = 0;
            while (num != 1)
            {
                if (num % 2 == 1)
                {
                    num += 1;
                }
                else
                {
                    num /= 2;
                }

                step++;
            }
            return step;
        }

        /// <summary>
        /// 如果字符串中不含有任何 'aaa'，'bbb' 或 'ccc' 这样的字符串作为子串，那么该字符串就是一个「快乐字符串」。
        /// 给你三个整数 a，b ，c，请你返回 任意一个 满足下列全部条件的字符串 s：
        /// s 是一个尽可能长的快乐字符串。
        /// s 中 最多 有a 个字母 'a'、b 个字母 'b'、c 个字母 'c' 。
        /// s 中只含有 'a'、'b' 、'c' 三种字母。
        /// 如果不存在这样的字符串 s ，请返回一个空字符串 ""。
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public string LongestDiverseString(int a, int b, int c)
        {
            return string.Empty;
        }

        /// <summary>
        /// Alice 和 Bob 用几堆石子在做游戏。几堆石子排成一行，每堆石子都对应一个得分，由数组 stoneValue 给出。
        /// Alice 和 Bob 轮流取石子，Alice 总是先开始。在每个玩家的回合中，该玩家可以拿走剩下石子中的的前 1、2 或 3 堆石子 。比赛一直持续到所有石头都被拿走。
        /// 每个玩家的最终得分为他所拿到的每堆石子的对应得分之和。每个玩家的初始分数都是 0 。比赛的目标是决出最高分，得分最高的选手将会赢得比赛，比赛也可能会出现平局。
        /// 假设 Alice 和 Bob 都采取 最优策略 。如果 Alice 赢了就返回 "Alice" ，Bob 赢了就返回 "Bob"，平局（分数相同）返回 "Tie" 。
        /// </summary>
        /// <param name="stoneValue"></param>
        /// <returns></returns>
        public string StoneGameIII(int[] stoneValue)
        {
            return string.Empty;
        }
    }
}
