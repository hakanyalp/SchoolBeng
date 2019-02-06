using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBeng
{
    class Time
    {
        public int hour;
        public int minute;

        public bool monday = true;
        public bool tuesday = true;
        public bool wednesday = true;
        public bool thursday = true;
        public bool friday = true;
        public bool saturday = false;
        public bool sunday = false;

        public bool returnDay(string day)
        {
            if (day == "monday")
                return monday;
            else if (day == "tuesday")
                return tuesday;
            else if (day == "wednesday")
                return wednesday;
            else if (day == "thursday")
                return thursday;
            else if (day == "friday")
                return friday;
            else if (day == "saturday")
                return saturday;
            else if (day == "sunday")
                return sunday;
            else
                return false;
        }
    }
}
