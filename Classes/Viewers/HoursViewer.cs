using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerlinClock.Classes.Viewers.Cells;

namespace BerlinClock.Classes.Viewers
{
    public class HoursViewer : IBerlinClockViewer
    {
        private readonly List<Cell> _highRow;
        private readonly List<Cell> _lowRow;

        private const int measure = 5;

        public HoursViewer()
        {
            _highRow = new List<Cell>() { Cell.Red(), Cell.Red(), Cell.Red(), Cell.Red() };
            _lowRow = new List<Cell>() { Cell.Red(), Cell.Red(), Cell.Red(), Cell.Red() };
        }

        public string GetPresentation(int hours)
        {
            var measuredHours = hours / measure;
            var singleHours = hours % measure;

            for (var i = 0; i < measuredHours; i++)
                _highRow[i].Activate();

            for (var i = 0; i < singleHours; i++)
                _lowRow[i].Activate();

            return CollectColors();
        }

        private string CollectColors()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Join("", _highRow.Select(c => c.Status)));
            builder.Append(string.Join("", _lowRow.Select(c => c.Status)));
            return builder.ToString();
        }
    }
}
