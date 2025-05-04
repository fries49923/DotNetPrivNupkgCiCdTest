using DotNetPrivNupkgCiCdTest;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Square_ReturnsCorrectResult1()
        {
            // Arrange
            var mathHelper = new MathHelper();

            // Act
            var result = mathHelper.Square(5);

            // Assert
            Assert.Equal(25, result);
        }

        [Theory]
        [InlineData(5, 25)]
        [InlineData(2, 4)]
        [InlineData(0, 0)]
        [InlineData(-2, 4)]
        public void Square_ReturnsCorrectResult2(int input, int expected)
        {
            // Arrange
            var mathHelper = new MathHelper();

            // Act
            var result = mathHelper.Square(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            var mathHelper = new MathHelper();

            // Act
            var result = mathHelper.Add(4, 5);

            // Assert
            Assert.Equal(9, result);
        }
    }
}