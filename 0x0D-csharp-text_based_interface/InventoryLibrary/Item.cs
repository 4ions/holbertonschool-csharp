using System;
using System.Collections.Generic;

///<summary>Class Item that inherits from Baseclass</summary>
class Item : BaseClass
{
    public string name;
    public string description;
    public float price;
    public List<string> tags;

    public Item(string name = "name", string description = "description", float price = 0.0f, List<string> tags = "tags")
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.List<string> = tags;
    }

}