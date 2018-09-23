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

namespace Testing_CoreV2NetCore
{
   public partial class UParentRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UParentRequired()
      {
         UChildCollection = new System.Collections.Generic.HashSet<Testing_CoreV2NetCore.UChild>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_uchildrequired"></param>
      public UParentRequired(Testing_CoreV2NetCore.UChild _uchildrequired)
      {
         if (_uchildrequired == null) throw new ArgumentNullException(nameof(_uchildrequired));
         UChildRequired = _uchildrequired;

         UChildCollection = new HashSet<Testing_CoreV2NetCore.UChild>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_uchildrequired"></param>
      public static UParentRequired Create(Testing_CoreV2NetCore.UChild _uchildrequired)
      {
         return new UParentRequired(_uchildrequired);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      // Persistent navigation properties

      /// <summary>
      ///  // Required
      /// </summary>
      public virtual Testing_CoreV2NetCore.UChild UChildRequired { get; set; }  // Required
      public virtual ICollection<Testing_CoreV2NetCore.UChild> UChildCollection { get; set; } 
      public virtual Testing_CoreV2NetCore.UChild UChildOptional { get; set; } 
   }
}

