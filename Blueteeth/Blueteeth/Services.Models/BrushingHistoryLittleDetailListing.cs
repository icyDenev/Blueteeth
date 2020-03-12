using System;
using System.Collections.Generic;
using System.Text;

namespace Blueteeth.Services.Models.BrushingHistory
{
    public class BrushingHistoryLittleDetailListing
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int AllZones { get; set; } // Sum of all zones' points

        public int CorrectMovements { get; set; }
    }
}
