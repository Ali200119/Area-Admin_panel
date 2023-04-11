using System;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Models;

namespace PurpleBuzz.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Service> Services { get; set; }
        public DbSet<SliderBackground> SliderBackgrounds { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkImage> WorkImages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Offer> Offers { get; set; }




        #region Data Seeding

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<SliderBackground>().HasData(
        //        new SliderBackground { Id = 1, Image = "banner-bg-01.jpg", SoftDelete = false}
        //    );

        //    modelBuilder.Entity<Slider>().HasData(
        //        new Slider { Id = 1, IsActive = "active", Title = "Develop <strong>Strategies</strong> for <br>your business", Description = "Purple Buzz is a corporate HTML template with Bootstrap 5 Beta 1. This CSS template is 100% free to download provided by <a rel=\"nofollow\" href=\"https://templatemo.com/page/1\" target=\"_parent\">TemplateMo</a>. Total 6 HTML pages included in this template. Icon fonts by <a rel=\"nofollow\" href=\"https://boxicons.com/\" target=\"_blank\">Boxicons</a>. Photos are from <a rel=\"nofollow\" href=\"https://unsplash.com/\" target=\"_blank\">Unsplash</a> and <a rel=\"nofollow\" href=\"https://icons8.com/\" target=\"_blank\">Icons 8</a>.", SoftDelete = false },
        //        new Slider { Id = 2, IsActive = "deactive", Title = "HTML CSS Template with Bootstrap 5 Beta 1", Description = "You are not allowed to re-distribute this Purple Buzz HTML template as a downloadable ZIP file on any kind of Free CSS collection websites. This is strongly prohibited. Please contact TemplateMo for more information.", SoftDelete = false },
        //        new Slider { Id = 3, IsActive = "deactive", Title = "Cupidatat non proident, sunt in culpa qui officia", Description = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat.", SoftDelete = false }
        //    );

        //    modelBuilder.Entity<Service>().HasData(
        //        new Service { Id = 1, Title = "Make Success for future", Description = "You are free to use this template for your commercial or business websites. You are not allowed to re-distribute this template ZIP file on any template collection websites. It is too easy to illegally copy and repost this template.", SoftDelete = false}
        //    );

        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { Id = 1, Name = "Graphics", Filter = "graphic", SoftDelete = false },
        //        new Category { Id = 2, Name = "UI/UX", Filter = "ui", SoftDelete = false },
        //        new Category { Id = 3, Name = "Branding", Filter = "branding", SoftDelete = false }
        //    );

        //    modelBuilder.Entity<Work>().HasData(
        //        new Work { Id = 1, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 2 },
        //        new Work { Id = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 1 },
        //        new Work { Id = 3, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 3 },
        //        new Work { Id = 4, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 1 },
        //        new Work { Id = 5, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 2 },
        //        new Work { Id = 6, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 3 },
        //        new Work { Id = 7, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 2 },
        //        new Work { Id = 8, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing", IsRecent = false, SoftDelete = false, CategoryId = 1 },
        //        new Work { Id = 9, Description = "Ullamco laboris nisi ut aliquip ex", IsRecent = true, SoftDelete = false, CategoryId = 1 },
        //        new Work { Id = 10, Description = "Psum officia anim id est laborum.", IsRecent = true, SoftDelete = false, CategoryId = 2 },
        //        new Work { Id = 11, Description = "Sum dolor sit consencutur", IsRecent = true, SoftDelete = false, CategoryId = 3 },
        //        new Work { Id = 12, Description = "Lorem ipsum dolor sit amet", IsRecent = true, SoftDelete = false, CategoryId = 3 },
        //        new Work { Id = 13, Description = "Put enim ad minim veniam", IsRecent = true, SoftDelete = false, CategoryId = 2 },
        //        new Work { Id = 14, Description = "Mollit anim id est laborum.", IsRecent = true, SoftDelete = false, CategoryId = 1 }
        //    );

        //    modelBuilder.Entity<WorkImage>().HasData(
        //        new WorkImage { Id = 1, Name = "services-01.jpg", IsMain = true, SoftDelete = false, WorkId = 1 },
        //        new WorkImage { Id = 2, Name = "services-06.jpg", IsMain = false, SoftDelete = false, WorkId = 1 },
        //        new WorkImage { Id = 3, Name = "services-02.jpg", IsMain = true, SoftDelete = false, WorkId = 2 },
        //        new WorkImage { Id = 4, Name = "services-04.jpg", IsMain = false, SoftDelete = false, WorkId = 2 },
        //        new WorkImage { Id = 5, Name = "services-03.jpg", IsMain = true, SoftDelete = false, WorkId = 3 },
        //        new WorkImage { Id = 6, Name = "services-01.jpg", IsMain = false, SoftDelete = false, WorkId = 3 },
        //        new WorkImage { Id = 7, Name = "services-04.jpg", IsMain = true, SoftDelete = false, WorkId = 4 },
        //        new WorkImage { Id = 8, Name = "services-08.jpg", IsMain = false, SoftDelete = false, WorkId = 4 },
        //        new WorkImage { Id = 9, Name = "services-05.jpg", IsMain = true, SoftDelete = false, WorkId = 5 },
        //        new WorkImage { Id = 10, Name = "services-02.jpg", IsMain = false, SoftDelete = false, WorkId = 5 },
        //        new WorkImage { Id = 11, Name = "services-06.jpg", IsMain = true, SoftDelete = false, WorkId = 6 },
        //        new WorkImage { Id = 12, Name = "services-08.jpg", IsMain = false, SoftDelete = false, WorkId = 6 },
        //        new WorkImage { Id = 13, Name = "services-07.jpg", IsMain = true, SoftDelete = false, WorkId = 7 },
        //        new WorkImage { Id = 14, Name = "services-03.jpg", IsMain = false, SoftDelete = false, WorkId = 7 },
        //        new WorkImage { Id = 15, Name = "services-08.jpg", IsMain = true, SoftDelete = false, WorkId = 8 },
        //        new WorkImage { Id = 16, Name = "services-05.jpg", IsMain = false, SoftDelete = false, WorkId = 8 },
        //        new WorkImage { Id = 17, Name = "recent-work-01.jpg", IsMain = true, SoftDelete = false, WorkId = 9 },
        //        new WorkImage { Id = 18, Name = "recent-work-03.jpg", IsMain = false, SoftDelete = false, WorkId = 9 },
        //        new WorkImage { Id = 19, Name = "recent-work-02.jpg", IsMain = true, SoftDelete = false, WorkId = 10 },
        //        new WorkImage { Id = 20, Name = "recent-work-01.jpg", IsMain = false, SoftDelete = false, WorkId = 10 },
        //        new WorkImage { Id = 21, Name = "recent-work-03.jpg", IsMain = true, SoftDelete = false, WorkId = 11 },
        //        new WorkImage { Id = 22, Name = "recent-work-05.jpg", IsMain = false, SoftDelete = false, WorkId = 11 },
        //        new WorkImage { Id = 23, Name = "recent-work-04.jpg", IsMain = true, SoftDelete = false, WorkId = 12 },
        //        new WorkImage { Id = 24, Name = "recent-work-02.jpg", IsMain = false, SoftDelete = false, WorkId = 12 },
        //        new WorkImage { Id = 25, Name = "recent-work-05.jpg", IsMain = true, SoftDelete = false, WorkId = 13 },
        //        new WorkImage { Id = 26, Name = "recent-work-03.jpg", IsMain = false, SoftDelete = false, WorkId = 13 },
        //        new WorkImage { Id = 27, Name = "recent-work-06.jpg", IsMain = true, SoftDelete = false, WorkId = 14 },
        //        new WorkImage { Id = 28, Name = "recent-work-01.jpg", IsMain = false, SoftDelete = false, WorkId = 14 }
        //    );

        //    modelBuilder.Entity<About>().HasData(
        //        new About { Id = 1, Title = "About Us", Description = "Vector illustration credit goes to <a rel=\"nofollow\" href=\"http://freepik.com/\" target=\"_blank\">FreePik</a> website. Purple Buzz is provided by TemplateMo. Lorem ipsum dolor sit amet, consectetur.", BackgroundImage = "banner-img-02.svg", SoftDelete = false }
        //    );

        //    modelBuilder.Entity<Team>().HasData(
        //        new Team { Id = 1, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", SoftDelete = false }
        //    );

        //    modelBuilder.Entity<TeamMember>().HasData(
        //        new TeamMember { Id = 1, Image = "team-01.jpg", FullName = "John Doe", Postiton = "Business Development", SoftDelete = false, TeamId = 1 },
        //        new TeamMember { Id = 2, Image = "team-02.jpg", FullName = "Jane Doe", Postiton = "Media Development", SoftDelete = false, TeamId = 1 },
        //        new TeamMember { Id = 3, Image = "team-03.jpg", FullName = "Sam", Postiton = "Developer", SoftDelete = false, TeamId = 1 }
        //    );

        //    modelBuilder.Entity<Contact>().HasData(
        //        new Contact { Id = 1, Title = "Contact", Subtitle = "Elit, sed do eiusmod tempor", Description = "Vector illustration is from <a rel=\"nofollow\" href=\"https://storyset.com/\" target=\"_blank\">StorySet</a>. Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida.", BackgroundImage = "banner-img-01.svg", SoftDelete = false }
        //    );

        //    modelBuilder.Entity<Package>().HasData(
        //        new Package { Id = 1, Name = "Free Plan", Price = 0, BackgroundColor = "white", IconColor = "text-secondary", TextColor = "black", CardHeight = "pb-5 mt-5", ButtonOutline = "primary", SoftDelete = false },
        //        new Package { Id = 2, Name = "Standart Plan", Price = 120, BackgroundColor = "bg-secondary", IconColor = "text-white", TextColor = "text-white", CardHeight = "pt-3", ButtonOutline = "light", SoftDelete = false },
        //        new Package { Id = 3, Name = "Enterprise", Price = 840, BackgroundColor = "white", IconColor = "text-secondary", TextColor = "black", CardHeight = "pb-5 mt-5", ButtonOutline = "primary", SoftDelete = false }
        //    );

        //    modelBuilder.Entity<Offer>().HasData(
        //        new Offer { Id = 1, Description = "5 Users", PackageId = 1, SoftDelete = false },
        //        new Offer { Id = 2, Description = "2 TB Space", PackageId = 1, SoftDelete = false },
        //        new Offer { Id = 3, Description = "Community Forums", PackageId = 1, SoftDelete = false },
        //        new Offer { Id = 4, Description = "Email Support", PackageId = 1, SoftDelete = false },
        //        new Offer { Id = 5, Description = "25 to 99 Users", PackageId = 2, SoftDelete = false },
        //        new Offer { Id = 6, Description = "10 TB space", PackageId = 2, SoftDelete = false },
        //        new Offer { Id = 7, Description = "Source Files", PackageId = 2, SoftDelete = false },
        //        new Offer { Id = 8, Description = "Live Chat", PackageId = 2, SoftDelete = false },
        //        new Offer { Id = 9, Description = "100 users or more", PackageId = 3, SoftDelete = false },
        //        new Offer { Id = 10, Description = "80 TB space", PackageId = 3, SoftDelete = false },
        //        new Offer { Id = 11, Description = "Full Access Sources", PackageId = 3, SoftDelete = false },
        //        new Offer { Id = 12, Description = "Customizations", PackageId = 3, SoftDelete = false }
        //    );
        //}

        #endregion
    }
}