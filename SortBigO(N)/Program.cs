using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortBigO_N_
{
    internal class Program
    {
        static int[] Sort(int[] nums)
        {
            int[] result = new int[nums.Length];

            int longestDigit = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                int currentLongestDigit = nums[i].ToString().Length;

                if(currentLongestDigit > longestDigit)
                {
                   longestDigit = currentLongestDigit;
                }
            }

            for (int i = longestDigit; i > 0; i++)
            {
                for(int j = 0; j < )
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 444, 5, 32, 90 };

            Sort(nums);
        }
    }
}
