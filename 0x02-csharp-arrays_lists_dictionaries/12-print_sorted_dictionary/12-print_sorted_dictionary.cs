using System;
using System.Collections.Generic;
class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> k_list = new List<string>();
        foreach (string data in myDict.Keys)
            k_list.Add(data);
        k_list.Sort();
        foreach (string data in k_list){
            Console.WriteLine("{0}: {1}", data, myDict[data]);
        }

    }
    
}
