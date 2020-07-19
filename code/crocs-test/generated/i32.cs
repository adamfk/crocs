
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
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

        //explicit widening conversions
        
        public i64 as_i64 => _value;

        //implicit widening conversions
        public static implicit operator i64(i32 num) { return num._value; }

        //narrowing conversions
        public u32 as_u32_ort => Numerics.convert_to_u32_ort(_value);
        public i16 as_i16_ort => Numerics.convert_to_i16_ort(_value);
        public u16 as_u16_ort => Numerics.convert_to_u16_ort(_value);
        public i8 as_i8_ort => Numerics.convert_to_i8_ort(_value);
        public u8 as_u8_ort => Numerics.convert_to_u8_ort(_value);

        //wrapping conversions
        public u32 wrap_to_u32 => unchecked((uint)_value);
        public i16 wrap_to_i16 => unchecked((short)_value);
        public u16 wrap_to_u16 => unchecked((ushort)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        //comparison operators
        public static bool operator ==(i32 a, i32 b)  => (int)a == (int)b;
        public static bool operator !=(i32 a, i32 b)  => (int)a != (int)b;
        //TODO add more operators

        //overflowing operators
        public static i32 operator +(i32 a, i32 b)  => Numerics.convert_to_i32_ort((decimal)a + (decimal)b);
        public static i64 operator +(i32 a, i64 b)  => Numerics.convert_to_i64_ort((decimal)a + (decimal)b);


        //TODO add more operators

        public override string ToString() => _value.ToString();

        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj) => Numerics.object_equals_number(obj, _value);
    }

}
