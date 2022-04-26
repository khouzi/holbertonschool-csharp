using System;

namespace Enemies
{
    /// <summary>
    /// zombie class
    /// </summary>
    class Zombie 
    {
        public int health;

        /// <summury> public constructor </summury>
        public Zombie()
        {
            health = 0;
        }
        /// <summury> zombie health checker </summury>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater tahn or equal to 0");
            }
        }
    }
}
