using Microsoft.EntityFrameworkCore;

namespace SocialMediaProject.Data
{
    public class SocialMediaDbContext : DbContext
    {
        public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options) : base(options)
        {

        }
    }
}
