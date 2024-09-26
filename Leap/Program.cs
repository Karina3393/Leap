namespace Leap
{
    internal class Program
    {
        class LeapYearChecker
        {
           
            public static bool IsLeapYear(int year)
            {
                
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        return year % 400 == 0;
                    }
                    return true;
                }
                return false;
            }

            static void Main(string[] args)
            {
               
                int year1 = 1997; 
                int year2 = 1900; 
                int year3 = 2000;
               
                Console.WriteLine($"Is {year1} a leap year? {IsLeapYear(year1)}"); 
                Console.WriteLine($"Is {year2} a leap year? {IsLeapYear(year2)}"); 
                Console.WriteLine($"Is {year3} a leap year? {IsLeapYear(year3)}"); 
            }
        }
    }
}
