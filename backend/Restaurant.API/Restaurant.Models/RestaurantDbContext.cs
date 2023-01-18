using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models;

public partial class RestaurantDbContext : DbContext, IContext
{
    public RestaurantDbContext()
    {
    }

    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cuisine> Cuisines { get; set; }

    public DbSet<Grade> Grades { get; set; }

    public DbSet<Menu> Menus { get; set; }

    public DbSet<Restaurants> Restaurants { get; set; } = null!;

    public DbSet<Score> Scores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:pisithserver.database.windows.net,1433;Initial Catalog=RestaurantDB;Persist Security Info=False;User ID=pisiths;Password=BlueBird12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cuisine>(entity =>
        {
            entity.HasKey(e => e.cuisine_id).HasName("PK__Cuisine__3197C6F473F6C46D");

            entity.ToTable("Cuisine");

            entity.Property(e => e.cuisine_id).HasColumnName("cuisine_id");
            entity.Property(e => e.cuisine_type)
                .HasMaxLength(50)
                .HasColumnName("cuisine_type");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.grade_id).HasName("PK__Grade__3A8F732C8B9F07BF");

            entity.ToTable("Grade");

            entity.Property(e => e.grade_id).HasColumnName("grade_id");
            entity.Property(e => e.grade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("grade");
            entity.Property(e => e.grade_date)
                .HasColumnType("date")
                .HasColumnName("grade_date");
            entity.Property(e => e.rest_gradeid).HasColumnName("rest_gradeid");

            entity.HasOne(d => d.RestGrade).WithMany(p => p.Grades)
                .HasForeignKey(d => d.rest_gradeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grade__rest_grad__08B54D69");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.dish_id).HasName("PK__Menu__9F2B4CF9ACBBE656");

            entity.ToTable("Menu");

            entity.Property(e => e.dish_id).HasColumnName("dish_id");
            entity.Property(e => e.cuisine_rest).HasColumnName("cuisine_rest");
            entity.Property(e => e.dish)
                .HasMaxLength(50)
                .HasColumnName("dish");
            entity.Property(e => e.price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");

            entity.HasOne(d => d.CuisineRestNavigation).WithMany(p => p.Menus)
                .HasForeignKey(d => d.cuisine_rest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Menu__cuisine_re__02FC7413");
        });

        modelBuilder.Entity<Restaurants>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Restaura__3213E83F53D5CB01");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.city)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.state)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("state");

            entity.HasMany(d => d.Cuisine).WithMany(p => p.Rests)
                .UsingEntity<Dictionary<string, object>>(
                    "Restaurant_Cuisine",
                    r => r.HasOne<Cuisine>().WithMany()
                        .HasForeignKey("cuisine_typeid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Restauran__cuisi__0E6E26BF"),
                    l => l.HasOne<Restaurants>().WithMany()
                        .HasForeignKey("rest_id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Restauran__rest___0D7A0286"),
                    j =>
                    {
                        j.HasKey("rest_id", "cuisine_typeid").HasName("PK__Restaura__6D2785A3A32D42CB");
                        j.ToTable("Restaurant_Cuisine");
                    });
        });

        modelBuilder.Entity<Score>(entity =>
        {
            entity.HasKey(e => e.score_id).HasName("PK__Score__8CA1905015854503");

            entity.ToTable("Score");

            entity.Property(e => e.score_id).HasColumnName("score_id");
            entity.Property(e => e.rest_scoreid).HasColumnName("rest_scoreid");
            entity.Property(e => e.score).HasColumnName("score");
            entity.Property(e => e.score_date)
                .HasColumnType("date")
                .HasColumnName("score_date");

            entity.HasOne(d => d.RestScore).WithMany(p => p.Scores)
                .HasForeignKey(d => d.rest_scoreid)
                .HasConstraintName("FK__Score__rest_scor__05D8E0BE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    //Stored Procedures
    public virtual IQueryable<Restaurants> get_restaurant_info()
    {
        return Restaurants.FromSqlRaw("EXEC get_restaurant_info");
    }

    public virtual IQueryable<double> get_restaurant_scoreavg(int rest_id)
    {
        var context = new RestaurantDbContext();
        var value = context.Database.SqlQuery<double>($"EXECUTE dbo.get_restaurant_scoreavg @{rest_id}");

        return value;
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public Task SaveAsync() { return SaveChangesAsync();  }
}
