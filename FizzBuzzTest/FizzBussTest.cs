using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{
    public class Tests
    {
        [Test]
        public void Return_Fizz_if_number_is_3()
        {
            // Arrange
            // TODO: Add prerequisites or do setup, if any
            var input = 3;

            // Act
            // TODO: Run the system under test
            var actual = FizzBuzzer.convertToFizzBuzz(input);

            // Assert
            // TODO: Make test pass
            Assert.AreEqual("Fizz", actual);
        }
    }
}