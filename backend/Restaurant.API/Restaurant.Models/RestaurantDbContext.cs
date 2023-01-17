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

    public DbSet<Grade> Grades { get; set; } = null!;

    public DbSet<Menu> Menus { get; set; } = null!;

    public DbSet<Restaurants> Restaurants { get; set; } = null!;

    public DbSet<Score> Scores { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:pisithserver.database.windows.net,1433;Initial Catalog=RestaurantDB;Persist Security Info=False;User ID=pisiths;Password=BlueBird12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.grade_id).HasName("PK__Grade__3A8F732CC65D78C0");

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

            entity.HasOne(d => d.Restaurant_Grade).WithMany(p => p.Grades)
                .HasForeignKey(d => d.rest_gradeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grade__rest_grad__6477ECF3");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.dish_id).HasName("PK__Menu__9F2B4CF91066D9DF");

            entity.ToTable("Menu");

            entity.Property(e => e.dish_id).HasColumnName("dish_id");
            entity.Property(e => e.cuisine_res).HasColumnName("cuisine_res");
            entity.Property(e => e.dish)
                .HasMaxLength(50)
                .HasColumnName("dish");
            entity.Property(e => e.price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");

            entity.HasOne(d => d.Restaurant_Menu).WithMany(p => p.Menus)
                .HasForeignKey(d => d.cuisine_res)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Menu__cuisine_re__5EBF139D");
        });

        modelBuilder.Entity<Restaurants>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Restaura__3213E83FC9B85F8C");

            entity.ToTable("Restaurant");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.city)
                .HasMaxLength(20)
                .HasColumnName("city");
            entity.Property(e => e.cuisine_type)
                .HasMaxLength(20)
                .HasColumnName("cuisine_type");
            entity.Property(e => e.name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.rest_id).HasColumnName("rest_id");
            entity.Property(e => e.state)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Score>(entity =>
        {
            entity.HasKey(e => e.score_id).HasName("PK__Score__8CA1905070E8121B");

            entity.ToTable("Score");

            entity.Property(e => e.score_id).HasColumnName("score_id");
            entity.Property(e => e.rest_scoreid).HasColumnName("rest_scoreid");
            entity.Property(e => e.score).HasColumnName("score");
            entity.Property(e => e.score_date)
                .HasColumnType("date")
                .HasColumnName("score_date");

            entity.HasOne(d => d.Restaurant_Score).WithMany(p => p.Scores)
                .HasForeignKey(d => d.rest_scoreid)
                .HasConstraintName("FK__Score__rest_scor__619B8048");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    public Task SaveAsync() { return SaveChangesAsync(); }
}
