
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct u32 : ICrocsObj, IHasU32
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

        //explicit widening conversions
        public u64 as_u64 => _value;
        public i64 as_i64 => _value;

        //implicit widening conversions
        public static implicit operator u64(u32 num) { return num._value; }
        public static implicit operator i64(u32 num) { return num._value; }

        //narrowing conversions
        public i32 as_i32_ort => Numerics.sim_convert_to_i32_ort(_value);
        public i16 as_i16_ort => Numerics.sim_convert_to_i16_ort(_value);
        public u16 as_u16_ort => Numerics.sim_convert_to_u16_ort(_value);
        public i8 as_i8_ort => Numerics.sim_convert_to_i8_ort(_value);
        public u8 as_u8_ort => Numerics.sim_convert_to_u8_ort(_value);

        //wrapping conversions
        public i32 wrap_to_i32 => Numerics.truncate_to_i32(_value);
        public i16 wrap_to_i16 => Numerics.truncate_to_i16(_value);
        public u16 wrap_to_u16 => Numerics.truncate_to_u16(_value);
        public i8 wrap_to_i8 => Numerics.truncate_to_i8(_value);
        public u8 wrap_to_u8 => Numerics.truncate_to_u8(_value);

        //comparison operators
        public static bool operator ==(u32 a, u32 b) => (uint)a == (uint)b;
        public static bool operator !=(u32 a, u32 b) => (uint)a != (uint)b;
        public static bool operator <(u32 a, u32 b) => (uint)a < (uint)b;
        public static bool operator >(u32 a, u32 b) => (uint)a > (uint)b;
        public static bool operator <=(u32 a, u32 b) => (uint)a <= (uint)b;
        public static bool operator >=(u32 a, u32 b) => (uint)a >= (uint)b;


        //overflowing operators
        public static u32 operator +(u32 a, u32 b) => Numerics.sim_convert_to_u32_ort((uint)a + (uint)b);
        public static i64 operator +(u32 a, IHasI8 b) => Numerics.sim_convert_to_i64_ort((uint)a + (sbyte)(i8)b);
        public static i64 operator +(u32 a, IHasI16 b) => Numerics.sim_convert_to_i64_ort((uint)a + (short)(i16)b);
        public static i64 operator +(u32 a, IHasI32 b) => Numerics.sim_convert_to_i64_ort((uint)a + (int)(i32)b);
        public static u64 operator +(u32 a, u64 b) => Numerics.sim_convert_to_u64_ort((uint)a + (ulong)b);
        public static u32 operator -(u32 a, u32 b) => Numerics.sim_convert_to_u32_ort((uint)a - (uint)b);
        public static i64 operator -(u32 a, IHasI8 b) => Numerics.sim_convert_to_i64_ort((uint)a - (sbyte)(i8)b);
        public static i64 operator -(u32 a, IHasI16 b) => Numerics.sim_convert_to_i64_ort((uint)a - (short)(i16)b);
        public static i64 operator -(u32 a, IHasI32 b) => Numerics.sim_convert_to_i64_ort((uint)a - (int)(i32)b);
        public static u64 operator -(u32 a, u64 b) => Numerics.sim_convert_to_u64_ort((uint)a - (ulong)b);
        public static u32 operator *(u32 a, u32 b) => Numerics.sim_convert_to_u32_ort((uint)a * (uint)b);
        public static i64 operator *(u32 a, IHasI8 b) => Numerics.sim_convert_to_i64_ort((uint)a * (sbyte)(i8)b);
        public static i64 operator *(u32 a, IHasI16 b) => Numerics.sim_convert_to_i64_ort((uint)a * (short)(i16)b);
        public static i64 operator *(u32 a, IHasI32 b) => Numerics.sim_convert_to_i64_ort((uint)a * (int)(i32)b);
        public static u64 operator *(u32 a, u64 b) => Numerics.sim_convert_to_u64_ort((uint)a * (ulong)b);
        public static u32 operator /(u32 a, u32 b) => Numerics.sim_convert_to_u32_ort((uint)a / (uint)b);
        public static i64 operator /(u32 a, IHasI8 b) => Numerics.sim_convert_to_i64_ort((uint)a / (sbyte)(i8)b);
        public static i64 operator /(u32 a, IHasI16 b) => Numerics.sim_convert_to_i64_ort((uint)a / (short)(i16)b);
        public static i64 operator /(u32 a, IHasI32 b) => Numerics.sim_convert_to_i64_ort((uint)a / (int)(i32)b);
        public static u64 operator /(u32 a, u64 b) => Numerics.sim_convert_to_u64_ort((uint)a / (ulong)b);
        public static u32 operator %(u32 a, u32 b) => Numerics.sim_convert_to_u32_ort((uint)a % (uint)b);
        public static i64 operator %(u32 a, IHasI8 b) => Numerics.sim_convert_to_i64_ort((uint)a % (sbyte)(i8)b);
        public static i64 operator %(u32 a, IHasI16 b) => Numerics.sim_convert_to_i64_ort((uint)a % (short)(i16)b);
        public static i64 operator %(u32 a, IHasI32 b) => Numerics.sim_convert_to_i64_ort((uint)a % (int)(i32)b);
        public static u64 operator %(u32 a, u64 b) => Numerics.sim_convert_to_u64_ort((uint)a % (ulong)b);
        //TODO add more operators

        //binary operators (only for unsigned)
        public static u32 operator |(u32 a, u32 b) => (u32)((uint)a | (uint)b);
        public static u64 operator |(u32 a, u64 b) => (u64)((uint)a | (ulong)b);
        public static u32 operator &(u32 a, u32 b) => (u32)((uint)a & (uint)b);
        public static u64 operator &(u32 a, u64 b) => (u64)((uint)a & (ulong)b);
        public static u32 operator ^(u32 a, u32 b) => (u32)((uint)a ^ (uint)b);
        public static u64 operator ^(u32 a, u64 b) => (u64)((uint)a ^ (ulong)b);
        public u32 shift_left_ort(u32 shift_amount) => Numerics.shift_left_ort(this, shift_amount);
        public u32 shift_right_ort(u32 shift_amount) => Numerics.shift_right_ort(this, shift_amount);
        public static u32 operator ~(u32 a) => (u32)(~(uint)a);

        public override string ToString() => _value.ToString();

        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj) => Numerics.object_equals_number(obj, _value);
    }

}
