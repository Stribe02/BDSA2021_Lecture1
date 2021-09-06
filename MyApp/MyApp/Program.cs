using System;

namespace MyApp
{
    public class Program
    {
        private bool leapYear;

        public Program(){
            leapYear = false;
        }


        public static void Main(string[] args)
        {
            try{
            var program = new Program();
            Console.WriteLine("Type in a year:");
                int year = Convert.ToInt32(Console.ReadLine());
            program.IsLeapYear(year);
            if(year > 1582){
            if(program.leapYear == true)
            {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
            } else {
                Console.WriteLine("The year is earlier than 1582! Please type in a year later than 1582");
            }
            } catch (FormatException){
                Console.WriteLine("please type in an integer and not letters or decimals");
            }
        }

        public bool IsLeapYear(int year)
    {
        if(year % 4 == 0)
        {
            if(year % 100 == 0)
            {
                leapYear = false;
                if(year % 400 == 0){
                    leapYear = true;
                }
            } else 
            {
                leapYear = true;
            }
        }
        return leapYear;
    }
    }
}
