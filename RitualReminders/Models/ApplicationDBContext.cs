using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RitualReminders.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // added to create the models into the database, 
        // using the Code first Approach for the entity framework

        
        public DbSet<Ritual> Rituals { get; set; }
        public DbSet<Todo> ToDos { get; set; }
        /*
        public DbSet<Inspiration> Inspirations { get; set; }
        public DbSet<InspirationType> InspirationTypes { get; set; }
        public DbSet<RitualFrequency> RitualFrequency { get; set; }*/

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}