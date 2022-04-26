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
        /// <summury> zombie health maker </summury>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                this.health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}
