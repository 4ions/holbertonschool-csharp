using System;
// <summary>
/// Ineterface Interactive
/// </summary>

public abstract class Base
{
    /// <summary>
    /// Name property
    /// </summary>
    /// <value>string value</value>
    private string name {
        get;
        set;
    }
    /// <summary>
    /// Override tostring() method
    /// </summary>
    /// <returns>string</returns>

    public override string ToString()
    {
        return ($"{this.name} is a {this.GetType()}");
    }
}

interface IInteractive
{
    void Interact();
}
/// <summary>
/// Interface IBreakable
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}
/// <summary>
/// Interface Collectable
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}
/// <summary>
/// Test object class
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    public string name { get; set; }
    /// <summary>
    /// Interact inmplementation
    /// </summary>
    public void Interact()
    {

    }
    /// <summary>
    /// Break implementation
    /// </summary>
    public void Break()
    {

    }
    // <summary>
    /// isCollected
    /// </summary>
    /// <value>bool value</value>
    public void Collect()
    {

    }
}