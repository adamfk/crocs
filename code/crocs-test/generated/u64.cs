
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct u64 : ICrocsObj
    {
        private bool _destructed;

        public const ulong MAX = 18446744073709551615;
        public const ulong MIN = 0;

        private ulong _value;

        public u64(ulong value)
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

        public static implicit operator u64(ulong num) { return new u64(num); }
        public static implicit operator ulong(u64 num) { return num._value; }
        public static implicit operator decimal(u64 num) { return num._value; }

        //explicit widening conversions
        

        //implicit widening conversions
        

        //narrowing conversions
        public i64 as_i64_ort => Numerics.convert_to_i64_ort(_value);
        public i32 as_i32_ort => Numerics.convert_to_i32_ort(_value);
        public u32 as_u32_ort => Numerics.convert_to_u32_ort(_value);
        public i16 as_i16_ort => Numerics.convert_to_i16_ort(_value);
        public u16 as_u16_ort => Numerics.convert_to_u16_ort(_value);
        public i8 as_i8_ort => Numerics.convert_to_i8_ort(_value);
        public u8 as_u8_ort => Numerics.convert_to_u8_ort(_value);

        //wrapping conversions
        public i64 wrap_to_i64 => unchecked((long)_value);
        public i32 wrap_to_i32 => unchecked((int)_value);
        public u32 wrap_to_u32 => unchecked((uint)_value);
        public i16 wrap_to_i16 => unchecked((short)_value);
        public u16 wrap_to_u16 => unchecked((ushort)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        //comparison operators
        public static bool operator ==(u64 a, u64 b) => (ulong)a == (ulong)b;
        public static bool operator !=(u64 a, u64 b) => (ulong)a != (ulong)b;
        //TODO add more operators

        //overflowing operators
        public static u64 operator +(u64 a, u64 b) => Numerics.convert_to_u64_ort((decimal)a + (decimal)b);
        //TODO add more operators

        public override string ToString() => _value.ToString();

        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj) => Numerics.object_equals_number(obj, _value);
    }

}
