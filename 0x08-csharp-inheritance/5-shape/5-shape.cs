using System;
using System.Collections.Generic;

///<summary> Class Shape </summary>
class Shape
{
    ///<summary> Throw an error </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}