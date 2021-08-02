using System;

class Obj
{
    ///<summary> True if the object is instance of a class from the specified class </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType){
        return (derivedType.IsSubclassOf(baseType));
    }
}
