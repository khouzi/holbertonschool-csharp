using System;
/// <summary>
/// obstract class
/// </summary>
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    /// <summary>
    /// override ToString()
    /// <summary>
    {
        return $"{name} is a {GetType().Name}";
    }
}

