using BerlinClock.Classes.Viewers.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Viewers
{
    public class BerlinClockSecondsViewer
    {
        private readonly Cell cell = Cell.Yellow();

        public string GetPresentation(int seconds)
        {
            if (seconds % 2 == 0)
                cell.Activate();
            
            return cell.Status;
        }
    }
}
