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
   public partial class BaseClassWithRequiredProperties
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BaseClassWithRequiredProperties()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static BaseClassWithRequiredProperties CreateBaseClassWithRequiredPropertiesUnsafe()
      {
         return new BaseClassWithRequiredProperties();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="property0"></param>
      public BaseClassWithRequiredProperties(string property0)
      {
         if (string.IsNullOrEmpty(property0)) throw new ArgumentNullException(nameof(property0));
         this.Property0 = property0;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="property0"></param>
      public static BaseClassWithRequiredProperties Create(string property0)
      {
         return new BaseClassWithRequiredProperties(property0);
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

      /// <summary>
      /// Backing field for Property0
      /// </summary>
      protected string _property0;
      /// <summary>
      /// When provided in a partial class, allows value of Property0 to be changed before setting.
      /// </summary>
      partial void SetProperty0(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Property0 to be changed before returning.
      /// </summary>
      partial void GetProperty0(ref string result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string Property0
      {
         get
         {
            string value = _property0;
            GetProperty0(ref value);
            return (_property0 = value);
         }
         set
         {
            string oldValue = _property0;
            SetProperty0(oldValue, ref value);
            if (oldValue != value)
            {
               _property0 = value;
            }
         }
      }

   }
}

