namespace Leetcode.P4;

//Given two sorted arrays nums1 and nums2 of size m and n respectively, return 
//the median of the two sorted arrays. 
//
// The overall run time complexity should be O(log (m+n)). 
//
// 
// Example 1: 
//
// 
//Input: nums1 = [1,3], nums2 = [2]
//Output: 2.00000
//Explanation: merged array = [1,2,3] and median is 2.
// 
//
// Example 2: 
//
// 
//Input: nums1 = [1,2], nums2 = [3,4]
//Output: 2.50000
//Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
// 
//
// 
// Constraints: 
//
// 
// nums1.length == m 
// nums2.length == n 
// 0 <= m <= 1000 
// 0 <= n <= 1000 
// 1 <= m + n <= 2000 
// -10⁶ <= nums1[i], nums2[i] <= 10⁶ 
// 
//
// Related Topics Array Binary Search Divide and Conquer 👍 32838 👎 3632


//leetcode submit region begin(Prohibit modification and deletion)
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int numpos1 = 0;
        int numpos2 = 0;
        double median;
        int[] merged = new int[nums1.Length + nums2.Length];

        for (int i = 0; i < merged.Length; i++ ) {
            if (numpos1 == nums1.Length) {
                merged[i] = nums2[numpos2];
                numpos2++;
            }
            else if (numpos2 == nums2.Length) {
                merged[i] = nums1[numpos1];
                numpos1++;
            }
            else if (nums1[numpos1] < nums2[numpos2]) {
                merged[i] = nums1[numpos1];
                numpos1++;
            }
            else {
                merged[i] = nums2[numpos2];
                numpos2++;
            }
        };
        if (merged.Length % 2 == 0) {
            median = (merged[merged.Length / 2 - 1] + merged[merged.Length / 2]) / 2.0;

        }
        else {
            median = merged[merged.Length / 2];
        }
        return median;

    }
}
//leetcode submit region end(Prohibit modification and deletion)
