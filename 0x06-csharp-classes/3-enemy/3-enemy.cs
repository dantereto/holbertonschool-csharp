using System;


namespace Enemies
{
    /// <summary>
    /// Class of enemies
    /// </summary>
    public class Zombie
    {
        /// <summary> Zombie health</summary>
        private int health;
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie(){
            health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                this.health = value;
        }
        /// <summary>Get the health <see cref="Zombie"/> class.</summary>
        public int GetHealth(){
            return this.health;
        }
    }
}