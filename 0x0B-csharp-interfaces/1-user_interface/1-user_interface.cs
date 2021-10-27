using System;
// <summary>
/// Ineterface Interactive
/// </summary>
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