namespace DiceRoller
{
    public interface IDieFactory
    {
        IRollable CreateDie(int numSides);
    }
}
