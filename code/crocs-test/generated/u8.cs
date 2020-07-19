
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct u8 : ICrocsObj
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

        
        public u16 as_u16 => _value;
        public u32 as_u32 => _value;
        public u64 as_u64 => _value;
        public i16 as_i16 => _value;
        public i32 as_i32 => _value;
        public i64 as_i64 => _value;

        public static implicit operator u16(u8 num) { return num._value; }
        public static implicit operator u32(u8 num) { return num._value; }
        public static implicit operator u64(u8 num) { return num._value; }
        public static implicit operator i16(u8 num) { return num._value; }
        public static implicit operator i32(u8 num) { return num._value; }
        public static implicit operator i64(u8 num) { return num._value; }

        public i8 as_i8_ort {
            get => Numerics.convert_to_i8_ort(_value);
        }

        public i8 wrap_to_i8 => unchecked((sbyte)_value);

        public static bool operator ==(u8 a, u8 b)
        {
            var result = (byte)a == (byte)b;
            return result;
        }

        public static bool operator !=(u8 a, u8 b)
        {
            var result = (byte)a != (byte)b;
            return result;
        }


        public static u8 operator +(u8 a, u8 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < u8.MIN) { throw new Exception("underflow!"); }
            if (value > u8.MAX) { throw new Exception("overflow!");  }
            u8 result = (byte)value;
            return result;
        }public static i16 operator +(u8 a, i16 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i16.MIN) { throw new Exception("underflow!"); }
            if (value > i16.MAX) { throw new Exception("overflow!");  }
            i16 result = (short)value;
            return result;
        }public static i32 operator +(u8 a, i32 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i32.MIN) { throw new Exception("underflow!"); }
            if (value > i32.MAX) { throw new Exception("overflow!");  }
            i32 result = (int)value;
            return result;
        }public static i64 operator +(u8 a, i64 b)
        {
            var value = (decimal)a + (decimal)b;
            
            i64 result = (long)value;
            return result;
        }public static u16 operator +(u8 a, u16 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < u16.MIN) { throw new Exception("underflow!"); }
            if (value > u16.MAX) { throw new Exception("overflow!");  }
            u16 result = (ushort)value;
            return result;
        }public static u32 operator +(u8 a, u32 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < u32.MIN) { throw new Exception("underflow!"); }
            if (value > u32.MAX) { throw new Exception("overflow!");  }
            u32 result = (uint)value;
            return result;
        }public static u64 operator +(u8 a, u64 b)
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
            return Numerics.object_equals_number(obj, _value);
        }
    }

}
