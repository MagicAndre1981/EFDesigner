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
   public abstract partial class AbstractBaseClass : Testing.BaseClassWithRequiredProperties
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to being abstract.
      /// </summary>
      protected AbstractBaseClass(): base()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_property0"></param>
      protected AbstractBaseClass(string _property0)
      {
         if (string.IsNullOrEmpty(_property0)) throw new ArgumentNullException(nameof(_property0));
         Property0 = _property0;
         Init();
      }

   }
}

