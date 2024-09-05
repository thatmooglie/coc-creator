namespace DiceRoller
{
    public interface IDiceSetFactory
    {
        IDiceSet Create(int numberOfDice, IRollable die);
    }
}
