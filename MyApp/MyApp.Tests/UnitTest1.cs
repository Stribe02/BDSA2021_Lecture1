using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void isLeapYearTrue_Divisible_by_4()
        {
            var program = new Program();
            int year1 = 1444;

            var output = program.isLeapYear(year1);
            Assert.True(output);
        }

        [Fact]
        public void isLeapYearFalse_Divisible_by_4()
        {
            var notLeapYearProgram = new Program();
            int year2 = 1333;

            var output = notLeapYearProgram.isLeapYear(year2);
            Assert.False(output);
        }

        [Fact]
        public void LeapYear_Divisble_by_100()
        {
            var notLeapYear100 = new Program();
            var year_divisble_100 = 1700;

            var output = notLeapYear100.isLeapYear(year_divisble_100);
            Assert.False(output);
            
        }


        [Fact]
        public void LeapYear_Divisible_By_400()
        {
            var leapYear400 = new Program();
            int year_Divisible_400 = 40_000;

            var output = leapYear400.isLeapYear(year_Divisible_400);
            Assert.True(output);
        }
    }
}
