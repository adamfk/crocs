
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct i8 : ICrocsObj, IHasI8
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

        //explicit widening conversions
        public i16 as_i16 => _value;
        public i32 as_i32 => _value;
        public i64 as_i64 => _value;

        //implicit widening conversions
        public static implicit operator i16(i8 num) { return num._value; }
        public static implicit operator i32(i8 num) { return num._value; }
        public static implicit operator i64(i8 num) { return num._value; }

        //narrowing conversions
        public u8 as_u8_ort => Numerics.convert_to_u8_ort(_value);

        //wrapping conversions
        public u8 wrap_to_u8 => unchecked((byte)_value);

        //comparison operators
        public static bool operator ==(i8 a, i8 b) => (sbyte)a == (sbyte)b;
        public static bool operator !=(i8 a, i8 b) => (sbyte)a != (sbyte)b;
        //TODO add more operators

        //overflowing operators
        public static i8 operator +(i8 a, i8 b) => Numerics.convert_to_i8_ort((decimal)a + (decimal)b);
        public static i16 operator +(i8 a, i16 b) => Numerics.convert_to_i16_ort((decimal)a + (decimal)b);
        public static i32 operator +(i8 a, i32 b) => Numerics.convert_to_i32_ort((decimal)a + (decimal)b);
        public static i64 operator +(i8 a, i64 b) => Numerics.convert_to_i64_ort((decimal)a + (decimal)b);
        //TODO add more operators

        public override string ToString() => _value.ToString();

        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj) => Numerics.object_equals_number(obj, _value);
    }

}
