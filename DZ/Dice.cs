using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Dice
    {
        private int _sides;
        private Random random;

        public Dice(int sides = 6)
        {
            this._sides = sides;
            this.random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, _sides + 1);
        }
    }
}
