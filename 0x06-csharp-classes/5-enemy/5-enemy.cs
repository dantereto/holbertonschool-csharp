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
        /// <summary> Zombie name</summary>
        private string name = "(No name)";
        /// <summary> Zombie name</summary>
        public string Name { 
            get { return name; }
            set { name = value; }
        }
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
        /// <summary>ToString <see cref="Zombie"/> class.</summary>
        public override string ToString(){
            return ($"Zombie Name: {name} / Total Health: {health}");
        }
    }
}