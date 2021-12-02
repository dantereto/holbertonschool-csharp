using System;
using System.Collections.Generic;
class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int cont = 0;
        foreach(int data in myLList){
            cont += 1;
        }
        return cont;
    }
}
