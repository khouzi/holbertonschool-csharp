using System;
/// <summary>
/// obstract class
/// </summary>
abstract class Base
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{Name} is a {GetType().Name}";
    }
}

