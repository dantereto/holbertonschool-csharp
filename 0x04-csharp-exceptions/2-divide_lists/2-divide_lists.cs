using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int cont = 0;
        List<int> newlist = new List<int>();
        for (int i = 0; i < listLength; i++)
            {
            try{
                cont = list1[i] / list2[i];
                newlist.Add(cont);
            }

            catch (DivideByZeroException){
                Console.WriteLine("Cannot divide by zero");
                newlist.Add(0);
            }
            catch (Exception){
                Console.WriteLine("Out of range");                
            }
        }
        return newlist;
    }
}
