using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RitualReminders.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool ReceiveNewsletter { get; set; }
        public bool ReceiveInspirationalReminders { get; set; }
        public bool ReceiveTextMessagesReminders { get; set; }
        public bool ReceiveEmailReminders { get; set; }

        /*
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        public ReportType ReportType { get; set; }
        public byte ReportTypeId { get; set; }*/


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

}