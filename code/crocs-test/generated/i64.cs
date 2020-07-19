
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct i64 : ICrocsObj
    {
        private bool _destructed;

        public const long MAX = 9223372036854775807;
        public const long MIN = -9223372036854775808;

        private long _value;

        public i64(long value)
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

        public static implicit operator i64(long num) { return new i64(num); }
        public static implicit operator long(i64 num) { return num._value; }
        public static implicit operator decimal(i64 num) { return num._value; }

        

        

        public u64 as_u64_ort {
            get => Numerics.convert_to_u64_ort(_value);
        }

        public i32 as_i32_ort {
            get => Numerics.convert_to_i32_ort(_value);
        }

        public u32 as_u32_ort {
            get => Numerics.convert_to_u32_ort(_value);
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

        public u64 wrap_to_u64 => unchecked((ulong)_value);
        public i32 wrap_to_i32 => unchecked((int)_value);
        public u32 wrap_to_u32 => unchecked((uint)_value);
        public i16 wrap_to_i16 => unchecked((short)_value);
        public u16 wrap_to_u16 => unchecked((ushort)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        public static bool operator ==(i64 a, i64 b)
        {
            var result = (long)a == (long)b;
            return result;
        }

        public static bool operator !=(i64 a, i64 b)
        {
            var result = (long)a != (long)b;
            return result;
        }


        public static i64 operator +(i64 a, i64 b)
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
            return Numerics.object_equals_number(obj, _value);
        }
    }

}
