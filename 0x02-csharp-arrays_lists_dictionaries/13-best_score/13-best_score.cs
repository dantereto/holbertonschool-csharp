using System;
using System.Collections.Generic;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        string key = "None";
        foreach (KeyValuePair<string, int> data in myList)
        {
            if (data.Value > max)
            {
                max = data.Value;
                key = data.Key;
            }
        }
        return key;
    }
    
}
