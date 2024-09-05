namespace DiceRoller
{
    public class Die : IRollable
    {
        public int NumberOfSides;

        public Die(int numberOfSides)
        {
            if (numberOfSides < 1)
                throw new ArgumentOutOfRangeException(nameof(numberOfSides));
            NumberOfSides = numberOfSides;
        }

        public int Roll()
        {
            Random random = new();
            return random.Next(1, NumberOfSides+1);
        }
    }
}