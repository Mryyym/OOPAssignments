using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class HiringDate
    {

        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get => _day;
            private set
            {
                if (value < 1 || value > 31)
                {
                    throw new ArgumentException("Day must be between 1 and 31.");
                }
                _day = value;
            }
        }

        public int Month
        {
            get => _month;
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Month must be between 1 and 12.");
                }
                _month = value;
            }
        }

        public int Year
        {
            get => _year;
            private set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException($"Year must be between 1900 and {DateTime.Now.Year}.");
                }
                _year = value;
            }
        }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return string.Format("{0:D2}/{1:D2}/{2}", Day, Month, Year);
        }
    }
}
