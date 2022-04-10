using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CourseWorkSampleAuth.Models;
using CourseWorkSampleAuth.Models.ViewModels;

namespace CourseWorkSampleAuth.DBContext
{
    public class ApplicationDBContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<CourseWorkSampleAuth.Models.ViewModels.UserDetailsViewModel> UserDetailsViewModel { get; set; }
    }
}
