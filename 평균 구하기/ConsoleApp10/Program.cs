using System;

namespace ConsoleApp10
{
    public class Solution
    {
        public double solution(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }
    }
}