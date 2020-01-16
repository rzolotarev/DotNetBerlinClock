using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Parsers
{
    public class Time
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public static Time ParseFrom(string time, char splitter = ':')
        {
            var timeParts = time.Split(splitter);
            if (timeParts.Length != 3)
                throw new ArgumentException("provide correct format of time: hh:mm:ss", time);

            int hours;
            if (!Int32.TryParse(timeParts[0], out hours))
                throw new ArgumentException("provide correct format for hours");

            int minutes;
            if (!Int32.TryParse(timeParts[1], out minutes))
                throw new ArgumentException("provide correct format for minutes");

            int seconds;
            if (!Int32.TryParse(timeParts[2], out seconds))
                throw new ArgumentException("provide correct format for seconds ");

            return new Time()
            {
                Hours = hours,
                Minutes = minutes,
                Seconds = seconds
            };
        }
    }
}
