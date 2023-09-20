using FluentAssertions;
using Hockey.Data;
namespace Hockey.Test
{
    
    public class HockeyPlayerTest
    {
        public HockeyPlayer GenerateTestPlayer()
        {
            return new HockeyPlayer();

        }

        [Fact]
        public void HockeyPlayer_FirstName_ReturnsGoodFirstName()
        {
            // Arrange
            HockeyPlayer player = GenerateTestPlayer();
            player.FirstName = "test";

            // Act
            string actual = player.FirstName;

            // Assert
            actual.Should().Be("test");
        }


        [Fact]
        public void Test1()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int actual;

            //Act
            actual = a + b;

            //Assert
           actual.Should().Be(3);
        }

        [Fact]
        public void HockeyPlayer_FirstName_ThrowsExceptionForEmptyArg()
        {
            // Arrange
            HockeyPlayer player = GenerateTestPlayer();
            const string EMPTY_NAME = "";

            // Act
            Action action = () => player.FirstName = "";

            // Assert
            action.Should().Throw<ArgumentException>().WithMessage("First name cannot be left blank");
        }
        
        
    }
}