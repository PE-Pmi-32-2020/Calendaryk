using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using WpfApp.DAL.Entities;

namespace WpfApp.DAL.EF
{
    public class CalendarykContext : DbContext
    {
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Create database if it doesn't exist.
        /// </summary>
        public CalendarykContext(DbContextOptions<CalendarykContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Configure connection string.
        /// </summary>
        /// <param name="optionsBuilder">Service for configuration</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Calendaryk;Trusted_Connection=True;");
        }

        /// <summary>
        /// Configuration for relation one-to-many
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Calendar> calendars = new List<Calendar>
            {
                new Calendar {Id = 1, Title = "Holidays"}
            };

            List<Event> events = new List<Event>()
            {
                new Event
                {
                    EventId = 1, CalendarId = 1, Description = "Description1", StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(2), Notification = DateTime.Now.AddDays(1)
                },

                new Event
                {
                    EventId = 2, CalendarId = 1, Description = "Description2", StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(5), Notification = DateTime.Now.AddDays(2).AddHours(3)
                },

                new Event
                {
                    EventId = 3, CalendarId = 1, Description = "Description3", StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddDays(1).AddMinutes(40), Notification = DateTime.Now.AddDays(5).AddHours(3)
                }
            };

            modelBuilder.Entity<Calendar>().HasMany(value => value.Event).WithOne(value => value.Calendar);
            modelBuilder.Entity<Calendar>().HasData(calendars);
            modelBuilder.Entity<Event>().HasData(events);
        }
    }
}
