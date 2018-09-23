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
   public partial class BParentCollection
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BParentCollection()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_bchildrequired"></param>
      public BParentCollection(Testing_CoreV2NetCore.BChild _bchildrequired)
      {
         if (_bchildrequired == null) throw new ArgumentNullException(nameof(_bchildrequired));
         BChildRequired = _bchildrequired;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_bchildrequired"></param>
      public static BParentCollection Create(Testing_CoreV2NetCore.BChild _bchildrequired)
      {
         return new BParentCollection(_bchildrequired);
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
      public virtual Testing_CoreV2NetCore.BChild BChildRequired { get; set; }  // Required
      public virtual Testing_CoreV2NetCore.BChild BChildOptional { get; set; } 
   }
}

