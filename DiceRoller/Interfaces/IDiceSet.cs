namespace DiceRoller
{
    public interface IDiceSet
    {
        IRollable Die { get; }
        int NumberOfDice { get; }

        int Roll();
    }
}