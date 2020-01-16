using BerlinClock.Classes.Viewers.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Viewers
{
    public class BerlinClockMinutesViewer
    {
        private readonly List<Cell> _highRow;
        private readonly List<Cell> _lowRow;
        private const int measure = 5;

        public BerlinClockMinutesViewer()
        {
            _highRow = new List<Cell>() { Cell.Yellow(), Cell.Yellow(), Cell.Red(),
                                          Cell.Yellow(), Cell.Yellow(), Cell.Red(),
                                          Cell.Yellow(), Cell.Yellow(), Cell.Red(),
                                          Cell.Yellow(), Cell.Yellow()
                                        };
            _lowRow = new List<Cell>() { Cell.Yellow(), Cell.Yellow(),
                                         Cell.Yellow(), Cell.Yellow()
                                       };
        }

        public string GetPresentation(int minutes)
        {
            var full5Minutes = minutes / measure;
            var singleMinutes = minutes % measure;

            for (var i = 0; i < full5Minutes; i++)
                _highRow[i].Activate();

            for (var i = 0; i < singleMinutes; i++)
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
