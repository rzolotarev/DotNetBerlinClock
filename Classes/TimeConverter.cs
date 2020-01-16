using BerlinClock.Classes.Parsers;
using BerlinClock.Classes.Viewers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            var time = Time.ParseFrom(aTime);

            var hours = BerlinClockViewerFactory.ForHours().GetPresentation(time.Hours);
            var minutes = BerlinClockViewerFactory.ForMinutes().GetPresentation(time.Minutes);
            var seconds = BerlinClockViewerFactory.ForSeconds().GetPresentation(time.Seconds);

            var view = new StringBuilder();
            view.AppendLine(seconds);
            view.AppendLine(hours);
            view.Append(minutes);

            return view.ToString();
        }
    }
}
