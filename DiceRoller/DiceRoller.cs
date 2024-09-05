namespace DiceRoller
{
    public class DiceRoller
    {
        private readonly IDieFactory dieFactory;
        private readonly IDiceSetFactory diceSetFactory;

        public DiceRoller(IDieFactory dieFactory, IDiceSetFactory diceSetFactory)
        {
            this.dieFactory = dieFactory;
            this.diceSetFactory = diceSetFactory;
        }
        public int Roll(string input)
        {
            var specs = ParseInput(input);

            // Create DiceSet and roll the dice
            var die = dieFactory.CreateDie(specs.NumberOfSides);
            var diceSet = diceSetFactory.Create(specs.NumberOfSides, die);
            var result = diceSet.Roll();

            return result + specs.Modifier;
        }

        private DiceSpecification ParseInput(string input)
        {
            // Regex to validate and match the format "XdY+Z".
            var pattern = @"^\s*(\d+)d(\d+)([+-]\d+)?\s*$";
            var regex = new System.Text.RegularExpressions.Regex(pattern);
            var match = regex.Match(input);

            if (!match.Success)
            {
                throw new ArgumentException("Invalid input format. Please use 'XdY+z'.");
            }

            int numDice = int.Parse(match.Groups[1].Value);
            int numSides = int.Parse(match.Groups[2].Value);
            int modifier = match.Groups[3].Success ? int.Parse(match.Groups[3].Value) : 0;

            return new DiceSpecification(numDice, numSides, modifier);

        }
    }
}
