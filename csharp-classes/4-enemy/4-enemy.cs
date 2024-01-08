using System;

namespace Enemies
{
    ///<summary>Represents a zombie.</summary>
    public class Zombie
    {
        ///Health number bigger than 0.
        private int health;
        private string name = "(No name)";

        ///<summary>Gets or sets the zombie's name.</summary>
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        ///<summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            this.health = 0;
        }

        ///<summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        ///<param name="value">The instantiated zombie health greater than or equal 0.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                this.health = 0;
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            } 
        }

        ///<summary>Gets the Zombie's health.</summary>
        ///<returns>The value of health field</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
