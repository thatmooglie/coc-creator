using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class DieFactory : IDieFactory
    {
        public IRollable CreateDie(int numSides)
        {
            return numSides switch
            {
                3 => new D3(),
                4 => new D4(),
                6 => new D6(),
                8 => new D8(),
                10 => new D10(),
                12 => new D12(),
                20 => new D20(),
                100 => new D100(),
                _ => new Die(numSides) // Handles custom dice like 5-sided dice
            };
        }
    }
}
