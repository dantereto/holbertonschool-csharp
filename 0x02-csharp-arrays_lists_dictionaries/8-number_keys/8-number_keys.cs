using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int cont = 0;
        foreach(string key in myDict.Keys)
            cont++;
        return cont;
    }
}