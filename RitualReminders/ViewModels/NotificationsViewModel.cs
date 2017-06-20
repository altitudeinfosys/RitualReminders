using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RitualReminders.ViewModels
{
    public class NotificationsViewModel
    {
        public bool ReceiveNewsletter { get; set; }

        public bool ReceiveInspirationalReminders { get; set; }

        public bool ReceiveTextMessagesReminders { get; set; }

        public bool ReceiveEmailReminders { get; set; }

    }
}