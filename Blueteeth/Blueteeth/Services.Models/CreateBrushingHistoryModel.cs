using System;
using System.Collections.Generic;
using System.Text;

namespace Blueteeth.Services.Models.Account
{
    public class CreateBrushingHistoryModel
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ZoneUL { get; set; }

        public int ZoneDL { get; set; }

        public int ZoneUR { get; set; }

        public int ZoneDR { get; set; }

        public int ZoneM { get; set; }

        public int CorrectMovements { get; set; }
    }
}
