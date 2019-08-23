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
            int[] nums2 = { 4, 6, 7, 13, 16 };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }

        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int result = 0;
            if (nums1[nums1.Length - 1] < nums2[0])
            {
                result = (nums1[nums1.Length - 1] + nums2[0]) / 2;
            }
            else
            {

            }
            return result;
        }
    }
}
