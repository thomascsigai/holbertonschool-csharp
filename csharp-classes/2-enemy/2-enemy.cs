using System;

namespace Enemies
{
    ///<summary>Represents a zombie.</summary>
    public class Zombie
    {
        ///<summary>Health number bigger than 0.</summary>
        public int health;

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
    }
}
