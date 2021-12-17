using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            bool check;
            char search = s[0];
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
