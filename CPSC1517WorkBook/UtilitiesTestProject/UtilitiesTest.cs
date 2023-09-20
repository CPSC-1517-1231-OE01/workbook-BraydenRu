using FluentAssertions;
using Utils;
namespace UtilitiesTestProject
{
    public class UtilitiesTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(1.0D)]
        [InlineData("1.0")]
        public void Utilities_IsPositive_ReturnsTrueForPositiveValues(object value)
        {
            // Arrange
            bool actual;

            // Act
            if (value.GetType() == typeof(int))
            {
               actual = Utilities.IsPositive((int)value);
            }
            else if (value.GetType() == typeof(double))
            {
               actual = Utilities.IsPositive((double)value);
            }
            else
            {
               actual = Utilities.IsPositive(Convert.ToDecimal(value));
            }
            // Assert
           actual.Should().BeTrue();
        }

        // DateOnly data Generator
        public static IEnumerable<object[]> GenerateIsInTheFutureTestData()
        {
            // Present
            yield return new object[]
            {
                DateOnly.FromDateTime(DateTime.Now),
                false,
            };

            // Past
            yield return new object[]
            {
                DateOnly.FromDateTime(DateTime.Now.AddDays(-1)),
                false,
            };

            // Future
            yield return new object[]
            {
                DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                true,
            };
                
        }
        

        [Theory]
        [MemberData(nameof(GenerateIsInTheFutureTestData))]
        public void Utilities_IsInTheFuture_ReturnsTrueForFutureFalseOtherwise(DateOnly value, bool expected)
        {
            // Arrange
            bool actual;
       
            // Act
            actual = Utilities.IsInFuture(value);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Utilities_IsNullEmptyOrWhiteSpace_ReturnsTrueForNullEmptyOrWhiteSpace(string value)
        {
            // Arrange
            bool actual;
           
            // Act
            actual = Utilities.IsNullEmptyOrWhiteSpace(value);
            

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void Utilities_IsNullEmptyOrWhiteSpace_ReturnsFalseForNonEmpty()
        {
            // Arrange
            bool actual;
            const string GOOD_STRING = "x";

            // Act
            actual = Utilities.IsNullEmptyOrWhiteSpace(GOOD_STRING);

            // Assert
            actual.Should().BeFalse();
        }
    }
}