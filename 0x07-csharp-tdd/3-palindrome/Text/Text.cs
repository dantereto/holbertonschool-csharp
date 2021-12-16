using System;

namespace Text
{
    /// <summary> Class of text</summary>
    public class Str
    {
        /// <summary> Check if its a palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return true;
            string first = s.Substring(0, s.Length / 2);
            char[] array = s.ToCharArray();

            Array.Reverse(array);

            string temp = new string(array);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
