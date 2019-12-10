using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CIT365_SacramentPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public string Conductor { get; set; }
        public string OpeningHymn { get; set; }
        public string SacramentHymn { get; set; }
        public string RestHymn { get; set; }
        public string ClosingHymn { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public string SpeakerOne { get; set; }
        public string SpeakerTwo { get; set; }
        public string SpeakerThree { get; set; }

    }
}
