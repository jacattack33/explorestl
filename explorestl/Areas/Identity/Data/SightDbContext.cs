using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ObjectPool;
using explorestl.Models;

namespace explorestl.Areas.Identity.Data;

public class SightDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
{
    
    public DbSet<Review> Reviews { get; set; }
    public DbSet<UserSightFavorite> UserSightFavorites { get; set; }
    public DbSet<Entity> Entities { get; set; }


    //  public DbSet<WeirdRating> WeirdRatings { get; set; }

    public SightDbContext(DbContextOptions<SightDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //import csv and import
        using (var reader = new StreamReader("Areas/Identity/Data/entities.csv"))
        {
            List<Entity> entities = new List<Entity>();
            int i = 1;
            while (!reader.EndOfStream)
            {
                Console.WriteLine("Line " + i);
                var line = reader.ReadLine();
                var values = line.Split(',');
                Console.WriteLine("Values " + values[0]);


                var Name = values[0];
                var City = values[1];
                var State = values[2];
                var description = values[3];
                var type = values[4];


                entities.Add(new Entity(Name,City,State, description, type));
                i++;
            }

            builder.Entity<Entity>().HasData(entities);
        }
  
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

}


