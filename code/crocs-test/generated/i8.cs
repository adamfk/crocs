
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct i8 : ICrocsObj
    {
        private bool _destructed;

        public const sbyte MAX = 127;
        public const sbyte MIN = -128;

        private sbyte _value;

        public i8(sbyte value)
        {
            _destructed = false;
            _value = value;
        }

        public void Dispose()
        {
            _destructed = true;
        }

        public void _throw_if_destructed()
        {
            if (_destructed)
            {
                throw new MemberAccessException();
            }
        }

        public static implicit operator i8(sbyte num) { return new i8(num); }
        public static implicit operator sbyte(i8 num) { return num._value; }
        public static implicit operator decimal(i8 num) { return num._value; }

        
        public i16 as_i16 => _value;
        public i32 as_i32 => _value;
        public i64 as_i64 => _value;

        public static implicit operator i16(i8 num) { return num._value; }
        public static implicit operator i32(i8 num) { return num._value; }
        public static implicit operator i64(i8 num) { return num._value; }

        public u8 as_u8_ort {
            get {
                var vv = _value;
                decimal v = vv;
                if (v > u8.MAX || v < u8.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for u8");
                }
                return (byte)vv;
            }
        }

        public u8 wrap_to_u8 => unchecked((byte)_value);

        public static bool operator ==(i8 a, i8 b)
        {
            var result = (sbyte)a == (sbyte)b;
            return result;
        }

        public static bool operator !=(i8 a, i8 b)
        {
            var result = (sbyte)a != (sbyte)b;
            return result;
        }


        public static i8 operator +(i8 a, i8 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i8.MIN) { throw new Exception("underflow!"); }
            if (value > i8.MAX) { throw new Exception("overflow!");  }
            i8 result = (sbyte)value;
            return result;
        }public static i16 operator +(i8 a, i16 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i16.MIN) { throw new Exception("underflow!"); }
            if (value > i16.MAX) { throw new Exception("overflow!");  }
            i16 result = (short)value;
            return result;
        }public static i32 operator +(i8 a, i32 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i32.MIN) { throw new Exception("underflow!"); }
            if (value > i32.MAX) { throw new Exception("overflow!");  }
            i32 result = (int)value;
            return result;
        }public static i64 operator +(i8 a, i64 b)
        {
            var value = (decimal)a + (decimal)b;
            
            i64 result = (long)value;
            return result;
        }



        public override string ToString()
        {
            return _value.ToString();
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }

            decimal value;

            switch (obj)
            {
                case sbyte  i: value = i; break;
                case short  i: value = i; break;
                case int    i: value = i; break;
                case long   i: value = i; break;
                case byte   i: value = i; break;
                case ushort i: value = i; break;
                case uint   i: value = i; break;
                case ulong  i: value = i; break;

                case i8  i: value = i;  break;
                case i16 i: value = i; break;
                case i32 i: value = i; break;
                case i64 i: value = i; break;
                case u8  i: value = i;  break;
                case u16 i: value = i; break;
                case u32 i: value = i; break;
                case u64 i: value = i; break;

                default: return false;
            }

            if (value < MIN || value > MAX) { return false; }
            return value == (sbyte)value;
        }
    }

}
