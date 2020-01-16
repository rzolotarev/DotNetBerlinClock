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
            
            var view = new StringBuilder();
            view.AppendLine(BerlinClockViewer.ForSeconds().GetPresentation(time.Seconds));
            view.AppendLine(BerlinClockViewer.ForHours().GetPresentation(time.Hours));
            view.Append(BerlinClockViewer.ForMinutes().GetPresentation(time.Minutes));

            return view.ToString();
        }
    }
}
