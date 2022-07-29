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
/// class Door
/// </summary>
public class Door : Base, IInteractive
{

    /// <summary>
    /// constructor
    /// </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// interact()
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// class Decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// bool isQuestItem
    /// </summary>
    public bool isQuestItem ;
    /// <summary>
    /// int durability
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// durability()
    /// </summary>
    /// <param name="name"></param>
    /// <param name="durability"></param>
    /// <param name="isQuestItem"></param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.durability = durability; 
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// interact()
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"you look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here");
    }

    /// <summary>
    /// break()
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"you hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"you smash the {name}. What a mess.");
        else
            Console.WriteLine($"the {name} is already broken.");
    }
}