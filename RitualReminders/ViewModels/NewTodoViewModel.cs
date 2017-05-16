using System.Collections;
using System.Collections.Generic;
using RitualReminders.Models;

namespace RitualReminders.ViewModels
{
    public class NewTodoViewModel
    {
        public IEnumerable<TodoSnooze> TodoSnoozes { get; set; }
        public Todo Todo { get; set; }

    }
}