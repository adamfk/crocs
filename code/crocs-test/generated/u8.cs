
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct u8 : ICrocsObj, IHasU8
    {
        private bool _destructed;

        public const byte MAX = 255;
        public const byte MIN = 0;

        private byte _value;

        public u8(byte value)
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

        public static implicit operator u8(byte num) { return new u8(num); }
        public static implicit operator byte(u8 num) { return num._value; }
        public static implicit operator decimal(u8 num) { return num._value; }

        //explicit widening conversions
        public u16 as_u16 => _value;
        public u32 as_u32 => _value;
        public u64 as_u64 => _value;
        public i16 as_i16 => _value;
        public i32 as_i32 => _value;
        public i64 as_i64 => _value;

        //implicit widening conversions
        public static implicit operator u16(u8 num) { return num._value; }
        public static implicit operator u32(u8 num) { return num._value; }
        public static implicit operator u64(u8 num) { return num._value; }
        public static implicit operator i16(u8 num) { return num._value; }
        public static implicit operator i32(u8 num) { return num._value; }
        public static implicit operator i64(u8 num) { return num._value; }

        //narrowing conversions
        public i8 as_i8_ort => Numerics.convert_to_i8_ort(_value);

        //wrapping conversions
        public i8 wrap_to_i8 => unchecked((sbyte)_value);

        //comparison operators
        public static bool operator ==(u8 a, u8 b) => (byte)a == (byte)b;
        public static bool operator !=(u8 a, u8 b) => (byte)a != (byte)b;
        //TODO add more operators

        //overflowing operators
        public static u8 operator +(u8 a, u8 b) => Numerics.convert_to_u8_ort((decimal)a + (decimal)b);
        public static i16 operator +(u8 a, IHasI8 b) => Numerics.convert_to_i16_ort((decimal)a + (decimal)(i8)b);
        public static u16 operator +(u8 a, u16 b) => Numerics.convert_to_u16_ort((decimal)a + (decimal)b);
        public static u32 operator +(u8 a, u32 b) => Numerics.convert_to_u32_ort((decimal)a + (decimal)b);
        public static u64 operator +(u8 a, u64 b) => Numerics.convert_to_u64_ort((decimal)a + (decimal)b);
        //TODO add more operators

        public override string ToString() => _value.ToString();

        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj) => Numerics.object_equals_number(obj, _value);
    }

}
