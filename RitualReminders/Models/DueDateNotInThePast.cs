using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RitualReminders.Models
{
    public class DueDateNotInThePast : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var todo = (Todo) validationContext.ObjectInstance;

            if (todo.DueDate == null)
                return new ValidationResult("Due Date Cannot be Empty");


            var todayNow = DateTime.Now;

           

            if (todayNow.CompareTo(todo.DueDate)<0)
                return ValidationResult.Success;
            else
            {
                return new ValidationResult("Due Date Cannot be in the past");
            }
            


        }
    }
}