using System;
using System.Collections.Generic;
/// <summary> Class of obj</summary>
class Obj
{
    /// <summary> Class of operations</summary>
    public static bool IsOfTypeInt(object obj){
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        return false;
    }
}
