using System;

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
class Rectangle : Shape
{
    ///<summary> Private int width </summary>
    private int width;
    ///<summary> Private int height </summary>
    private int height;
    ///<summary> Public property int Width </summary>
    public int Width {

        get {
            return width;
        }
        set {
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
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else {
                height = value;
            }
        }
    }
    ///<summary> override the Area method defined int Shape </summary>
    public new int Area(){
        return height * width;
    }
    ///<summary>Override string ToString method </summary>
    public override string ToString(){
        return $"[Rectangle] {width} / {height}";
    }

}

///<summary> Class Square that inherits from Rectangle </summary>
class Square : Rectangle
{
    ///<summary> Private int size </summary>
    private int size;
    ///<summary> public method to asing size </summary>
    public int Size {
        get {
            return size;
        }
        set {
            if (value < size){
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }
    
    ///<summary>Override string ToString method </summary>
    public override string ToString(){
        return $"[Square] {size} / {size}";
    }
}