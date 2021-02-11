//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v3.0.4.4
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
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
using System.Data.Entity.Spatial;

namespace Testing
{
   public partial class BParentRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public BParentRequired()
      {
         BChildCollection = new System.Collections.ObjectModel.ObservableCollection<global::Testing.BChild>();
         BChildRequired = global::Testing.BChild.CreateBChildUnsafe();

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

      /// <summary>
      /// Backing field for BChildOptional
      /// </summary>
      protected global::Testing.BChild _bChildOptional;

      /// <summary>
      /// When provided in a partial class, allows value of BChildOptional to be changed before setting.
      /// </summary>
      partial void SetBChildOptional(global::Testing.BChild oldValue, ref global::Testing.BChild newValue);

      /// <summary>
      /// When provided in a partial class, allows value of BChildOptional to be changed before returning.
      /// </summary>
      partial void GetBChildOptional(ref global::Testing.BChild result);

      public virtual global::Testing.BChild BChildOptional
      {
         get
         {
            global::Testing.BChild value = _bChildOptional;
            GetBChildOptional(ref value);
            return (_bChildOptional = value);
         }
         set
         {
            global::Testing.BChild oldValue = _bChildOptional;
            SetBChildOptional(oldValue, ref value);
            if (oldValue != value)
            {
               _bChildOptional = value;
            }
         }
      }

      /// <summary>
      /// Backing field for BChildRequired
      /// </summary>
      protected global::Testing.BChild _bChildRequired;

      /// <summary>
      /// When provided in a partial class, allows value of BChildRequired to be changed before setting.
      /// </summary>
      partial void SetBChildRequired(global::Testing.BChild oldValue, ref global::Testing.BChild newValue);

      /// <summary>
      /// When provided in a partial class, allows value of BChildRequired to be changed before returning.
      /// </summary>
      partial void GetBChildRequired(ref global::Testing.BChild result);

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing.BChild BChildRequired
      {
         get
         {
            global::Testing.BChild value = _bChildRequired;
            GetBChildRequired(ref value);
            return (_bChildRequired = value);
         }
         set
         {
            global::Testing.BChild oldValue = _bChildRequired;
            SetBChildRequired(oldValue, ref value);
            if (oldValue != value)
            {
               _bChildRequired = value;
            }
         }
      }

      /// <summary>
      /// Backing field for BChildCollection
      /// </summary>
      protected ICollection<global::Testing.BChild> _bChildCollection;

      public virtual ICollection<global::Testing.BChild> BChildCollection
      {
         get
         {
            return _bChildCollection;
         }
         private set
         {
            _bChildCollection = value;
         }
      }

   }
}

