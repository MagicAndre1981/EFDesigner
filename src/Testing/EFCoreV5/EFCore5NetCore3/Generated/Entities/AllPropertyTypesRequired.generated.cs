//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v3.0.0.2
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

namespace Testing
{
   public partial class AllPropertyTypesRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected AllPropertyTypesRequired()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static AllPropertyTypesRequired CreateAllPropertyTypesRequiredUnsafe()
      {
         return new AllPropertyTypesRequired();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="binaryattr"></param>
      /// <param name="booleanattr"></param>
      /// <param name="byteattr"></param>
      /// <param name="datetimeattr"></param>
      /// <param name="datetimeoffsetattr"></param>
      /// <param name="decimalattr"></param>
      /// <param name="doubleattr"></param>
      /// <param name="guidattr"></param>
      /// <param name="int16attr"></param>
      /// <param name="int32attr"></param>
      /// <param name="int64attr"></param>
      /// <param name="singleattr"></param>
      /// <param name="timeattr"></param>
      /// <param name="stringattr"></param>
      public AllPropertyTypesRequired(byte[] binaryattr, bool booleanattr, byte byteattr, DateTime datetimeattr, DateTimeOffset datetimeoffsetattr, decimal decimalattr, double doubleattr, Guid guidattr, short int16attr, int int32attr, long int64attr, Single singleattr, TimeSpan timeattr, string stringattr)
      {
         this.BinaryAttr = binaryattr;

         this.BooleanAttr = booleanattr;

         this.ByteAttr = byteattr;

         this.DateTimeAttr = datetimeattr;

         this.DateTimeOffsetAttr = datetimeoffsetattr;

         this.DecimalAttr = decimalattr;

         this.DoubleAttr = doubleattr;

         this.GuidAttr = guidattr;

         this.Int16Attr = int16attr;

         this.Int32Attr = int32attr;

         this.Int64Attr = int64attr;

         this.SingleAttr = singleattr;

         this.TimeAttr = timeattr;

         if (string.IsNullOrEmpty(stringattr)) throw new ArgumentNullException(nameof(stringattr));
         this.StringAttr = stringattr;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="binaryattr"></param>
      /// <param name="booleanattr"></param>
      /// <param name="byteattr"></param>
      /// <param name="datetimeattr"></param>
      /// <param name="datetimeoffsetattr"></param>
      /// <param name="decimalattr"></param>
      /// <param name="doubleattr"></param>
      /// <param name="guidattr"></param>
      /// <param name="int16attr"></param>
      /// <param name="int32attr"></param>
      /// <param name="int64attr"></param>
      /// <param name="singleattr"></param>
      /// <param name="timeattr"></param>
      /// <param name="stringattr"></param>
      public static AllPropertyTypesRequired Create(byte[] binaryattr, bool booleanattr, byte byteattr, DateTime datetimeattr, DateTimeOffset datetimeoffsetattr, decimal decimalattr, double doubleattr, Guid guidattr, short int16attr, int int32attr, long int64attr, Single singleattr, TimeSpan timeattr, string stringattr)
      {
         return new AllPropertyTypesRequired(binaryattr, booleanattr, byteattr, datetimeattr, datetimeoffsetattr, decimalattr, doubleattr, guidattr, int16attr, int32attr, int64attr, singleattr, timeattr, stringattr);
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
      /// Backing field for BinaryAttr
      /// </summary>
      protected byte[] _binaryAttr;
      /// <summary>
      /// When provided in a partial class, allows value of BinaryAttr to be changed before setting.
      /// </summary>
      partial void SetBinaryAttr(byte[] oldValue, ref byte[] newValue);
      /// <summary>
      /// When provided in a partial class, allows value of BinaryAttr to be changed before returning.
      /// </summary>
      partial void GetBinaryAttr(ref byte[] result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public byte[] BinaryAttr
      {
         get
         {
            byte[] value = _binaryAttr;
            GetBinaryAttr(ref value);
            return (_binaryAttr = value);
         }
         set
         {
            byte[] oldValue = _binaryAttr;
            SetBinaryAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _binaryAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for BooleanAttr
      /// </summary>
      protected bool _booleanAttr;
      /// <summary>
      /// When provided in a partial class, allows value of BooleanAttr to be changed before setting.
      /// </summary>
      partial void SetBooleanAttr(bool oldValue, ref bool newValue);
      /// <summary>
      /// When provided in a partial class, allows value of BooleanAttr to be changed before returning.
      /// </summary>
      partial void GetBooleanAttr(ref bool result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public bool BooleanAttr
      {
         get
         {
            bool value = _booleanAttr;
            GetBooleanAttr(ref value);
            return (_booleanAttr = value);
         }
         set
         {
            bool oldValue = _booleanAttr;
            SetBooleanAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _booleanAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for ByteAttr
      /// </summary>
      protected byte _byteAttr;
      /// <summary>
      /// When provided in a partial class, allows value of ByteAttr to be changed before setting.
      /// </summary>
      partial void SetByteAttr(byte oldValue, ref byte newValue);
      /// <summary>
      /// When provided in a partial class, allows value of ByteAttr to be changed before returning.
      /// </summary>
      partial void GetByteAttr(ref byte result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public byte ByteAttr
      {
         get
         {
            byte value = _byteAttr;
            GetByteAttr(ref value);
            return (_byteAttr = value);
         }
         set
         {
            byte oldValue = _byteAttr;
            SetByteAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _byteAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for DateTimeAttr
      /// </summary>
      protected DateTime _dateTimeAttr;
      /// <summary>
      /// When provided in a partial class, allows value of DateTimeAttr to be changed before setting.
      /// </summary>
      partial void SetDateTimeAttr(DateTime oldValue, ref DateTime newValue);
      /// <summary>
      /// When provided in a partial class, allows value of DateTimeAttr to be changed before returning.
      /// </summary>
      partial void GetDateTimeAttr(ref DateTime result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public DateTime DateTimeAttr
      {
         get
         {
            DateTime value = _dateTimeAttr;
            GetDateTimeAttr(ref value);
            return (_dateTimeAttr = value);
         }
         set
         {
            DateTime oldValue = _dateTimeAttr;
            SetDateTimeAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _dateTimeAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for DateTimeOffsetAttr
      /// </summary>
      protected DateTimeOffset _dateTimeOffsetAttr;
      /// <summary>
      /// When provided in a partial class, allows value of DateTimeOffsetAttr to be changed before setting.
      /// </summary>
      partial void SetDateTimeOffsetAttr(DateTimeOffset oldValue, ref DateTimeOffset newValue);
      /// <summary>
      /// When provided in a partial class, allows value of DateTimeOffsetAttr to be changed before returning.
      /// </summary>
      partial void GetDateTimeOffsetAttr(ref DateTimeOffset result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public DateTimeOffset DateTimeOffsetAttr
      {
         get
         {
            DateTimeOffset value = _dateTimeOffsetAttr;
            GetDateTimeOffsetAttr(ref value);
            return (_dateTimeOffsetAttr = value);
         }
         set
         {
            DateTimeOffset oldValue = _dateTimeOffsetAttr;
            SetDateTimeOffsetAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _dateTimeOffsetAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for DecimalAttr
      /// </summary>
      protected decimal _decimalAttr;
      /// <summary>
      /// When provided in a partial class, allows value of DecimalAttr to be changed before setting.
      /// </summary>
      partial void SetDecimalAttr(decimal oldValue, ref decimal newValue);
      /// <summary>
      /// When provided in a partial class, allows value of DecimalAttr to be changed before returning.
      /// </summary>
      partial void GetDecimalAttr(ref decimal result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public decimal DecimalAttr
      {
         get
         {
            decimal value = _decimalAttr;
            GetDecimalAttr(ref value);
            return (_decimalAttr = value);
         }
         set
         {
            decimal oldValue = _decimalAttr;
            SetDecimalAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _decimalAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for DoubleAttr
      /// </summary>
      protected double _doubleAttr;
      /// <summary>
      /// When provided in a partial class, allows value of DoubleAttr to be changed before setting.
      /// </summary>
      partial void SetDoubleAttr(double oldValue, ref double newValue);
      /// <summary>
      /// When provided in a partial class, allows value of DoubleAttr to be changed before returning.
      /// </summary>
      partial void GetDoubleAttr(ref double result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public double DoubleAttr
      {
         get
         {
            double value = _doubleAttr;
            GetDoubleAttr(ref value);
            return (_doubleAttr = value);
         }
         set
         {
            double oldValue = _doubleAttr;
            SetDoubleAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _doubleAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for GuidAttr
      /// </summary>
      protected Guid _guidAttr;
      /// <summary>
      /// When provided in a partial class, allows value of GuidAttr to be changed before setting.
      /// </summary>
      partial void SetGuidAttr(Guid oldValue, ref Guid newValue);
      /// <summary>
      /// When provided in a partial class, allows value of GuidAttr to be changed before returning.
      /// </summary>
      partial void GetGuidAttr(ref Guid result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public Guid GuidAttr
      {
         get
         {
            Guid value = _guidAttr;
            GetGuidAttr(ref value);
            return (_guidAttr = value);
         }
         set
         {
            Guid oldValue = _guidAttr;
            SetGuidAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _guidAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for Int16Attr
      /// </summary>
      protected short _int16Attr;
      /// <summary>
      /// When provided in a partial class, allows value of Int16Attr to be changed before setting.
      /// </summary>
      partial void SetInt16Attr(short oldValue, ref short newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Int16Attr to be changed before returning.
      /// </summary>
      partial void GetInt16Attr(ref short result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public short Int16Attr
      {
         get
         {
            short value = _int16Attr;
            GetInt16Attr(ref value);
            return (_int16Attr = value);
         }
         set
         {
            short oldValue = _int16Attr;
            SetInt16Attr(oldValue, ref value);
            if (oldValue != value)
            {
               _int16Attr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for Int32Attr
      /// </summary>
      protected int _int32Attr;
      /// <summary>
      /// When provided in a partial class, allows value of Int32Attr to be changed before setting.
      /// </summary>
      partial void SetInt32Attr(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Int32Attr to be changed before returning.
      /// </summary>
      partial void GetInt32Attr(ref int result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public int Int32Attr
      {
         get
         {
            int value = _int32Attr;
            GetInt32Attr(ref value);
            return (_int32Attr = value);
         }
         set
         {
            int oldValue = _int32Attr;
            SetInt32Attr(oldValue, ref value);
            if (oldValue != value)
            {
               _int32Attr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for Int64Attr
      /// </summary>
      protected long _int64Attr;
      /// <summary>
      /// When provided in a partial class, allows value of Int64Attr to be changed before setting.
      /// </summary>
      partial void SetInt64Attr(long oldValue, ref long newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Int64Attr to be changed before returning.
      /// </summary>
      partial void GetInt64Attr(ref long result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public long Int64Attr
      {
         get
         {
            long value = _int64Attr;
            GetInt64Attr(ref value);
            return (_int64Attr = value);
         }
         set
         {
            long oldValue = _int64Attr;
            SetInt64Attr(oldValue, ref value);
            if (oldValue != value)
            {
               _int64Attr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for SingleAttr
      /// </summary>
      protected Single _singleAttr;
      /// <summary>
      /// When provided in a partial class, allows value of SingleAttr to be changed before setting.
      /// </summary>
      partial void SetSingleAttr(Single oldValue, ref Single newValue);
      /// <summary>
      /// When provided in a partial class, allows value of SingleAttr to be changed before returning.
      /// </summary>
      partial void GetSingleAttr(ref Single result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public Single SingleAttr
      {
         get
         {
            Single value = _singleAttr;
            GetSingleAttr(ref value);
            return (_singleAttr = value);
         }
         set
         {
            Single oldValue = _singleAttr;
            SetSingleAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _singleAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for TimeAttr
      /// </summary>
      protected TimeSpan _timeAttr;
      /// <summary>
      /// When provided in a partial class, allows value of TimeAttr to be changed before setting.
      /// </summary>
      partial void SetTimeAttr(TimeSpan oldValue, ref TimeSpan newValue);
      /// <summary>
      /// When provided in a partial class, allows value of TimeAttr to be changed before returning.
      /// </summary>
      partial void GetTimeAttr(ref TimeSpan result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public TimeSpan TimeAttr
      {
         get
         {
            TimeSpan value = _timeAttr;
            GetTimeAttr(ref value);
            return (_timeAttr = value);
         }
         set
         {
            TimeSpan oldValue = _timeAttr;
            SetTimeAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _timeAttr = value;
            }
         }
      }

      /// <summary>
      /// Backing field for StringAttr
      /// </summary>
      protected string _stringAttr;
      /// <summary>
      /// When provided in a partial class, allows value of StringAttr to be changed before setting.
      /// </summary>
      partial void SetStringAttr(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of StringAttr to be changed before returning.
      /// </summary>
      partial void GetStringAttr(ref string result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string StringAttr
      {
         get
         {
            string value = _stringAttr;
            GetStringAttr(ref value);
            return (_stringAttr = value);
         }
         set
         {
            string oldValue = _stringAttr;
            SetStringAttr(oldValue, ref value);
            if (oldValue != value)
            {
               _stringAttr = value;
            }
         }
      }

   }
}

