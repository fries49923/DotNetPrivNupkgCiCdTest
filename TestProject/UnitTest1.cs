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
    }
}