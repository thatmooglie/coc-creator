using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class DiceSetFactory : IDiceSetFactory
    {
        public IDiceSet Create(int numberOfDice, IRollable die)
        {
            return new DiceSet(numberOfDice, die);
        }
    }
}
