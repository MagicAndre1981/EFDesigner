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
   public partial class AllPropertyTypesRequired : INotifyPropertyChanged
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
      /// Public constructor with required data
      /// </summary>
      /// <param name="_binaryattr"></param>
      /// <param name="_booleanattr"></param>
      /// <param name="_byteattr"></param>
      /// <param name="_datetimeattr"></param>
      /// <param name="_datetimeoffsetattr"></param>
      /// <param name="_decimalattr"></param>
      /// <param name="_doubleattr"></param>
      /// <param name="_guidattr"></param>
      /// <param name="_int16attr"></param>
      /// <param name="_int32attr"></param>
      /// <param name="_int64attr"></param>
      /// <param name="_singleattr"></param>
      /// <param name="_stringattr"></param>
      /// <param name="_timeattr"></param>
      public AllPropertyTypesRequired(byte[] _binaryattr, bool _booleanattr, byte _byteattr, DateTime _datetimeattr, DateTimeOffset _datetimeoffsetattr, decimal _decimalattr, double _doubleattr, Guid _guidattr, short _int16attr, int _int32attr, long _int64attr, Single _singleattr, string _stringattr, TimeSpan _timeattr)
      {
         BinaryAttr = _binaryattr;
         BooleanAttr = _booleanattr;
         ByteAttr = _byteattr;
         DateTimeAttr = _datetimeattr;
         DateTimeOffsetAttr = _datetimeoffsetattr;
         DecimalAttr = _decimalattr;
         DoubleAttr = _doubleattr;
         GuidAttr = _guidattr;
         Int16Attr = _int16attr;
         Int32Attr = _int32attr;
         Int64Attr = _int64attr;
         SingleAttr = _singleattr;
         if (string.IsNullOrEmpty(_stringattr)) throw new ArgumentNullException(nameof(_stringattr));
         StringAttr = _stringattr;
         TimeAttr = _timeattr;
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_binaryattr"></param>
      /// <param name="_booleanattr"></param>
      /// <param name="_byteattr"></param>
      /// <param name="_datetimeattr"></param>
      /// <param name="_datetimeoffsetattr"></param>
      /// <param name="_decimalattr"></param>
      /// <param name="_doubleattr"></param>
      /// <param name="_guidattr"></param>
      /// <param name="_int16attr"></param>
      /// <param name="_int32attr"></param>
      /// <param name="_int64attr"></param>
      /// <param name="_singleattr"></param>
      /// <param name="_stringattr"></param>
      /// <param name="_timeattr"></param>
      public static AllPropertyTypesRequired Create(byte[] _binaryattr, bool _booleanattr, byte _byteattr, DateTime _datetimeattr, DateTimeOffset _datetimeoffsetattr, decimal _decimalattr, double _doubleattr, Guid _guidattr, short _int16attr, int _int32attr, long _int64attr, Single _singleattr, string _stringattr, TimeSpan _timeattr)
      {
         return new AllPropertyTypesRequired(_binaryattr, _booleanattr, _byteattr, _datetimeattr, _datetimeoffsetattr, _decimalattr, _doubleattr, _guidattr, _int16attr, _int32attr, _int64attr, _singleattr, _stringattr, _timeattr);
      }

      // Persistent properties

      [Key]
      [Required]
      protected int _Id;
      partial void SetId(int oldValue, ref int newValue);
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      public int Id
      {
         get { int value = _Id; GetId(ref value); return (_Id = value); }
         set { int oldValue = _Id; SetId(oldValue, ref value); _Id = value;  OnPropertyChanged(); }
      }

      [Required]
      protected byte[] _BinaryAttr;
      partial void SetBinaryAttr(byte[] oldValue, ref byte[] newValue);
      partial void GetBinaryAttr(ref byte[] result);

      /// <summary>
      /// Required
      /// </summary>
      public byte[] BinaryAttr
      {
         get { byte[] value = _BinaryAttr; GetBinaryAttr(ref value); return (_BinaryAttr = value); }
         set { byte[] oldValue = _BinaryAttr; SetBinaryAttr(oldValue, ref value); _BinaryAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected bool _BooleanAttr;
      partial void SetBooleanAttr(bool oldValue, ref bool newValue);
      partial void GetBooleanAttr(ref bool result);

      /// <summary>
      /// Required
      /// </summary>
      public bool BooleanAttr
      {
         get { bool value = _BooleanAttr; GetBooleanAttr(ref value); return (_BooleanAttr = value); }
         set { bool oldValue = _BooleanAttr; SetBooleanAttr(oldValue, ref value); _BooleanAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected byte _ByteAttr;
      partial void SetByteAttr(byte oldValue, ref byte newValue);
      partial void GetByteAttr(ref byte result);

      /// <summary>
      /// Required
      /// </summary>
      public byte ByteAttr
      {
         get { byte value = _ByteAttr; GetByteAttr(ref value); return (_ByteAttr = value); }
         set { byte oldValue = _ByteAttr; SetByteAttr(oldValue, ref value); _ByteAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected DateTime _DateTimeAttr;
      partial void SetDateTimeAttr(DateTime oldValue, ref DateTime newValue);
      partial void GetDateTimeAttr(ref DateTime result);

      /// <summary>
      /// Required
      /// </summary>
      public DateTime DateTimeAttr
      {
         get { DateTime value = _DateTimeAttr; GetDateTimeAttr(ref value); return (_DateTimeAttr = value); }
         set { DateTime oldValue = _DateTimeAttr; SetDateTimeAttr(oldValue, ref value); _DateTimeAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected DateTimeOffset _DateTimeOffsetAttr;
      partial void SetDateTimeOffsetAttr(DateTimeOffset oldValue, ref DateTimeOffset newValue);
      partial void GetDateTimeOffsetAttr(ref DateTimeOffset result);

      /// <summary>
      /// Required
      /// </summary>
      public DateTimeOffset DateTimeOffsetAttr
      {
         get { DateTimeOffset value = _DateTimeOffsetAttr; GetDateTimeOffsetAttr(ref value); return (_DateTimeOffsetAttr = value); }
         set { DateTimeOffset oldValue = _DateTimeOffsetAttr; SetDateTimeOffsetAttr(oldValue, ref value); _DateTimeOffsetAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected decimal _DecimalAttr;
      partial void SetDecimalAttr(decimal oldValue, ref decimal newValue);
      partial void GetDecimalAttr(ref decimal result);

      /// <summary>
      /// Required
      /// </summary>
      public decimal DecimalAttr
      {
         get { decimal value = _DecimalAttr; GetDecimalAttr(ref value); return (_DecimalAttr = value); }
         set { decimal oldValue = _DecimalAttr; SetDecimalAttr(oldValue, ref value); _DecimalAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected double _DoubleAttr;
      partial void SetDoubleAttr(double oldValue, ref double newValue);
      partial void GetDoubleAttr(ref double result);

      /// <summary>
      /// Required
      /// </summary>
      public double DoubleAttr
      {
         get { double value = _DoubleAttr; GetDoubleAttr(ref value); return (_DoubleAttr = value); }
         set { double oldValue = _DoubleAttr; SetDoubleAttr(oldValue, ref value); _DoubleAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected Guid _GuidAttr;
      partial void SetGuidAttr(Guid oldValue, ref Guid newValue);
      partial void GetGuidAttr(ref Guid result);

      /// <summary>
      /// Required
      /// </summary>
      public Guid GuidAttr
      {
         get { Guid value = _GuidAttr; GetGuidAttr(ref value); return (_GuidAttr = value); }
         set { Guid oldValue = _GuidAttr; SetGuidAttr(oldValue, ref value); _GuidAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected short _Int16Attr;
      partial void SetInt16Attr(short oldValue, ref short newValue);
      partial void GetInt16Attr(ref short result);

      /// <summary>
      /// Required
      /// </summary>
      public short Int16Attr
      {
         get { short value = _Int16Attr; GetInt16Attr(ref value); return (_Int16Attr = value); }
         set { short oldValue = _Int16Attr; SetInt16Attr(oldValue, ref value); _Int16Attr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected int _Int32Attr;
      partial void SetInt32Attr(int oldValue, ref int newValue);
      partial void GetInt32Attr(ref int result);

      /// <summary>
      /// Required
      /// </summary>
      public int Int32Attr
      {
         get { int value = _Int32Attr; GetInt32Attr(ref value); return (_Int32Attr = value); }
         set { int oldValue = _Int32Attr; SetInt32Attr(oldValue, ref value); _Int32Attr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected long _Int64Attr;
      partial void SetInt64Attr(long oldValue, ref long newValue);
      partial void GetInt64Attr(ref long result);

      /// <summary>
      /// Required
      /// </summary>
      public long Int64Attr
      {
         get { long value = _Int64Attr; GetInt64Attr(ref value); return (_Int64Attr = value); }
         set { long oldValue = _Int64Attr; SetInt64Attr(oldValue, ref value); _Int64Attr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected Single _SingleAttr;
      partial void SetSingleAttr(Single oldValue, ref Single newValue);
      partial void GetSingleAttr(ref Single result);

      /// <summary>
      /// Required
      /// </summary>
      public Single SingleAttr
      {
         get { Single value = _SingleAttr; GetSingleAttr(ref value); return (_SingleAttr = value); }
         set { Single oldValue = _SingleAttr; SetSingleAttr(oldValue, ref value); _SingleAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      [MaxLength(10)]
      protected string _StringAttr;
      partial void SetStringAttr(string oldValue, ref string newValue);
      partial void GetStringAttr(ref string result);

      /// <summary>
      /// Required, Min length = 1, Max length = 10
      /// </summary>
      public string StringAttr
      {
         get { string value = _StringAttr; GetStringAttr(ref value); return (_StringAttr = value); }
         set { string oldValue = _StringAttr; SetStringAttr(oldValue, ref value); _StringAttr = value;  OnPropertyChanged(); }
      }

      [Required]
      protected TimeSpan _TimeAttr;
      partial void SetTimeAttr(TimeSpan oldValue, ref TimeSpan newValue);
      partial void GetTimeAttr(ref TimeSpan result);

      /// <summary>
      /// Required
      /// </summary>
      public TimeSpan TimeAttr
      {
         get { TimeSpan value = _TimeAttr; GetTimeAttr(ref value); return (_TimeAttr = value); }
         set { TimeSpan oldValue = _TimeAttr; SetTimeAttr(oldValue, ref value); _TimeAttr = value;  OnPropertyChanged(); }
      }

      public event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

   }
}

