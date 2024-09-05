namespace DiceRoller.Test
{
    [TestClass]
    public class DieFactoryTests
    {
        [TestMethod]
        public void CreateDie_ValidSides_ReturnsCorrectDie()
        {
            // Arrange
            var factory = new DieFactory();

            // Act
            var die6 = factory.CreateDie(6);
            var die20 = factory.CreateDie(20);

            // Assert
            Assert.IsInstanceOfType(die6, typeof(D6));
            Assert.IsInstanceOfType(die20, typeof(D20));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateDie_InvalidSides_ThrowsException()
        {
            // Arrange
            var factory = new DieFactory();

            // Act
            factory.CreateDie(0);
        }
    }
}
