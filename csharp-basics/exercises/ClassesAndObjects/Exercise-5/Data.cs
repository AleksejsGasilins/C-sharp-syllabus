using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public class Data
    {
        private int _month;
        private int _day;
        private int _year;

        public Data(int month,int day,int year)
        {
            _month = month;
            _day = day;
            _year = year;
        }

        public int GetMonth()
        {
            return _month;
        }

        public int GetDay()
        {
            return _day;
        }

        public int GetYear()
        {
            return _year;
        }

        public void SetMonth(int month)
        {
            _month = month;
        }

        public void SetDay(int day)
        {
            _day = day;
        }

        public void SetYear(int year)
        {
            _year = year;
        }

        public void DisplayDate()
        {
            Console.Write($"{GetMonth()}/{GetDay()}/{GetYear()}\n");
        }
    }
}
