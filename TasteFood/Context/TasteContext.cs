﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TasteFood.Entity;

namespace TasteFood.Context
{
    public class TasteContext:DbContext
    {

        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Chef> Chef{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<OpenDayHour> openDayHours { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Notification> Notifications
        { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Mail> Mails { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}