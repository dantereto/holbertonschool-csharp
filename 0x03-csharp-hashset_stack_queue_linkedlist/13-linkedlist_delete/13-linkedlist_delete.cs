using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> del = myLList.First;
        for (int i = 0; i < index && del.Next != null; i++)
            del = del.Next;
        if (index == index)
            myLList.Remove(del); 
    }
}
