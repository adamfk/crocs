
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace torc.lang
{
    public struct i32 : ICrocsObj
    {
        private bool _destructed;

        public const int MAX = 2147483647;
        public const int MIN = -2147483648;

        private int _value;

        public i32(int value)
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

        public static implicit operator i32(int num) { return new i32(num); }
        public static implicit operator int(i32 num) { return num._value; }
        public static implicit operator decimal(i32 num) { return num._value; }

        
        public i64 as_i64 => _value;

        public static implicit operator i64(i32 num) { return num._value; }

        public u32 as_u32_ort {
            get {
                var vv = _value;
                decimal v = vv;
                if (v > u32.MAX || v < u32.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for u32");
                }
                return (uint)vv;
            }
        }

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

        public u16 as_u16_ort {
            get {
                var vv = _value;
                decimal v = vv;
                if (v > u16.MAX || v < u16.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for u16");
                }
                return (ushort)vv;
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

        public u32 wrap_to_u32 => unchecked((uint)_value);
        public i16 wrap_to_i16 => unchecked((short)_value);
        public u16 wrap_to_u16 => unchecked((ushort)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        public static bool operator ==(i32 a, i32 b)
        {
            var result = (int)a == (int)b;
            return result;
        }

        public static bool operator !=(i32 a, i32 b)
        {
            var result = (int)a != (int)b;
            return result;
        }


        public static i64 operator +(i32 a, i64 b)
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
            return value == (int)value;
        }
    }

}
