using System;
    /// <summary>
    /// class obj
    /// </summary>

    class Obj
    {
        /// <summary>
        /// check if obj is int or not
        /// </summary>
        /// <param name="obj"> obj to check</param>
        /// <returns>True or False</returns>
        public static bool IsOfTypeInt(object obj)
        {
            if (obj is int)
                return true;
            else
                return false;
        }
    }

