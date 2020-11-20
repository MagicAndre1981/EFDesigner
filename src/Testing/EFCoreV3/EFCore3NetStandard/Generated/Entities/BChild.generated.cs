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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Testing
{
   public partial class BChild
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BChild()
      {
         // NOTE: This class has one-to-one associations with BChild.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         BParentCollection = new System.Collections.Generic.HashSet<global::Testing.BParentCollection>();
         BParentCollection_2 = new System.Collections.Generic.HashSet<global::Testing.BParentCollection>();
         BParentRequired = new global::Testing.BParentRequired();
         BParentRequired_1 = new global::Testing.BParentRequired();
         BParentRequired_2 = new global::Testing.BParentRequired();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static BChild CreateBChildUnsafe()
      {
         return new BChild();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="bparentrequired"></param>
      /// <param name="bparentrequired_2"></param>
      public BChild(global::Testing.BParentRequired bparentrequired, global::Testing.BParentRequired bparentrequired_2)
      {
         // NOTE: This class has one-to-one associations with BChild.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         if (bparentrequired == null) throw new ArgumentNullException(nameof(bparentrequired));
         this.BParentRequired = bparentrequired;

         if (bparentrequired_2 == null) throw new ArgumentNullException(nameof(bparentrequired_2));
         this.BParentRequired_2 = bparentrequired_2;

         this.BParentCollection = new System.Collections.Generic.HashSet<global::Testing.BParentCollection>();
         this.BParentCollection_2 = new System.Collections.Generic.HashSet<global::Testing.BParentCollection>();

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="bparentrequired"></param>
      /// <param name="bparentrequired_2"></param>
      public static BChild Create(global::Testing.BParentRequired bparentrequired, global::Testing.BParentRequired bparentrequired_2)
      {
         return new BChild(bparentrequired, bparentrequired_2);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      internal int _id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id
      {
         get
         {
            int value = _id;
            GetId(ref value);
            return (_id = value);
         }
         protected set
         {
            int oldValue = _id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _id = value;
            }
         }
      }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing.BParentRequired BParentRequired { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing.BParentRequired BParentRequired_1 { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing.BParentRequired BParentRequired_2 { get; set; }

      public virtual ICollection<global::Testing.BParentCollection> BParentCollection { get; private set; }

      public virtual ICollection<global::Testing.BParentCollection> BParentCollection_2 { get; private set; }

      public virtual global::Testing.BParentOptional BParentOptional { get; set; }

      public virtual global::Testing.BParentOptional BParentOptional_1 { get; set; }

      public virtual global::Testing.BParentOptional BParentOptional_2 { get; set; }

   }
}

