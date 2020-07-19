
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

        

        

        public i64 as_i64_ort {
            get => Numerics.convert_to_i64_ort(_value);
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

        public i64 wrap_to_i64 => unchecked((long)_value);
        public i32 wrap_to_i32 => unchecked((int)_value);
        public u32 wrap_to_u32 => unchecked((uint)_value);
        public i16 wrap_to_i16 => unchecked((short)_value);
        public u16 wrap_to_u16 => unchecked((ushort)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        public static bool operator ==(u64 a, u64 b)
        {
            var result = (ulong)a == (ulong)b;
            return result;
        }

        public static bool operator !=(u64 a, u64 b)
        {
            var result = (ulong)a != (ulong)b;
            return result;
        }


        public static u64 operator +(u64 a, u64 b)
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
            return value == (ulong)value;
        }
    }

}
