using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> copy = new Dictionary<string, int>(myDict);
        foreach (var data in myDict){
            copy[data.Key] = data.Value * 2;
        }
        return copy;
    }
}
