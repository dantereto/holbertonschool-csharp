using System;
using System.Collections.Generic;
using System.Reflection;
/// <summary> Class of obj</summary>

class Obj
{
    /// <summary> Print info</summary>

    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
        
    }
}
