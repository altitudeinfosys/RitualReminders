using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RitualReminders.Models;

namespace RitualReminders.Dtos
{
    public class TodoDto
    {
        public int ToDoId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [DefaultValue(false)]
        public bool Completed { get; set; }

       
        [StringLength(255)]
        public string Detail { get; set; }

        [DisplayFormat(DataFormatString =
                "{0:MM/dd/yyyy}",
            ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; }

        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }

       
        [Display(Name = "Snooze ToDo")]
        public byte? TodoSnoozeId { get; set; }

        [Display(Name = "User")]
        public ApplicationUser ApplicationUser { get; set; }



    }

}