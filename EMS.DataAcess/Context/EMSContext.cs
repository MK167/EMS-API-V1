using EMS.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.Context
{
    public class EMSContext : DbContext
    {
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<College>()
        //    //.HasMany(c => c.FirstEnrollmentForms)
        //    //.WithOne(e => e.FirstCollege)
        //    //.OnDelete(DeleteBehavior.Restrict);
        //}

        public virtual DbSet<EventAttendanceEntity> EventAttendances { get; set; }
        public virtual DbSet<EventCategoryEntity> EventCategories { get; set; }
        public virtual DbSet<EventDetailsEntity> EventDetails { get; set; }
        public virtual DbSet<EventStatusEntity> EventStatuses { get; set; }
        public virtual DbSet<EventVenueEntity> EventVenues { get; set; }
        public virtual DbSet<GenderEntity> Genders { get; set; }
        public virtual DbSet<JobEntity> Jobs { get; set; }
        public virtual DbSet<NationalityEntity> Nationalities { get; set; }
        public virtual DbSet<OrganizerEntity> Organizers { get; set; }
        public virtual DbSet<UniversityEntity> Universities { get; set; }
        public virtual DbSet<UserAdminEntity> UserAdmins { get; set; }
        public virtual DbSet<UserAttendEntity> UserAttends { get; set; }
        public virtual DbSet<UserTypeEntity> UserTypes { get; set; }
        public virtual DbSet<UserImageEntity> UserImages { get; set; }
    }
}
