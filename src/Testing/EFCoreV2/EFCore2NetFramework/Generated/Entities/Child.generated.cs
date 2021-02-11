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
   public partial class Child
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Child()
      {
         Children = new System.Collections.Generic.HashSet<global::Testing.Child>();
         Parent = global::Testing.Child.CreateChildUnsafe();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Child CreateChildUnsafe()
      {
         return new Child();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="parent"></param>
      /// <param name="_master0"></param>
      public Child(global::Testing.Child parent, global::Testing.Master _master0)
      {
         if (parent == null) throw new ArgumentNullException(nameof(parent));
         this.Parent = parent;
         parent.Children.Add(this);

         if (_master0 == null) throw new ArgumentNullException(nameof(_master0));
         _master0.Children.Add(this);

         this.Children = new System.Collections.Generic.HashSet<global::Testing.Child>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="parent"></param>
      /// <param name="_master0"></param>
      public static Child Create(global::Testing.Child parent, global::Testing.Master _master0)
      {
         return new Child(parent, _master0);
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
         set
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

      public virtual ICollection<global::Testing.Child> Children { get; private set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing.Child Parent { get; set; }

   }
}

