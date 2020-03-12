using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blueteeth.Models
{
    public class BrushingHistory
    {
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int ZoneUL { get; set; }

        [Required]
        public int ZoneDL { get; set; }

        [Required]
        public int ZoneUR { get; set; }

        [Required]
        public int ZoneDR { get; set; }

        [Required]
        public int ZoneM { get; set; }

        [Required]
        public int CorrectMovements { get; set; }
    }
}
