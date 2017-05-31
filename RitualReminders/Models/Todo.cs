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

        [Required(ErrorMessage = "Todo Title Is Required")]
        [StringLength(255)]
        public string Title { get; set; }

        [DefaultValue(false)]
        public bool Completed { get; set; }

        [Display(Name = "Further Detail")]
        [StringLength(255)]
        public string Detail { get; set; }

        [Required(ErrorMessage = "Your Todo Due Date Is Required")]
        [DueDateNotInThePast]
        [DisplayFormat(DataFormatString =
                "{0:MM/dd/yyyy}",
            ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; }

        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }

        public TodoSnooze TodoSnooze { get; set; }
        [Display(Name = "Snooze ToDo")]
        public byte? TodoSnoozeId { get; set; }

        [Display(Name = "User")]      
        public ApplicationUser ApplicationUser { get; set; }

        

    }
}