using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public struct DiceSpecification
    {
        public int NumberOfDice { get; }
        public int NumberOfSides { get; }
        public int Modifier { get; }

        public DiceSpecification(int numberOfDice, int numberOfSides, int modifier)
        {
            NumberOfDice = numberOfDice;
            NumberOfSides = numberOfSides;
            Modifier = modifier;
        }

        public override readonly string ToString() => $"Dice: {NumberOfDice}, sides: {NumberOfSides}, modifier: {Modifier}";
    }
}
