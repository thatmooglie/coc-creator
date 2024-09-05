namespace DiceRoller.Test
{
    [TestClass]
    public class DiceSpecificationTests
    {
        [TestMethod]
        public void Constructor_SetsProperties()
        {
            // Arrange
            int numDice = 2;
            int numSides = 6;
            int modifier = 3;

            // Act
            var spec = new DiceSpecification(numDice, numSides, modifier);

            // Assert
            Assert.AreEqual(numDice, spec.NumberOfDice);
            Assert.AreEqual(numSides, spec.NumberOfSides);
            Assert.AreEqual(modifier, spec.Modifier);
        }
    }
}
