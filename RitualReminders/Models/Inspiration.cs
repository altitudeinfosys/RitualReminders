using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RitualReminders.Models
{
    public class Inspiration
    {
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        public byte? ValidFrom { get; set; }
        public byte? ValidTo { get; set; }

        [DefaultValue("false")]
        public bool Active { get; set; }

        /*public InspirationType InspirationType { get; set; }
        public byte InspirationTypeId { get; set; }*/

    }
}