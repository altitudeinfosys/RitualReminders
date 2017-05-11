using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RitualReminders.Models
{
    public class Todo
    {
        public int ToDoId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [DefaultValue(false)]
        public bool Completed { get; set; }

        public DateTime? DueDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }

        public TodoSnooze TodoSnooze { get; set; }
        [Display(Name = "Snooze ToDo")]
        public byte TodoSnoozeId { get; set; }

        

    }
}