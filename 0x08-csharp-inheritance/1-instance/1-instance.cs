using System;
using System.Collections.Generic;
/// <summary> Class of obj</summary>
class Obj
{
    /// <summary> Bool for array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType() == typeof(Array) || obj is Array)
        {
            return true;
        }
        return false;
    }
}
