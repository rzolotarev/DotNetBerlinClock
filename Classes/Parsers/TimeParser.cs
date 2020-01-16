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

            return new Time()
            {
                Hours = Int32.Parse(timeParts[0]),
                Minutes = Int32.Parse(timeParts[1]),
                Seconds = Int32.Parse(timeParts[2])
            };
        }
    }
}
