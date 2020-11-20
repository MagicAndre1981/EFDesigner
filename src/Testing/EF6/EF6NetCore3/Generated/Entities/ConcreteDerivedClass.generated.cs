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
   public partial class ConcreteDerivedClass: global::Testing.AbstractBaseClass
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected ConcreteDerivedClass(): base()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static ConcreteDerivedClass CreateConcreteDerivedClassUnsafe()
      {
         return new ConcreteDerivedClass();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="property0"></param>
      public ConcreteDerivedClass(string property0)
      {
         if (string.IsNullOrEmpty(property0)) throw new ArgumentNullException(nameof(property0));
         this.Property0 = property0;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="property0"></param>
      public static new ConcreteDerivedClass Create(string property0)
      {
         return new ConcreteDerivedClass(property0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Property1
      /// </summary>
      protected string _property1;
      /// <summary>
      /// When provided in a partial class, allows value of Property1 to be changed before setting.
      /// </summary>
      partial void SetProperty1(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Property1 to be changed before returning.
      /// </summary>
      partial void GetProperty1(ref string result);

      public string Property1
      {
         get
         {
            string value = _property1;
            GetProperty1(ref value);
            return (_property1 = value);
         }
         set
         {
            string oldValue = _property1;
            SetProperty1(oldValue, ref value);
            if (oldValue != value)
            {
               _property1 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for PropertyInChild
      /// </summary>
      protected string _propertyInChild;
      /// <summary>
      /// When provided in a partial class, allows value of PropertyInChild to be changed before setting.
      /// </summary>
      partial void SetPropertyInChild(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of PropertyInChild to be changed before returning.
      /// </summary>
      partial void GetPropertyInChild(ref string result);

      public string PropertyInChild
      {
         get
         {
            string value = _propertyInChild;
            GetPropertyInChild(ref value);
            return (_propertyInChild = value);
         }
         set
         {
            string oldValue = _propertyInChild;
            SetPropertyInChild(oldValue, ref value);
            if (oldValue != value)
            {
               _propertyInChild = value;
            }
         }
      }

   }
}

