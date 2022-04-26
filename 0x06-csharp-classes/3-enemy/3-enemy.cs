using System;

namespace Enemies
{
    /// <summary>
    /// zombie class
    /// </summary>
    class Zombie 
    {
        
        private int health;
        /// <summury> public constructor </summury>
        public Zombie()
        {
            health = 0;
        }
        /// <summury> zombie health checker </summury>
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
        public int GetHealth()
        {
            return this.health;
        }
    }
}
