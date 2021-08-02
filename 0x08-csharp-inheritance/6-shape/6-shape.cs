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

///<summary> Class rectangle that inherits from Shape </summary>
class Rectangle : Shape{
    ///<summary> Private int width </summary>
    private int width;
    ///<summary> Private int height </summary>
    private int height;
    ///<summary> Public property int Width </summary>
    public int Width {

        get{
            return width;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else {
                width = value;
            }
        }
    }
    ///<summary> Public property int Height </summary>
    public int Height {
        get {
            return height;
        }
        set {
            if (value < 0){
                throw new ArgumentException("Height must be greater that or equal to 0");
            }
            else {
                height = value;
            }
        }
    }

}