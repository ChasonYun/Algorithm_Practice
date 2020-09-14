using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1};
            Solution solution = new Solution();

            int res = solution.MinMoves2(nums);
        }
    }

    public class Solution
    {
        public int MinMoves2(int[] nums)
        {
            int sum = 0;
            QuickSort(ref nums, 0, nums.Length - 1);
            for(int i = 0; i < nums.Length; i++)
            {
                sum += Math.Abs(nums[nums.Length / 2] - nums[i]);
            }
            return sum;
        }


        private void Swap(ref int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }


        public void QuickSort(ref int[] nums, int left, int right)//快排 
        {
            if (left < right)
            {
                int i = left;
                int j = right;
                int middle = nums[(left + right) / 2];//轴
                while (true)
                {
                    while (nums[i] < middle)
                    {
                        i++;
                    }
                    while (nums[j] > middle)
                    {
                        j--;
                    }
                    if (i >= j)
                    {
                        break;
                    }
                    Swap(ref nums, i, j);
                    if (nums[i] == nums[j])
                    {
                        i++;
                    }
                }
                QuickSort(ref nums, left, i - 1);
                QuickSort(ref nums, j + 1, right);
            }

        }
    }
}
