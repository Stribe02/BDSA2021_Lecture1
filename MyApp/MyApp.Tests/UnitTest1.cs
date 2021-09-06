using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYearTrue_Divisible_by_4()
        {
            var program = new Program();
            int year1 = 1444;

            var output = program.IsLeapYear(year1);
            Assert.True(output);
        }

        [Fact]
        public void IsLeapYearFalse_Divisible_by_4()
        {
            var notLeapYearProgram = new Program();
            int year2 = 1333;

            var output = notLeapYearProgram.IsLeapYear(year2);
            Assert.False(output);
        }

        [Fact]
        public void LeapYear_Divisble_by_100()
        {
            var notLeapYear100 = new Program();
            var year_divisble_100 = 1700;

            var output = notLeapYear100.IsLeapYear(year_divisble_100);
            Assert.False(output);
            
        }


        [Fact]
        public void LeapYear_Divisible_By_400()
        {
            var leapYear400 = new Program();
            int year_Divisible_400 = 40_000;

            var output = leapYear400.IsLeapYear(year_Divisible_400);
            Assert.True(output);
        }

        [Fact]
        public void Yay_For_LeapYear()
        {
            //Arrange
            var yayProgram = new Program();
            int yayYear = 1444;

            //Act
            var output = false;
            output = yayProgram.IsLeapYear(yayYear);

            //Assert
            Assert.True(output);
        }

        [Fact]
        public void Yay_For_LeapYear_Console()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("1444");
            Console.SetIn(reader);

            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            
            //Assert
            Assert.Equal($"Type in a year:{Environment.NewLine}yay",output);
        }

        [Fact]
        public void Nay_For_Leap_Year_Console()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("1700");
            Console.SetIn(reader);

            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal($"Type in a year:{Environment.NewLine}nay",output);

        }

        [Fact]
        public void Writing_letters_Expection()
        {
            //Arange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("Test");
            Console.SetIn(reader);
            var exception = new FormatException("please type in an integer and not letters or decimals");

            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal($"Type in a year:{Environment.NewLine}please type in an integer and not letters or decimals",output);
        }

        [Fact]
        public void Typing_Year_Earlier_Than_1582()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("Test");
            Console.SetIn(reader);
            var errortext = "The year is earlier than 1582! Please type in a year later than 1582";

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal(errortext, errortext);
        }
    }
}
