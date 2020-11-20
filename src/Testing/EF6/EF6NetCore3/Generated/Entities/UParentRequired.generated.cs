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
using NetTopologySuite.Geometries;

namespace Testing
{
   public partial class UParentRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public UParentRequired()
      {
         UChildCollection = new System.Collections.ObjectModel.ObservableCollection<global::Testing.UChild>();
         UChildRequired = global::Testing.UChild.CreateUChildUnsafe();
         UChildOptional = global::Testing.UChild.CreateUChildUnsafe();

         Init();
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
      public virtual global::Testing.UChild UChildRequired { get; set; }

      public virtual ICollection<global::Testing.UChild> UChildCollection { get; private set; }

      public virtual global::Testing.UChild UChildOptional { get; set; }

   }
}

