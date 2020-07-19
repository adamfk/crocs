
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{
    public struct i16 : ICrocsObj
    {
        private bool _destructed;

        public const short MAX = 32767;
        public const short MIN = -32768;

        private short _value;

        public i16(short value)
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

        public static implicit operator i16(short num) { return new i16(num); }
        public static implicit operator short(i16 num) { return num._value; }
        public static implicit operator decimal(i16 num) { return num._value; }

        
        public i32 as_i32 => _value;
        public i64 as_i64 => _value;

        public static implicit operator i32(i16 num) { return num._value; }
        public static implicit operator i64(i16 num) { return num._value; }

        public u16 as_u16_ort {
            get => Numerics.convert_to_u16_ort(_value);
        }

        public i8 as_i8_ort {
            get => Numerics.convert_to_i8_ort(_value);
        }

        public u8 as_u8_ort {
            get => Numerics.convert_to_u8_ort(_value);
        }

        public u16 wrap_to_u16 => unchecked((ushort)_value);
        public i8 wrap_to_i8 => unchecked((sbyte)_value);
        public u8 wrap_to_u8 => unchecked((byte)_value);

        public static bool operator ==(i16 a, i16 b)
        {
            var result = (short)a == (short)b;
            return result;
        }

        public static bool operator !=(i16 a, i16 b)
        {
            var result = (short)a != (short)b;
            return result;
        }


        public static i16 operator +(i16 a, i16 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i16.MIN) { throw new Exception("underflow!"); }
            if (value > i16.MAX) { throw new Exception("overflow!");  }
            i16 result = (short)value;
            return result;
        }public static i32 operator +(i16 a, i32 b)
        {
            var value = (decimal)a + (decimal)b;
            if (value < i32.MIN) { throw new Exception("underflow!"); }
            if (value > i32.MAX) { throw new Exception("overflow!");  }
            i32 result = (int)value;
            return result;
        }public static i64 operator +(i16 a, i64 b)
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
