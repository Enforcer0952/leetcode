//Given a string s, return the longest palindromic substring in s. 
//
// 
// Example 1: 
//
// 
//Input: s = "babad"
//Output: "bab"
//Explanation: "aba" is also a valid answer.
// 
//
// Example 2: 
//
// 
//Input: s = "cbbd"
//Output: "bb"
// 
//
// 
// Constraints: 
//
// 
// 1 <= s.length <= 1000 
// s consist of only digits and English letters. 
// 
//
// Related Topics Two Pointers String Dynamic Programming Manacher 👍 33256 👎 2
//040
namespace Problem5;

//leetcode submit region begin(Prohibit modification and deletion)
public class Solution
{
    public string LongestPalindrome(string s)
    {
        string Palindrome = "";
        for (int F = 0; F < s.Length; F++)
        {
            for (int L = s.Length - 1; L >= F; L--)
            {
                if ( L == F )
                {
                    if (Palindrome.Length == 0)
                    {
                        Palindrome += s[L];
                    } 
                    break;
                }
                else if (s[L] != s[F])
                {
                    continue;
                }
                else
                {
                  bool isit = CheckifPalindrome(s, F, L);
                  if (isit && L - F + 1 > Palindrome.Length)
                  {
                      Palindrome = s.Substring(F, L - F + 1);
                  }
                }
            }
        }
        return Palindrome;
    }

    public bool CheckifPalindrome(string s, int F, int L)
    {
        if (F >= L) return true; 
        bool isit;
        if (s[L] == s[F])
        {
            isit = CheckifPalindrome(s, F + 1, L - 1);
        }
        else
        {
            return false;
        }

        return isit;
    }
    
}
//leetcode submit region end(Prohibit modification and deletion)