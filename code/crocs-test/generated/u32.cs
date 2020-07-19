
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct u32 : ICrocsObj
    {
        private bool _destructed;

        public const uint MAX = 4294967295;
        public const uint MIN = 0;

        private uint _value;

        public u32(uint value)
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

        public static implicit operator u32(uint num) { return new u32(num); }
        public static implicit operator uint(u32 num) { return num._value; }
        public static implicit operator decimal(u32 num) { return num._value; }

        
        public u64 as_u64 => _value;
        public i64 as_i64 => _value;

        public static implicit operator u64(u32 num) { return num._value; }
        public static implicit operator i64(u32 num) { return num._value; }

        public i32 as_i32_ort {
            get => Numerics.convert_to_i32_ort(_value);
        }

        public i16 as_i16_ort {
            get => Numerics.convert_to_i16_ort(_value);
        }

        public u16 as_u16_ort {
            get => Numerics.convert_to_u16_ort(_value);
        }

        public i8 as_i8_ort {
            get => Numerics.convert_to_i8_ort(_value);
        }

        public u8 as_u8_ort {
            get => Numerics.convert_to_u8_ort(_value);
        }

        public i32 wrap_to_i32 => unchecked((int)_value);
        public i16 wrap_to_i16 => unchecked((short)_value);
        public u16 wrap_to_u16 => unchecked((ushort)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        public static bool operator ==(u32 a, u32 b)
        {
            var result = (uint)a == (uint)b;
            return result;
        }

        public static bool operator !=(u32 a, u32 b)
        {
            var result = (uint)a != (uint)b;
            return result;
        }


        public static u32 operator +(u32 a, u32 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < u32.MIN) { throw new Exception("underflow!"); }
            if (value > u32.MAX) { throw new Exception("overflow!");  }
            u32 result = (uint)value;
            return result;
        }public static i64 operator +(u32 a, i64 b)
        {
            var value = (decimal)a + (decimal)b;
            
            i64 result = (long)value;
            return result;
        }public static u64 operator +(u32 a, u64 b)
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
            return value == (uint)value;
        }
    }

}
