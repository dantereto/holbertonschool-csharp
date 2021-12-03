using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_n = new LinkedListNode<int>(n);
        LinkedListNode<int> node = myLList.First;
        while (node != null)
        {
            if (node.Value > n)
            {
                if (node.Next == null)
                {
                    myLList.AddAfter(node, new_n);
                    break;
                }
                else 
                {
                    myLList.AddBefore(node, new_n);
                    break;
                }
            }
            node = node.Next;
        }
        return (new_n);
    }
}
