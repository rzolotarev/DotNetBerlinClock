using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Viewers
{
    public static class BerlinClockViewerFactory
    {
        public static BerlinClockHoursViewer ForHours()
        {
            return new BerlinClockHoursViewer();
        }

        public static BerlinClockMinutesViewer ForMinutes()
        {
            return new BerlinClockMinutesViewer();
        }

        public static BerlinClockSecondsViewer ForSeconds()
        {
            return new BerlinClockSecondsViewer();
        }
    }
}
