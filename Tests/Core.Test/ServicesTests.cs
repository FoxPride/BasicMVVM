using BasicMVVM.Core.Services;
using Xunit;

namespace Core.Test
{
    public class ServicesTests
    {
        [Fact]
        public void Calculator_Multiply_ReturnMultiplication()
        {
            //Arrange
            var calculator = new CalculatorService();

            //Act
            var result = calculator.Multiply(2, 4);

            //Assert
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(10, 5, 50)]
        [InlineData(7, 4, 28)]
        [InlineData(5, 5, 25)]
        [InlineData(75, 4, 300)]
        public void Calculator_Multiply_ReturnValuesMultiplicationList(double variavel1, double variavel2, double total)
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Multiply(variavel1, variavel2);

            // Assert
            Assert.Equal(total, result);
        }
    }
}