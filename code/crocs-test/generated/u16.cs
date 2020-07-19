
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
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
            get => Numerics.convert_to_i16_ort(_value);
        }

        public i8 as_i8_ort {
            get => Numerics.convert_to_i8_ort(_value);
        }

        public u8 as_u8_ort {
            get => Numerics.convert_to_u8_ort(_value);
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


                public static u16 operator +(u16 a, u16 b)  => Numerics.convert_to_u16_ort((decimal)a + (decimal)b);
        public static i32 operator +(u16 a, i32 b)  => Numerics.convert_to_i32_ort((decimal)a + (decimal)b);
        public static i64 operator +(u16 a, i64 b)  => Numerics.convert_to_i64_ort((decimal)a + (decimal)b);
        public static u32 operator +(u16 a, u32 b)  => Numerics.convert_to_u32_ort((decimal)a + (decimal)b);
        public static u64 operator +(u16 a, u64 b)  => Numerics.convert_to_u64_ort((decimal)a + (decimal)b);




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
