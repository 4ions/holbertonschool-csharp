using System;

class Obj
{
    ///<summary> Return true if obj is int and false if is not </summary>
    public static bool IsOfTypeInt(object obj){
        return obj is int;
    }
}
