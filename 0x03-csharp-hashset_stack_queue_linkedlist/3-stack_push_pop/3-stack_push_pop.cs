using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count <= 0)
            Console.WriteLine("Stack is empty");
        else
        {
            string top_stack = aStack.Peek();
            Console.WriteLine("Top item: {0}", top_stack);
        }
        if (aStack.Contains(search) == true)
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
        }
        else if (aStack.Contains(search) == false)
            Console.WriteLine("Stack contains \"{0}\": False", search);
        if (aStack.Contains(search))
        {
            while(aStack.Contains(search))
            {
                aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
