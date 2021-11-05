using System;
///<summary>Class User that inherits from Baseclass</summary>
public class User : BaseClass
{
    public string name;

    public User(string name = "default")
    {
        this.name = name;
    }

}