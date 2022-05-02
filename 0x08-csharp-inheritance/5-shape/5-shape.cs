using System;
/// <summary>
/// class Shape
/// </summary>
class Shape
{
    /// <summary>
    /// Throw Error
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}