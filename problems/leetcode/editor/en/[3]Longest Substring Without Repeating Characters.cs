namespace Leetcode.P3;

//Given a string s, find the length of the longest substring without duplicate 
//characters. 
//
// 
// Example 1: 
//
// 
//Input: s = "abcabcbb"
//Output: 3
//Explanation: The answer is "abc", with the length of 3. Note that "bca" and 
//"cab" are also correct answers.
// 
//
// Example 2: 
//
// 
//Input: s = "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.
// 
//
// Example 3: 
//
// 
//Input: s = "pwwkew"
//Output: 3
//Explanation: The answer is "wke", with the length of 3.
//Notice that the answer must be a substring, "pwke" is a subsequence and not a 
//substring.
// 
//
// 
// Constraints: 
//
// 
// 0 <= s.length <= 10⁵ 
// s consists of English letters, digits, symbols and spaces. 
// 
//
// Related Topics Hash Table String Sliding Window 👍 45898 👎 2250


//leetcode submit region begin(Prohibit modification and deletion)
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int record = 0;
        if (s.Length > 0) {
            record = 1;
        }
        for (int i = 0; i < s.Length; i++) {
            HashSet<char> seen = new HashSet<char>();
            seen.Add(s[i]);


            for (int k = i+1; k < s.Length; k++) {
                if (seen.Contains(s[k])) {
                    break;
                }
                else {
                    seen.Add(s[k]);
                    if (seen.Count > record) {
                        record = seen.Count;
                    }
                }
            }      
        } return record;
    }
}
//leetcode submit region end(Prohibit modification and deletion)
