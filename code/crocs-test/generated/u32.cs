
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

        public static bool operator ==(u32 a, u32 b)  => (uint)a == (uint)b;

        public static bool operator !=(u32 a, u32 b)  => (uint)a != (uint)b;


                public static u32 operator +(u32 a, u32 b)  => Numerics.convert_to_u32_ort((decimal)a + (decimal)b);
        public static i64 operator +(u32 a, i64 b)  => Numerics.convert_to_i64_ort((decimal)a + (decimal)b);
        public static u64 operator +(u32 a, u64 b)  => Numerics.convert_to_u64_ort((decimal)a + (decimal)b);




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
