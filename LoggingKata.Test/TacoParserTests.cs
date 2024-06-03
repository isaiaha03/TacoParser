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
        [InlineData("34.376395, -84.913185, Taco Bell Adairsvill...", -84.913185)]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", -86.805275)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", -84.10353)]
        [InlineData("34.280205, -86.217115, Taco Bell Albertvill...", -86.217115)]
        [InlineData("32.92496, -85.961342, Taco Bell Alexander Cit...", -85.961342)]
        [InlineData("34.047374, -84.223918, Taco Bell Alpharetta...", -84.223918)]
        [InlineData("32.072974, -84.222921, Taco Bell Americu...", -84.222921)]
        [InlineData("32.571331, -85.499655, Taco Bell Auburn...", -85.499655)]
        [InlineData("30.903723, -84.556037, Taco Bell Bainbridg...", -84.556037)]
        [InlineData("33.524131, -86.724876, Taco Bell Birmingham...", -86.724876)]
        [InlineData("34.095209, -84.011894, Taco Bell Bufor...", -84.011894)]
        [InlineData("33.648244, -84.011856, Taco Bell Conyers...", -84.011856)]
        [InlineData("33.887468, -84.248611, Taco Bell Doravill...", -84.248611)]
        [InlineData("31.440529, -86.953648, Taco Bell Evergreen...", -86.953648)]
        [InlineData("33.444114, -86.826613, Taco Bell Homewood...", -86.826613)]
        [InlineData("34.872024, -86.571043, Taco Bell Meridianvill...", -86.571043)]
        [InlineData("30.188307, -85.757511, Taco Bell Panama City Beach...", -85.757511)]
        [InlineData("33.796264, -84.224516, Taco Bell Stone Mountain...", -84.224516)]
        [InlineData("33.205302, -87.569628, Taco Bell Tuscaloos...", -87.569628)]
        //DONE: Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            //DONE: Complete the test with Arrange, Act, Assert steps below.
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


        //DONE: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.376395, -84.913185, Taco Bell Adairsvill...", 34.376395)]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", 33.22997)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", 31.570771)]
        [InlineData("34.280205, -86.217115, Taco Bell Albertvill...", 34.280205)]
        [InlineData("32.92496, -85.961342, Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("34.047374, -84.223918, Taco Bell Alpharetta...", 34.047374)]
        [InlineData("32.072974, -84.222921, Taco Bell Americu...", 32.072974)]
        [InlineData("32.571331, -85.499655, Taco Bell Auburn...", 32.571331)]
        [InlineData("30.903723, -84.556037, Taco Bell Bainbridg...", 30.903723)]
        [InlineData("33.524131, -86.724876, Taco Bell Birmingham...", 33.524131)]
        [InlineData("34.095209, -84.011894, Taco Bell Bufor...", 34.095209)]
        [InlineData("33.648244, -84.011856, Taco Bell Conyers...", 33.648244)]
        [InlineData("33.887468, -84.248611, Taco Bell Doravill...", 33.887468)]
        [InlineData("31.440529, -86.953648, Taco Bell Evergreen...", 31.440529)]
        [InlineData("33.444114, -86.826613, Taco Bell Homewood...", 33.444114)]
        [InlineData("34.872024, -86.571043, Taco Bell Meridianvill...", 34.872024)]
        [InlineData("30.188307, -85.757511, Taco Bell Panama City Beach...", 30.188307)]
        [InlineData("33.796264, -84.224516, Taco Bell Stone Mountain...", 33.796264)]
        [InlineData("33.205302, -87.569628, Taco Bell Tuscaloos...", 33.205302)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
