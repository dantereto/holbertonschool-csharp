using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length){
            Console.Write("Index out of range");
            return -1;
        }
        return array[index];
    }
}

