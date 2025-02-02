using Microsoft.EntityFrameworkCore;

namespace NewsWebsiteFinalProject.Models{
    public class NewsWebsiteContext : DbContext{
        public NewsWebsiteContext(DbContextOptions<NewsWebsiteContext> options) : base(options){}

        public DbSet<News> News => Set<News>();
        public DbSet<Category> Categories => Set<Category>();
    }
}