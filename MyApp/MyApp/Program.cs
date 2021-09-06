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
            Console.WriteLine("result: ");
        }

        public bool isLeapYear(int year)
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
