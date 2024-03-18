namespace TasteFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Email = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        ImageUrl = c.String(),
                        Tel = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Chefs",
                c => new
                    {
                        ChefId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        NameSurname = c.String(),
                    })
                .PrimaryKey(t => t.ChefId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        SendDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Mails",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MailId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsRead = c.String(),
                        NotificationIcon = c.String(),
                        IconCirleColor = c.String(),
                    })
                .PrimaryKey(t => t.NotificationId);
            
            CreateTable(
                "dbo.OpenDayHours",
                c => new
                    {
                        OpenDayHourID = c.Int(nullable: false, identity: true),
                        DayName = c.String(nullable: false, maxLength: 9),
                        OpenHourRange = c.String(maxLength: 9),
                    })
                .PrimaryKey(t => t.OpenDayHourID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        ReservationDate = c.DateTime(nullable: false),
                        Time = c.String(),
                        GuestCount = c.Byte(nullable: false),
                        ReservationStatus = c.String(),
                    })
                .PrimaryKey(t => t.ReservationId);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        ResturantName = c.String(),
                        Title = c.String(),
                        Title2 = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        PlatformName = c.String(),
                        IconUrl = c.String(),
                        RedirectUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        NameSurname = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Testimonials");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Sliders");
            DropTable("dbo.Reservations");
            DropTable("dbo.OpenDayHours");
            DropTable("dbo.Notifications");
            DropTable("dbo.Mails");
            DropTable("dbo.Contacts");
            DropTable("dbo.Chefs");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.Admins");
            DropTable("dbo.Addresses");
            DropTable("dbo.Abouts");
        }
    }
}
