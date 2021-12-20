using System;
using System.Collections.Generic;
/// <summary> Class of obj</summary>
class Obj
{
    /// <summary> check sub class</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        return false;
    }
}
