//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v3.0.4.5
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Testing
{
   /// <inheritdoc/>
   public partial class EFModel1 : DbContext
   {
      #region DbSets
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.Entity1> Entity1 { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.EntityAbstract> EntityAbstract { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.EntityImplementation> EntityImplementation { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.EntityRelated> EntityRelated { get; set; }

      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=Test;Integrated Security=True";

      /// <inheritdoc />
      public EFModel1(DbContextOptions<EFModel1> options) : base(options)
      {
      }

      partial void CustomInit(DbContextOptionsBuilder optionsBuilder);

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<global::Testing.Entity1>()
                     .ToTable("Entity1")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.Entity1>()
                     .Property(t => t.Id)
                     .ValueGeneratedOnAdd()
                     .IsRequired();
         modelBuilder.Entity<global::Testing.Entity1>()
                     .HasOne<global::Testing.EntityImplementation>(p => p.EntityImplementation)
                     .WithOne(p => p.Entity1)
                     .HasForeignKey("Entity1", "EntityImplementationId")
                     .OnDelete(DeleteBehavior.Cascade);
         modelBuilder.Entity<global::Testing.Entity1>().Navigation(e => e.EntityImplementation).IsRequired();

         modelBuilder.Entity<global::Testing.EntityAbstract>()
                     .ToTable("EntityAbstract")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.EntityAbstract>()
                     .Property(t => t.Id)
                     .ValueGeneratedOnAdd()
                     .IsRequired();

         modelBuilder.Entity<global::Testing.EntityImplementation>()
                     .ToTable("EntityImplementation");
         modelBuilder.Entity<global::Testing.EntityImplementation>()
                     .Property(t => t.Test)
                     .HasMaxLength(255)
                     .HasDefaultValue("default string");
         modelBuilder.Entity<global::Testing.EntityImplementation>()
                     .Property(t => t.Property1)
                     .HasDefaultValue(DateTime.UtcNow);
         modelBuilder.Entity<global::Testing.EntityImplementation>()
                     .Property(t => t.Property11)
                     .HasDefaultValue(3);
         modelBuilder.Entity<global::Testing.EntityImplementation>()
                     .Property(t => t.Property12)
                     .HasDefaultValue(true);

         modelBuilder.Entity<global::Testing.EntityRelated>()
                     .ToTable("EntityRelated")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.EntityRelated>()
                     .Property(t => t.Id)
                     .ValueGeneratedOnAdd()
                     .IsRequired();
         modelBuilder.Entity<global::Testing.EntityRelated>()
                     .HasOne<global::Testing.EntityAbstract>(p => p.EntityAbstract)
                     .WithMany(p => p.EntityRelated)
                     .HasForeignKey("EntityAbstractId");
         modelBuilder.Entity<global::Testing.EntityRelated>().Navigation(e => e.EntityAbstract).IsRequired();

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
