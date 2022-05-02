using System;
using System.Collections.Generic;
/// <summary>
/// class obj
/// </summary>

    class Obj
    {
        
        /// <summary>
        /// check if obj insatnce of array or sub
        /// </summary>
        /// <param name="obj">obj to check</param>
        /// <returns> True or  False </returns>
        public static bool IsInstanceOfArray(object obj)
        {
            if (obj is Array || obj.GetType() == typeof(Array))
                return true;
            else
                return false;
        }
    }
