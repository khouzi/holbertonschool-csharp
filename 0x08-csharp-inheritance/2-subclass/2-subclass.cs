using System;
using System.Collections.Generic;
    /// <summary>
    /// class obj
    /// </summary>

class Obj
{
    /// <summary>
    /// return if true if item is instance or subclass false if not or instance of base class
    /// </summary>
    /// <param name="derivedType">Type to check</param>
    /// <param name="baseType">Type to check with </param>
    /// <returns>True or false</returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsInstanceOfType(baseType) == true)
            return false;
        else if (derivedType.IsSubclassOf(baseType) == true)
            return true;
        else
            return false;
    }
}