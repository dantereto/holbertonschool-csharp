using System;

namespace Text
{
    /// <summary> Class of unique</summary>
    public class Str
    {
        /// <summary> unique number on list</summary>
        public static int UniqueChar(string s)
        {
            bool check;
            for (int i = 0; i < s.Length; i++)
            {
                check = true;
                for (int j = 0; j <s.Length; j++)
                {
                    if (j != i && s[i] == s[j])
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                    return i;
            }
            return -1;
        }
    }
}
