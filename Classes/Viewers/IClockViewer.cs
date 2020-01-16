using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Viewers
{
    public interface IClockViewer
    {
        string GetPresentation(int timePart);
    }
}
