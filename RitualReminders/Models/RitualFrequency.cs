using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RitualReminders.Models
{
    public class RitualFrequency
    {
        public byte RitualFrequencyId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public byte Hours { get; set; }
    }
}