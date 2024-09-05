using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller 
{
    public class DiceSet : IDiceSet
    {
        private int numberOfDice = default!;
        private IRollable die = default!;

        public int NumberOfDice { get => numberOfDice; }
        public IRollable Die { get => die; }

        public DiceSet(int numberOfDice, IRollable die)
        {
            if (numberOfDice < 1) throw new ArgumentOutOfRangeException("There must be at least one die.");
            this.numberOfDice = numberOfDice;
            this.die = die;
        }

        public int Roll()
        {
            int total = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                total += die.Roll();
            }
            return total;
        }
    }
}
