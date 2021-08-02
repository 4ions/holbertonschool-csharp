using System;
using System.Collections.Generic;

class Obj {
    /// <summary> returns True if the object is an instance of, or return False</summary>
    public static bool IsInstanceOfArray(object obj){
        return (typeof(Array).IsInstanceOfType(obj));
    }

}
