using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSrc.Algorithms
{
    /// <summary>
    /// 数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
    /// </summary>
    public class GenerateAllParenthesis
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> res = new List<string>();
            Generate(res, "", 0, 0, n);

            return res;
        }
        //count1统计“(”的个数，count2统计“)”的个数
        public void Generate(IList<string> res, string ans, int count1, int count2, int n)
        {

            if (count1 > n || count2 > n) return;

            if (count1 == n && count2 == n) res.Add(ans);


            if (count1 >= count2)
            {
                string ans1 = ans;
                Generate(res, ans + "(", count1 + 1, count2, n);
                Generate(res, ans1 + ")", count1, count2 + 1, n);

            }
        }

    }
}
