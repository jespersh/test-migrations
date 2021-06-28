using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFGetStarted
{
public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingContext>
{
    public BloggingContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
        optionsBuilder.UseMySql(new MySqlServerVersion(new System.Version(8, 0, 21)));

        return new BloggingContext(optionsBuilder.Options);
    }
}
}