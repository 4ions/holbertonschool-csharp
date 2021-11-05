using System;
///<summary>Class Inventory that inherits from Baseclass</summary>
class Inventory : BaseClass
{
    public User user_id;
    public Item item_id;
    public int quantity = 1;

    public Inventory(string user_id = "none", string item_id = "none", int quantity = 1)
    {
        this.user_id = user_id;
        this.item_id = item_id;
        this.quantity = quantity;
    }
}