using System;

namespace Enemies
{
    /// <summary>
    /// zombie class
    /// </summary>
    class Zombie 
    {
        
        private int health;
        private string name = "(No name)";
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

        /// <summury> name setter </summury>
        public string Name
        {
            set { name = value;}
            get { return name;}
        }
        public int GetHealth()
        {
            return this.health;
        }
    }
}
