using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace median_of_two_sorted_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 5, 6, 8, 9, 12 };
            int[] nums2 = { 4, 7, 13, 16, 18 };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }

        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int result = 0;
            int m = nums1.Length;
            int n = nums2.Length;
            int middle = (m + n) / 2;
            if (nums1[m - 1] < nums2[0])
            {
                result = (nums1[m - 1] + nums2[0]) / 2;
            }
            else
            {
                if (nums1[middle] < nums2[0])
                {
                    result = nums1[middle];
                }
                else
                {

                }
            }
            return result;
        }

        static int FindIndex(int a, int[] nums, int startIndex, int duartion)
        {
            int result = 0;
            int middle = duartion / 2;
            if (middle > 1)
            {
                if (nums[startIndex + middle] > a)
                {
                    result = FindIndex(a, nums, startIndex, middle);
                }
                else
                {
                    result = FindIndex(a, nums, startIndex + middle, middle);
                }
            }
            else
            {
                if (nums[startIndex + middle] > a)
                {
                    result = startIndex + middle + 1;
                }
                else
                {
                    result = FindIndex(a, nums, startIndex + middle, middle);
                }
            }
            return result;
        }
    }
}
