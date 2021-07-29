using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Model
{
    class Die
    {
        private readonly int _sides;

        public int GetSides() => _sides;

        public int RolledNumber { get; private set; }

        public Die(int sides)
        {
            _sides = sides;
        }

        public int Roll()
        {
            Random random = new();
            RolledNumber = random.Next(1, GetSides() + 1);
            return RolledNumber;
        }
    }
}
