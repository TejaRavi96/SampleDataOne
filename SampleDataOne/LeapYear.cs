using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataOne
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter the year you want to check:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 || year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine(+year + " is leap year\n");
            }
            else
            {
                Console.WriteLine(+year + " is not a leap year\n");
            }
        }
    }
}