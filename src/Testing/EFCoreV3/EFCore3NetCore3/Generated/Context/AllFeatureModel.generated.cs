//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
   public partial class AllFeatureModel : DbContext
   {
      #region DbSets
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.AbstractBaseClass> AbstractBaseClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.AllPropertyTypesOptional> AllPropertyTypesOptionals { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.AllPropertyTypesRequired> AllPropertyTypesRequireds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BaseClass> BaseClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BaseClassWithRequiredProperties> BaseClassWithRequiredProperties { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BChild> BChilds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BParentCollection> BParentCollections { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BParentOptional> BParentOptionals { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.BParentRequired> BParentRequireds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.Child> Children { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.ConcreteDerivedClass> ConcreteDerivedClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.ConcreteDerivedClassWithRequiredProperties> ConcreteDerivedClassWithRequiredProperties { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.DerivedClass> DerivedClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.HiddenEntity> HiddenEntities { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.Master> Masters { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.ParserTest> ParserTests { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.RenamedColumn> RenamedColumns { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UChild> UChilds { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UParentCollection> UParentCollections { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UParentOptional> UParentOptionals { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Testing.UParentRequired> UParentRequireds { get; set; }

      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=Test;Integrated Security=True";

      /// <inheritdoc />
      public AllFeatureModel(DbContextOptions<AllFeatureModel> options) : base(options)
      {
      }

      partial void CustomInit(DbContextOptionsBuilder optionsBuilder);

      /// <inheritdoc />
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseLazyLoadingProxies();

         CustomInit(optionsBuilder);
      }

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");


         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().ToTable("AllPropertyTypesOptionals").HasKey(t => new { t.Id, t.Id1 });
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.BinaryAttr).HasField("_binaryAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.BooleanAttr).HasField("_booleanAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.ByteAttr).HasField("_byteAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DateTimeAttr).HasField("_dateTimeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DateTimeOffsetAttr).HasField("_dateTimeOffsetAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DecimalAttr).HasField("_decimalAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.DoubleAttr).HasField("_doubleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.GuidAttr).HasField("_guidAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Int16Attr).HasField("_int16Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Int32Attr).HasField("_int32Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Int64Attr).HasField("_int64Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.SingleAttr).HasField("_singleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.StringAttr).HasField("_stringAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.TimeAttr).HasField("_timeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property(t => t.Id1).HasField("_id1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedNever().IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().Property<byte[]>("Timestamp").IsConcurrencyToken();
         modelBuilder.Entity<global::Testing.AllPropertyTypesOptional>().OwnsOne(p => p.OwnedType).Property(p => p.SingleAttr);

         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().ToTable("AllPropertyTypesRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.BinaryAttr).HasField("_binaryAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.BooleanAttr).HasField("_booleanAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.ByteAttr).HasField("_byteAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DateTimeAttr).HasField("_dateTimeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DateTimeOffsetAttr).HasField("_dateTimeOffsetAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DecimalAttr).HasField("_decimalAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.DoubleAttr).HasField("_doubleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.GuidAttr).HasField("_guidAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Int16Attr).HasField("_int16Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Int32Attr).HasField("_int32Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.Int64Attr).HasField("_int64Attr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.SingleAttr).HasField("_singleAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.StringAttr).HasField("_stringAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();
         modelBuilder.Entity<global::Testing.AllPropertyTypesRequired>().Property(t => t.TimeAttr).HasField("_timeAttr").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();


         modelBuilder.Entity<global::Testing.BaseClassWithRequiredProperties>().ToTable("BaseClassWithRequiredProperties").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BaseClassWithRequiredProperties>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.BaseClassWithRequiredProperties>().Property(t => t.Property0).HasField("_property0").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();

         modelBuilder.Entity<global::Testing.BChild>().ToTable("BChilds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BChild>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();

         modelBuilder.Entity<global::Testing.BParentCollection>().ToTable("BParentCollections").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BParentCollection>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.BParentCollection>().HasOne<global::Testing.BChild>(p => p.BChildRequired).WithMany(p => p.BParentCollection).HasForeignKey("BChildRequiredId");
         modelBuilder.Entity<global::Testing.BParentCollection>().Navigation(e => e.BChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.BParentCollection>().HasOne<global::Testing.BChild>(p => p.BChildOptional).WithMany(p => p.BParentCollection_2).HasForeignKey("BChildOptionalId");

         modelBuilder.Entity<global::Testing.BParentOptional>().ToTable("BParentOptionals").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BParentOptional>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.BParentOptional>().HasOne<global::Testing.BChild>(p => p.BChildRequired).WithOne(p => p.BParentOptional).HasForeignKey("BParentOptional", "BChildRequiredId");
         modelBuilder.Entity<global::Testing.BParentOptional>().Navigation(e => e.BChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.BParentOptional>().HasMany<global::Testing.BChild>(p => p.BChildCollection).WithOne(p => p.BParentOptional_1).HasForeignKey("BParentOptional_1Id");
         modelBuilder.Entity<global::Testing.BParentOptional>().HasOne<global::Testing.BChild>(p => p.BChildOptional).WithOne(p => p.BParentOptional_2).HasForeignKey("BChild", "BParentOptional_2Id");

         modelBuilder.Entity<global::Testing.BParentRequired>().ToTable("BParentRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.BParentRequired>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.BParentRequired>().HasOne<global::Testing.BChild>(p => p.BChildOptional).WithOne(p => p.BParentRequired).HasForeignKey("BChild", "BParentRequiredId");
         modelBuilder.Entity<global::Testing.BChild>().Navigation(e => e.BParentRequired).IsRequired();
         modelBuilder.Entity<global::Testing.BParentRequired>().HasOne<global::Testing.BChild>(p => p.BChildRequired).WithOne(p => p.BParentRequired_1).HasForeignKey("BChild", "BParentRequired_1Id").IsRequired();
         modelBuilder.Entity<global::Testing.BChild>().Navigation(e => e.BParentRequired_1).IsRequired();
         modelBuilder.Entity<global::Testing.BParentRequired>().HasMany<global::Testing.BChild>(p => p.BChildCollection).WithOne(p => p.BParentRequired_2).HasForeignKey("BParentRequired_2Id");
         modelBuilder.Entity<global::Testing.BChild>().Navigation(e => e.BParentRequired_2).IsRequired();

         modelBuilder.Entity<global::Testing.Child>().ToTable("Children").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.Child>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.Child>().HasMany<global::Testing.Child>(p => p.Children).WithOne(p => p.Parent).HasForeignKey("ParentId");
         modelBuilder.Entity<global::Testing.Child>().Navigation(e => e.Parent).IsRequired();

         modelBuilder.Entity<global::Testing.ConcreteDerivedClass>().Property(t => t.Property1).HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ConcreteDerivedClass>().Property(t => t.PropertyInChild).HasField("_propertyInChild").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.ConcreteDerivedClassWithRequiredProperties>().Property(t => t.Property1).HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).IsRequired();

         modelBuilder.Entity<global::Testing.DerivedClass>().Property(t => t.Property1).HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.DerivedClass>().Property(t => t.PropertyInChild).HasField("_propertyInChild").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.HiddenEntity>().ToTable("HiddenEntities").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.HiddenEntity>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.HiddenEntity>().Property(t => t.Property1).HasField("_property1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.Master>().ToTable("Masters").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.Master>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.Master>().HasMany<global::Testing.Child>(p => p.Children).WithOne().HasForeignKey("MasterChildrenId");
         modelBuilder.Entity<global::Testing.Master>().Navigation(e => e.Children).HasField("_children").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Owned<global::Testing.OwnedType>();

         modelBuilder.Entity<global::Testing.ParserTest>().ToTable("ParserTests").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name1).HasField("_name1").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name2).HasField("_name2").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name3).HasField("_name3").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name4).HasField("_name4").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name5).HasField("_name5").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name6).HasField("_name6").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name7).HasField("_name7").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name8).HasField("_name8").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name9).HasField("_name9").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name).HasField("_name").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name11).HasField("_name11").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name12).HasField("_name12").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name13).HasField("_name13").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name14).HasField("_name14").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name15).HasField("_name15").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name16).HasField("_name16").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name17).HasField("_name17").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.ParserTest>().Property(t => t.name18).HasField("_name18").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.RenamedColumn>().ToTable("RenamedColumns").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.RenamedColumn>().Property(t => t.Id).HasColumnName("Foo").HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();

         modelBuilder.Entity<global::Testing.UChild>().ToTable("UChilds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.UChild>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();

         modelBuilder.Entity<global::Testing.UParentCollection>().ToTable("UParentCollections").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.UParentCollection>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.UParentCollection>().HasOne<global::Testing.UChild>(p => p.UChildRequired).WithMany().HasForeignKey("UChildRequiredId");
         modelBuilder.Entity<global::Testing.UParentCollection>().Navigation(e => e.UChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.UParentCollection>().Navigation(e => e.UChildRequired).HasField("_uChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentCollection>().HasOne<global::Testing.UChild>(p => p.UChildOptional).WithMany().HasForeignKey("UChildOptionalId");
         modelBuilder.Entity<global::Testing.UParentCollection>().Navigation(e => e.UChildOptional).HasField("_uChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.UParentOptional>().Property(t => t.PropertyInChild).HasField("_propertyInChild").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).HasDefaultValue("hello");
         modelBuilder.Entity<global::Testing.UParentOptional>().HasOne<global::Testing.UChild>(p => p.UChildOptional).WithOne().HasForeignKey("UChild", "UParentOptionalUChildOptionalId");
         modelBuilder.Entity<global::Testing.UParentOptional>().Navigation(e => e.UChildOptional).HasField("_uChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentOptional>().HasMany<global::Testing.UChild>(p => p.UChildCollection).WithOne().HasForeignKey("UParentOptionalUChildCollectionId");
         modelBuilder.Entity<global::Testing.UParentOptional>().Navigation(e => e.UChildCollection).HasField("_uChildCollection").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentOptional>().HasOne<global::Testing.UChild>(p => p.UChildRequired).WithOne().HasForeignKey("UParentOptional", "UChildRequiredId");
         modelBuilder.Entity<global::Testing.UParentOptional>().Navigation(e => e.UChildRequired).IsRequired();
         modelBuilder.Entity<global::Testing.UParentOptional>().Navigation(e => e.UChildRequired).HasField("_uChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         modelBuilder.Entity<global::Testing.UParentRequired>().ToTable("UParentRequireds").HasKey(t => t.Id);
         modelBuilder.Entity<global::Testing.UParentRequired>().Property(t => t.Id).HasField("_id").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).ValueGeneratedOnAdd().IsRequired();
         modelBuilder.Entity<global::Testing.UParentRequired>().HasOne<global::Testing.UChild>(p => p.UChildRequired).WithOne().HasForeignKey("UChild", "UParentRequiredUChildRequiredId").IsRequired();
         modelBuilder.Entity<global::Testing.UParentRequired>().Navigation(e => e.UChildRequired).HasField("_uChildRequired").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentRequired>().HasMany<global::Testing.UChild>(p => p.UChildCollection).WithOne().HasForeignKey("UParentRequiredUChildCollectionId");
         modelBuilder.Entity<global::Testing.UParentRequired>().Navigation(e => e.UChildCollection).HasField("_uChildCollection").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
         modelBuilder.Entity<global::Testing.UParentRequired>().HasOne<global::Testing.UChild>(p => p.UChildOptional).WithOne().HasForeignKey("UChild", "UParentRequiredUChildOptionalId");
         modelBuilder.Entity<global::Testing.UParentRequired>().Navigation(e => e.UChildOptional).HasField("_uChildOptional").UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
