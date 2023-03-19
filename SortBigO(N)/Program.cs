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
        static int GetMaxValue(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max= array[i];
                }
            }

            return max;
        }
        static int[] RadixSort(int[] nums)
        {
            int max = GetMaxValue(nums);

            for (int i = 1; max / i > 0; i*= 10)
            {
                MiniSort(nums, i);
            }

            return nums;
        }
        static int[] MiniSort(int[] nums, int exponent)
        {
            int[] sortArray = new int[10];
            int[] result = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                sortArray[(nums[i] / exponent) % 10]++;
            }

            for(int i = 1; i < sortArray.Length; i++)
            {
                sortArray[i] = sortArray[i] + sortArray[i - 1];
            }

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                sortArray[(nums[i] / exponent) % 10]--;
                result[sortArray[(nums[i] / exponent) % 10]] = nums[i];
                
            }

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = result[i];
            }

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

            int[] test = new int[] { 170, 45, 75, 90, 802, 24, 2, 66 };

            nums = RadixSort(nums);

           // test = RadixSort(test);

            ;
        }
    }
}
