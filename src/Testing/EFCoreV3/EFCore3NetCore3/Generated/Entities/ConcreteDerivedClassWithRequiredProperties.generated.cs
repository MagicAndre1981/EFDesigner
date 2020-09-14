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
   public partial class ConcreteDerivedClassWithRequiredProperties: global::Testing.AbstractBaseClass
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected ConcreteDerivedClassWithRequiredProperties(): base()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static ConcreteDerivedClassWithRequiredProperties CreateConcreteDerivedClassWithRequiredPropertiesUnsafe()
      {
         return new ConcreteDerivedClassWithRequiredProperties();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="property1"></param>
      /// <param name="property0"></param>
      public ConcreteDerivedClassWithRequiredProperties(string property1, string property0)
      {
         if (string.IsNullOrEmpty(property1)) throw new ArgumentNullException(nameof(property1));
         this.Property1 = property1;

         if (string.IsNullOrEmpty(property0)) throw new ArgumentNullException(nameof(property0));
         this.Property0 = property0;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="property1"></param>
      /// <param name="property0"></param>
      public static ConcreteDerivedClassWithRequiredProperties Create(string property1, string property0)
      {
         return new ConcreteDerivedClassWithRequiredProperties(property1, property0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Property1
      /// </summary>
      protected string _Property1;
      /// <summary>
      /// When provided in a partial class, allows value of Property1 to be changed before setting.
      /// </summary>
      partial void SetProperty1(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Property1 to be changed before returning.
      /// </summary>
      partial void GetProperty1(ref string result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string Property1
      {
         get
         {
            string value = _Property1;
            GetProperty1(ref value);
            return (_Property1 = value);
         }
         set
         {
            string oldValue = _Property1;
            SetProperty1(oldValue, ref value);
            if (oldValue != value)
            {
               _Property1 = value;
            }
         }
      }

   }
}

