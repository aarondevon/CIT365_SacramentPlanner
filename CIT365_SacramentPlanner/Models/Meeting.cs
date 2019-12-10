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
        [Required]
        public DateTime MeetingDate { get; set; }
        [Required]
        public string Conductor { get; set; }
        [Range(1,341)]
        [Required]
        public int OpeningHymnNumber { get; set; }
        [Range(1, 341)]
        [Required]
        public int SacramentHymnNumber { get; set; }
        [Range(1, 341)]
        public int RestHymnNumber { get; set; }
        [Required]
        public string ClosingHymn { get; set; }
        [Required]
        public string OpeningPrayer { get; set; }
        [Required]
        public string ClosingPrayer { get; set; }
        public string SpeakerOne { get; set; }
        public string SpeakerTwo { get; set; }
        public string SpeakerThree { get; set; }

    }
}
