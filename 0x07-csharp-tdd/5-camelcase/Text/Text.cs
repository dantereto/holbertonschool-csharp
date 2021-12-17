using System;

namespace Text
{
    /// <summary> Class of Text</summary>
    public class Str
    {
        /// <summary> Count the camelcase</summary>
        public static int CamelCase(string s)
        {
            int count = 1;
            if (s == null)
                return null;
            for (int i = 1; i < s.Length - 1; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                        count++;
            }
            return count;
        }
    }
}
