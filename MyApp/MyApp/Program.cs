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
            var program = new Program();
            Console.WriteLine("Type in a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            program.IsLeapYear(year);
            if(program.leapYear == true)
            {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
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
