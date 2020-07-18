
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace torc.lang
{
    public struct u16 : ICrocsObj
    {
        private bool _destructed;

        public const ushort MAX = 65535;
        public const ushort MIN = 0;

        private ushort _value;

        public u16(ushort value)
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

        public static implicit operator u16(ushort num) { return new u16(num); }
        public static implicit operator ushort(u16 num) { return num._value; }
        public static implicit operator decimal(u16 num) { return num._value; }

        
        public u32 as_u32 => _value;
        public u64 as_u64 => _value;
        public i32 as_i32 => _value;
        public i64 as_i64 => _value;

        public static implicit operator u32(u16 num) { return num._value; }
        public static implicit operator u64(u16 num) { return num._value; }
        public static implicit operator i32(u16 num) { return num._value; }
        public static implicit operator i64(u16 num) { return num._value; }

        public i16 as_i16_ort {
            get {
                var vv = _value;
                decimal v = vv;
                if (v > i16.MAX || v < i16.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for i16");
                }
                return (short)vv;
            }
        }

        public i8 as_i8_ort {
            get {
                var vv = _value;
                decimal v = vv;
                if (v > i8.MAX || v < i8.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for i8");
                }
                return (sbyte)vv;
            }
        }

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

        public i16 wrap_to_i16 => unchecked((short)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        public static bool operator ==(u16 a, u16 b)
        {
            var result = (ushort)a == (ushort)b;
            return result;
        }

        public static bool operator !=(u16 a, u16 b)
        {
            var result = (ushort)a != (ushort)b;
            return result;
        }


        public static i32 operator +(u16 a, i32 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i32.MIN) { throw new Exception("underflow!"); }
            if (value > i32.MAX) { throw new Exception("overflow!");  }
            i32 result = (int)value;
            return result;
        }public static i64 operator +(u16 a, i64 b)
        {
            var value = (decimal)a + (decimal)b;
            
            i64 result = (long)value;
            return result;
        }public static u32 operator +(u16 a, u32 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < u32.MIN) { throw new Exception("underflow!"); }
            if (value > u32.MAX) { throw new Exception("overflow!");  }
            u32 result = (uint)value;
            return result;
        }public static u64 operator +(u16 a, u64 b)
        {
            var value = (decimal)a + (decimal)b;
            
            u64 result = (ulong)value;
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
            return value == (ushort)value;
        }
    }

}
