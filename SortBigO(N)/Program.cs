using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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

            //for(int z = longestDigit; longestDigit >)
            for (int i = 0, count = 0; i < 10; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] % 10 == i)
                    {
                        result[count] = nums[j];
                        count++;
                    }
                }
            }
            nums = result;
            int[] tensArray = new int[nums.Length];
            for(int i = 0, count = 0; i < 10; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[j]/10 % 10 == i)
                    {
                        tensArray[count] = nums[j];
                        count++;
                    }
                }
            }

            result = tensArray;
            //int[] hundrethsArray = new int[nums.Length];

            //for(int i = 0, count = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < nums.Length; j++)
            //    {
            //        int temp = tensArray[j];
                  
            //        while (temp >= 10)
            //        {
            //            temp /= 10;
            //        }
            //        if (temp == i)
            //        {
            //            hundrethsArray[count] = tensArray[j];
            //            count++;
            //        }
            //    }
            //}

            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[100];
            Random random= new Random();

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 100);
            }

            nums = Sort(nums);

            ;
        }
    }
}
