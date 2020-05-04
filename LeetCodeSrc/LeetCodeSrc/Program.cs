using LeetCodeSrc.Algorithms;
using LeetCodeSrc.WeeklySolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSrc
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoubleWeekSolution23 solution = new DoubleWeekSolution23();
            //Console.WriteLine(solution.CountLargestGroup(15));

            //WeeklySolution183 solution = new WeeklySolution183();
            //Console.WriteLine(solution.NumSteps("1111011110000011100000110001011011110010111001010111110001"));
            GenerateAllParenthesis solution = new GenerateAllParenthesis();
            Console.WriteLine(solution.GenerateParenthesis(3));
            Console.ReadLine();     
        }
    }
}
