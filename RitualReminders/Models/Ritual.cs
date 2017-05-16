using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RitualReminders.Models
{
    public class Ritual
    {
        public int RitualId { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Ritual Title")]
        public string Title { get; set; }

        [DefaultValue(false)]
        public bool Completed { get; set; }

        public DateTime? DueDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }

        
        public RitualFrequency RitualFrequency { get; set; }

        [Display(Name = "Ritual Frequency")]
        public Byte RitualFrequencyId { get; set; }

        [Display(Name = "User")]
        public ApplicationUser ApplicationUser { get; set; }

        /*
        public ApplicationUser Person { get; set; }
        public int UserId { get; set; }*/

    }
}