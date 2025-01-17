using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP.Part_2
{
    public class HiringDate 
    {
        public int Day { get; set; }
        public int Month { get;  set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            if(day < 1 || day > 31)
            throw new ArgumentException("Day must be between 1 and 31.");
            if (month < 1 || month > 12)
                throw new ArgumentException("Month must be between 1 and 12.");
            if (year < 1)
                throw new ArgumentException("Year must be a positive value.");
         
                Day = day;
                Month = month;
                Year = year;
            
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
