using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("31.597099,-84.176122,Taco Bell Albany...", 31.597099)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", 32.571331)]
        [InlineData("33.49763,-86.875722,Taco Bell Birmingham...", 33.49763)]

        public void ShouldParseLatitude(string line, double expected)
        {
            var tacoParser = new TacoParser();

            var actual = tacoParser.Parse(line);

            Assert.Equal(expected, actual.Location.Latitude);
        }
    }

}
