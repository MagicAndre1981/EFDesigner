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
   public partial class SpatialProperties
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected SpatialProperties()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static SpatialProperties CreateSpatialPropertiesUnsafe()
      {
         return new SpatialProperties();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="attrgeography"></param>
      /// <param name="attrgeographycollection"></param>
      /// <param name="attrgeographylinestring"></param>
      /// <param name="attrgeographymultilinestring"></param>
      /// <param name="attrgeographymultipoint"></param>
      /// <param name="attrgeographymultipolygon"></param>
      /// <param name="attrgeographypoint"></param>
      /// <param name="attrgeographypolygon"></param>
      /// <param name="attrgeometry"></param>
      /// <param name="attrgeometrycollection"></param>
      /// <param name="attrgeometrylinestring"></param>
      /// <param name="attrgeometrymultilinestring"></param>
      /// <param name="attrgeometrymultipoint"></param>
      /// <param name="attrgeometrymultipolygon"></param>
      /// <param name="attrgeometrypoint"></param>
      public SpatialProperties(Geography attrgeography, GeographyCollection attrgeographycollection, GeographyLineString attrgeographylinestring, GeographyMultiLineString attrgeographymultilinestring, GeographyMultiPoint attrgeographymultipoint, GeographyMultiPolygon attrgeographymultipolygon, GeographyPoint attrgeographypoint, GeographyPolygon attrgeographypolygon, Geometry attrgeometry, GeometryCollection attrgeometrycollection, GeometryLineString attrgeometrylinestring, GeometryMultiLineString attrgeometrymultilinestring, GeometryMultiPoint attrgeometrymultipoint, GeometryMultiPolygon attrgeometrymultipolygon, GeometryPoint attrgeometrypoint)
      {
         if (attrgeography == null) throw new ArgumentNullException(nameof(attrgeography));
         this.AttrGeography = attrgeography;

         if (attrgeographycollection == null) throw new ArgumentNullException(nameof(attrgeographycollection));
         this.AttrGeographyCollection = attrgeographycollection;

         if (attrgeographylinestring == null) throw new ArgumentNullException(nameof(attrgeographylinestring));
         this.AttrGeographyLineString = attrgeographylinestring;

         if (attrgeographymultilinestring == null) throw new ArgumentNullException(nameof(attrgeographymultilinestring));
         this.AttrGeographyMultiLineString = attrgeographymultilinestring;

         if (attrgeographymultipoint == null) throw new ArgumentNullException(nameof(attrgeographymultipoint));
         this.AttrGeographyMultiPoint = attrgeographymultipoint;

         if (attrgeographymultipolygon == null) throw new ArgumentNullException(nameof(attrgeographymultipolygon));
         this.AttrGeographyMultiPolygon = attrgeographymultipolygon;

         if (attrgeographypoint == null) throw new ArgumentNullException(nameof(attrgeographypoint));
         this.AttrGeographyPoint = attrgeographypoint;

         if (attrgeographypolygon == null) throw new ArgumentNullException(nameof(attrgeographypolygon));
         this.AttrGeographyPolygon = attrgeographypolygon;

         if (attrgeometry == null) throw new ArgumentNullException(nameof(attrgeometry));
         this.AttrGeometry = attrgeometry;

         if (attrgeometrycollection == null) throw new ArgumentNullException(nameof(attrgeometrycollection));
         this.AttrGeometryCollection = attrgeometrycollection;

         if (attrgeometrylinestring == null) throw new ArgumentNullException(nameof(attrgeometrylinestring));
         this.AttrGeometryLineString = attrgeometrylinestring;

         if (attrgeometrymultilinestring == null) throw new ArgumentNullException(nameof(attrgeometrymultilinestring));
         this.AttrGeometryMultiLineString = attrgeometrymultilinestring;

         if (attrgeometrymultipoint == null) throw new ArgumentNullException(nameof(attrgeometrymultipoint));
         this.AttrGeometryMultiPoint = attrgeometrymultipoint;

         if (attrgeometrymultipolygon == null) throw new ArgumentNullException(nameof(attrgeometrymultipolygon));
         this.AttrGeometryMultiPolygon = attrgeometrymultipolygon;

         if (attrgeometrypoint == null) throw new ArgumentNullException(nameof(attrgeometrypoint));
         this.AttrGeometryPoint = attrgeometrypoint;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="attrgeography"></param>
      /// <param name="attrgeographycollection"></param>
      /// <param name="attrgeographylinestring"></param>
      /// <param name="attrgeographymultilinestring"></param>
      /// <param name="attrgeographymultipoint"></param>
      /// <param name="attrgeographymultipolygon"></param>
      /// <param name="attrgeographypoint"></param>
      /// <param name="attrgeographypolygon"></param>
      /// <param name="attrgeometry"></param>
      /// <param name="attrgeometrycollection"></param>
      /// <param name="attrgeometrylinestring"></param>
      /// <param name="attrgeometrymultilinestring"></param>
      /// <param name="attrgeometrymultipoint"></param>
      /// <param name="attrgeometrymultipolygon"></param>
      /// <param name="attrgeometrypoint"></param>
      public static SpatialProperties Create(Geography attrgeography, GeographyCollection attrgeographycollection, GeographyLineString attrgeographylinestring, GeographyMultiLineString attrgeographymultilinestring, GeographyMultiPoint attrgeographymultipoint, GeographyMultiPolygon attrgeographymultipolygon, GeographyPoint attrgeographypoint, GeographyPolygon attrgeographypolygon, Geometry attrgeometry, GeometryCollection attrgeometrycollection, GeometryLineString attrgeometrylinestring, GeometryMultiLineString attrgeometrymultilinestring, GeometryMultiPoint attrgeometrymultipoint, GeometryMultiPolygon attrgeometrymultipolygon, GeometryPoint attrgeometrypoint)
      {
         return new SpatialProperties(attrgeography, attrgeographycollection, attrgeographylinestring, attrgeographymultilinestring, attrgeographymultipoint, attrgeographymultipolygon, attrgeographypoint, attrgeographypolygon, attrgeometry, attrgeometrycollection, attrgeometrylinestring, attrgeometrymultilinestring, attrgeometrymultipoint, attrgeometrymultipolygon, attrgeometrypoint);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      protected int _id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Required
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
      /// Backing field for AttrGeography
      /// </summary>
      protected Geography _attrGeography;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeography to be changed before setting.
      /// </summary>
      partial void SetAttrGeography(Geography oldValue, ref Geography newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeography to be changed before returning.
      /// </summary>
      partial void GetAttrGeography(ref Geography result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public Geography AttrGeography
      {
         get
         {
            Geography value = _attrGeography;
            GetAttrGeography(ref value);
            return (_attrGeography = value);
         }
         set
         {
            Geography oldValue = _attrGeography;
            SetAttrGeography(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeography = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeographyCollection
      /// </summary>
      protected GeographyCollection _attrGeographyCollection;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyCollection to be changed before setting.
      /// </summary>
      partial void SetAttrGeographyCollection(GeographyCollection oldValue, ref GeographyCollection newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyCollection to be changed before returning.
      /// </summary>
      partial void GetAttrGeographyCollection(ref GeographyCollection result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeographyCollection AttrGeographyCollection
      {
         get
         {
            GeographyCollection value = _attrGeographyCollection;
            GetAttrGeographyCollection(ref value);
            return (_attrGeographyCollection = value);
         }
         set
         {
            GeographyCollection oldValue = _attrGeographyCollection;
            SetAttrGeographyCollection(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeographyCollection = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeographyLineString
      /// </summary>
      protected GeographyLineString _attrGeographyLineString;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyLineString to be changed before setting.
      /// </summary>
      partial void SetAttrGeographyLineString(GeographyLineString oldValue, ref GeographyLineString newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyLineString to be changed before returning.
      /// </summary>
      partial void GetAttrGeographyLineString(ref GeographyLineString result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeographyLineString AttrGeographyLineString
      {
         get
         {
            GeographyLineString value = _attrGeographyLineString;
            GetAttrGeographyLineString(ref value);
            return (_attrGeographyLineString = value);
         }
         set
         {
            GeographyLineString oldValue = _attrGeographyLineString;
            SetAttrGeographyLineString(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeographyLineString = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeographyMultiLineString
      /// </summary>
      protected GeographyMultiLineString _attrGeographyMultiLineString;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyMultiLineString to be changed before setting.
      /// </summary>
      partial void SetAttrGeographyMultiLineString(GeographyMultiLineString oldValue, ref GeographyMultiLineString newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyMultiLineString to be changed before returning.
      /// </summary>
      partial void GetAttrGeographyMultiLineString(ref GeographyMultiLineString result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeographyMultiLineString AttrGeographyMultiLineString
      {
         get
         {
            GeographyMultiLineString value = _attrGeographyMultiLineString;
            GetAttrGeographyMultiLineString(ref value);
            return (_attrGeographyMultiLineString = value);
         }
         set
         {
            GeographyMultiLineString oldValue = _attrGeographyMultiLineString;
            SetAttrGeographyMultiLineString(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeographyMultiLineString = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeographyMultiPoint
      /// </summary>
      protected GeographyMultiPoint _attrGeographyMultiPoint;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyMultiPoint to be changed before setting.
      /// </summary>
      partial void SetAttrGeographyMultiPoint(GeographyMultiPoint oldValue, ref GeographyMultiPoint newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyMultiPoint to be changed before returning.
      /// </summary>
      partial void GetAttrGeographyMultiPoint(ref GeographyMultiPoint result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeographyMultiPoint AttrGeographyMultiPoint
      {
         get
         {
            GeographyMultiPoint value = _attrGeographyMultiPoint;
            GetAttrGeographyMultiPoint(ref value);
            return (_attrGeographyMultiPoint = value);
         }
         set
         {
            GeographyMultiPoint oldValue = _attrGeographyMultiPoint;
            SetAttrGeographyMultiPoint(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeographyMultiPoint = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeographyMultiPolygon
      /// </summary>
      protected GeographyMultiPolygon _attrGeographyMultiPolygon;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyMultiPolygon to be changed before setting.
      /// </summary>
      partial void SetAttrGeographyMultiPolygon(GeographyMultiPolygon oldValue, ref GeographyMultiPolygon newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyMultiPolygon to be changed before returning.
      /// </summary>
      partial void GetAttrGeographyMultiPolygon(ref GeographyMultiPolygon result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeographyMultiPolygon AttrGeographyMultiPolygon
      {
         get
         {
            GeographyMultiPolygon value = _attrGeographyMultiPolygon;
            GetAttrGeographyMultiPolygon(ref value);
            return (_attrGeographyMultiPolygon = value);
         }
         set
         {
            GeographyMultiPolygon oldValue = _attrGeographyMultiPolygon;
            SetAttrGeographyMultiPolygon(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeographyMultiPolygon = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeographyPoint
      /// </summary>
      protected GeographyPoint _attrGeographyPoint;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyPoint to be changed before setting.
      /// </summary>
      partial void SetAttrGeographyPoint(GeographyPoint oldValue, ref GeographyPoint newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyPoint to be changed before returning.
      /// </summary>
      partial void GetAttrGeographyPoint(ref GeographyPoint result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeographyPoint AttrGeographyPoint
      {
         get
         {
            GeographyPoint value = _attrGeographyPoint;
            GetAttrGeographyPoint(ref value);
            return (_attrGeographyPoint = value);
         }
         set
         {
            GeographyPoint oldValue = _attrGeographyPoint;
            SetAttrGeographyPoint(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeographyPoint = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeographyPolygon
      /// </summary>
      protected GeographyPolygon _attrGeographyPolygon;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyPolygon to be changed before setting.
      /// </summary>
      partial void SetAttrGeographyPolygon(GeographyPolygon oldValue, ref GeographyPolygon newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeographyPolygon to be changed before returning.
      /// </summary>
      partial void GetAttrGeographyPolygon(ref GeographyPolygon result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeographyPolygon AttrGeographyPolygon
      {
         get
         {
            GeographyPolygon value = _attrGeographyPolygon;
            GetAttrGeographyPolygon(ref value);
            return (_attrGeographyPolygon = value);
         }
         set
         {
            GeographyPolygon oldValue = _attrGeographyPolygon;
            SetAttrGeographyPolygon(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeographyPolygon = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeometry
      /// </summary>
      protected Geometry _attrGeometry;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometry to be changed before setting.
      /// </summary>
      partial void SetAttrGeometry(Geometry oldValue, ref Geometry newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometry to be changed before returning.
      /// </summary>
      partial void GetAttrGeometry(ref Geometry result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public Geometry AttrGeometry
      {
         get
         {
            Geometry value = _attrGeometry;
            GetAttrGeometry(ref value);
            return (_attrGeometry = value);
         }
         set
         {
            Geometry oldValue = _attrGeometry;
            SetAttrGeometry(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeometry = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeometryCollection
      /// </summary>
      protected GeometryCollection _attrGeometryCollection;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryCollection to be changed before setting.
      /// </summary>
      partial void SetAttrGeometryCollection(GeometryCollection oldValue, ref GeometryCollection newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryCollection to be changed before returning.
      /// </summary>
      partial void GetAttrGeometryCollection(ref GeometryCollection result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeometryCollection AttrGeometryCollection
      {
         get
         {
            GeometryCollection value = _attrGeometryCollection;
            GetAttrGeometryCollection(ref value);
            return (_attrGeometryCollection = value);
         }
         set
         {
            GeometryCollection oldValue = _attrGeometryCollection;
            SetAttrGeometryCollection(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeometryCollection = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeometryLineString
      /// </summary>
      protected GeometryLineString _attrGeometryLineString;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryLineString to be changed before setting.
      /// </summary>
      partial void SetAttrGeometryLineString(GeometryLineString oldValue, ref GeometryLineString newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryLineString to be changed before returning.
      /// </summary>
      partial void GetAttrGeometryLineString(ref GeometryLineString result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeometryLineString AttrGeometryLineString
      {
         get
         {
            GeometryLineString value = _attrGeometryLineString;
            GetAttrGeometryLineString(ref value);
            return (_attrGeometryLineString = value);
         }
         set
         {
            GeometryLineString oldValue = _attrGeometryLineString;
            SetAttrGeometryLineString(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeometryLineString = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeometryMultiLineString
      /// </summary>
      protected GeometryMultiLineString _attrGeometryMultiLineString;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryMultiLineString to be changed before setting.
      /// </summary>
      partial void SetAttrGeometryMultiLineString(GeometryMultiLineString oldValue, ref GeometryMultiLineString newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryMultiLineString to be changed before returning.
      /// </summary>
      partial void GetAttrGeometryMultiLineString(ref GeometryMultiLineString result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeometryMultiLineString AttrGeometryMultiLineString
      {
         get
         {
            GeometryMultiLineString value = _attrGeometryMultiLineString;
            GetAttrGeometryMultiLineString(ref value);
            return (_attrGeometryMultiLineString = value);
         }
         set
         {
            GeometryMultiLineString oldValue = _attrGeometryMultiLineString;
            SetAttrGeometryMultiLineString(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeometryMultiLineString = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeometryMultiPoint
      /// </summary>
      protected GeometryMultiPoint _attrGeometryMultiPoint;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryMultiPoint to be changed before setting.
      /// </summary>
      partial void SetAttrGeometryMultiPoint(GeometryMultiPoint oldValue, ref GeometryMultiPoint newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryMultiPoint to be changed before returning.
      /// </summary>
      partial void GetAttrGeometryMultiPoint(ref GeometryMultiPoint result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeometryMultiPoint AttrGeometryMultiPoint
      {
         get
         {
            GeometryMultiPoint value = _attrGeometryMultiPoint;
            GetAttrGeometryMultiPoint(ref value);
            return (_attrGeometryMultiPoint = value);
         }
         set
         {
            GeometryMultiPoint oldValue = _attrGeometryMultiPoint;
            SetAttrGeometryMultiPoint(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeometryMultiPoint = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeometryMultiPolygon
      /// </summary>
      protected GeometryMultiPolygon _attrGeometryMultiPolygon;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryMultiPolygon to be changed before setting.
      /// </summary>
      partial void SetAttrGeometryMultiPolygon(GeometryMultiPolygon oldValue, ref GeometryMultiPolygon newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryMultiPolygon to be changed before returning.
      /// </summary>
      partial void GetAttrGeometryMultiPolygon(ref GeometryMultiPolygon result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeometryMultiPolygon AttrGeometryMultiPolygon
      {
         get
         {
            GeometryMultiPolygon value = _attrGeometryMultiPolygon;
            GetAttrGeometryMultiPolygon(ref value);
            return (_attrGeometryMultiPolygon = value);
         }
         set
         {
            GeometryMultiPolygon oldValue = _attrGeometryMultiPolygon;
            SetAttrGeometryMultiPolygon(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeometryMultiPolygon = value;
            }
         }
      }

      /// <summary>
      /// Backing field for AttrGeometryPoint
      /// </summary>
      protected GeometryPoint _attrGeometryPoint;
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryPoint to be changed before setting.
      /// </summary>
      partial void SetAttrGeometryPoint(GeometryPoint oldValue, ref GeometryPoint newValue);
      /// <summary>
      /// When provided in a partial class, allows value of AttrGeometryPoint to be changed before returning.
      /// </summary>
      partial void GetAttrGeometryPoint(ref GeometryPoint result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public GeometryPoint AttrGeometryPoint
      {
         get
         {
            GeometryPoint value = _attrGeometryPoint;
            GetAttrGeometryPoint(ref value);
            return (_attrGeometryPoint = value);
         }
         set
         {
            GeometryPoint oldValue = _attrGeometryPoint;
            SetAttrGeometryPoint(oldValue, ref value);
            if (oldValue != value)
            {
               _attrGeometryPoint = value;
            }
         }
      }

   }
}

