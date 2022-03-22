using System;
class Queue<T>
{
    Node head = null;
    Node tail = null;
    int count = 0;
    public Type CheckType()
    {
        return typeof(T);
    }
    public class Node
    {
        public object value = null;
        public Node next = null;
        public object Value{
            get { return value; }
            set { this.value = value; }
        }
    }
    public void Enqueue(T value)
    {
        Node node = new Node();
        node.Value = value;

        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
    }
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node temp = head;
        head = head.next;
        count--;
        return (T)temp.value;
    }
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node temp = head;
        return (T)temp.value;
    }
    public T Print()
    {
        Node load = head;
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        while (load != null)
        {
            Console.WriteLine(load.Value);
            load = load.next;
        };
        return default(T);
    }
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char)) {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        string load = "";
        Node copy = head;
        for (int i = 0; i < count; i ++) {
            load += copy.value;
            copy = copy.next;
        }
        return (load);
    }
    public int Count()
    {
        return (count);
    }
}