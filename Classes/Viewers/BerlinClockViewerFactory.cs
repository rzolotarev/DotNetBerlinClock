using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Viewers
{
    public static class BerlinClockViewerFactory
    {
        public static IBerlinClockViewer ForHours()
        {
            return new HoursViewer();
        }

        public static IBerlinClockViewer ForMinutes()
        {
            return new MinutesViewer();
        }

        public static IBerlinClockViewer ForSeconds()
        {
            return new SecondsViewer();
        }
    }
}
