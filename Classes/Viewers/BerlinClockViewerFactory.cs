using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Viewers
{
    public static class BerlinClockViewerFactory
    {
        public static IClockViewer ForHours()
        {
            return new HoursViewer();
        }

        public static IClockViewer ForMinutes()
        {
            return new MinutesViewer();
        }

        public static IClockViewer ForSeconds()
        {
            return new SecondsViewer();
        }
    }
}
