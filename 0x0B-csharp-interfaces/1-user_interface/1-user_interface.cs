using System;
/// <summary>
/// obstract class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// string name
    /// </summary>
    /// <value></value>
    public string name { get; set; }
    /// <summary>
    /// overide ToString()
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}
/// <summary>
/// interface IIdentifiable
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// interact()
    /// </summary>
    void Interact();
}

/// <summary>
/// interface IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// int
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// method Break()
    /// </summary>
    void Break();
}

/// <summary>
/// interface ICollectable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// bool isCollected
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// collect()
    /// </summary>
    void Collect();
}


/// <summary>
/// test object class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// int durability
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// bool isCollected
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Break()
    /// </summary>
    public void Break()
    {

    }
    /// <summary>
    /// Collect()
    /// </summary>
    public void Collect()
    {

    }
    /// <summary>
    /// Interact()
    /// </summary>
    public void Interact()
    {

    }
}

