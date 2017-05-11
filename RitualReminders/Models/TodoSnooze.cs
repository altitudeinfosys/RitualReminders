using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RitualReminders.Models
{
    public class TodoSnooze
    {
        public byte Id { get; set; }
        public string Title { get; set; }
        public byte Hours { get; set; }
    }
}