using System;

namespace BerlinClock.Classes.Viewers.Cells
{

    public class Cell
    {
        private readonly CellStatus _inactiveStatus;
        private readonly CellStatus _activeStatus;

        private CellStatus status { get; set; }

        public string Status => status.ToString();

        public static Cell Yellow()
        {
            return new Cell(CellStatus.O, CellStatus.Y);
        }

        public static Cell Red()
        {
            return new Cell(CellStatus.O, CellStatus.R);
        }

        public Cell(CellStatus inactiveStatus, CellStatus activeStatus)
        {
            _inactiveStatus = inactiveStatus;
            _activeStatus = activeStatus;
            status = _inactiveStatus;
        }

        public void Activate()
        {
            status = _activeStatus;
        }
    }
}