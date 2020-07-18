
//NOTE! AUTO GENERATED FILE
using System;
using RefExtendsPublic;

#pragma warning disable IDE1006 // Naming Styles

namespace torc.lang
{
    public class u32 : WiftObj, IHasU32
    {
        public const uint MAX = 4294967295;
        public const uint MIN = 0;

        protected uint _value;

        private u32()
        {
        }

        private u32(uint value)
        {
            _value = value;
        }

        private uint read_value => _value;

        internal static uint GetBackingValue(u32 n) { return n.read_value; }

        public u32 v
        {
            get
            {
                ThrowIfDestructed();
                return this.cp;
            }

            set
            {
                ThrowIfDestructed();
                this._value = value._value;
            }
        }

        public u32r r { get { return new u32r(this); } }

        /// <summary>
        /// creates a copy of u32 memory. Useful for when passing to functions.
        /// </summary>
        public u32 cp => new u32(read_value);

        public static implicit operator u32(uint num) { return new u32(num); }
        public static implicit operator uint(u32 num) { return num.read_value; }    //needed
        //public static implicit operator u32r(u32 num) { return new u32r(num); }

        
        public u64 as_u64 => v;
        public i64 as_i64 => v;

        public static implicit operator u64(u32 num) { return num.read_value; }
        public static implicit operator i64(u32 num) { return num.read_value; }

        public i32 as_i32_ort {
            get {
                var vv = GetBackingValue(this);
                decimal v = vv;
                if (v > i32.MAX || v < i32.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for i32");
                }
                return (int)vv;
            }
        }

        public i16 as_i16_ort {
            get {
                var vv = GetBackingValue(this);
                decimal v = vv;
                if (v > i16.MAX || v < i16.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for i16");
                }
                return (short)vv;
            }
        }

        public u16 as_u16_ort {
            get {
                var vv = GetBackingValue(this);
                decimal v = vv;
                if (v > u16.MAX || v < u16.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for u16");
                }
                return (ushort)vv;
            }
        }

        public i8 as_i8_ort {
            get {
                var vv = GetBackingValue(this);
                decimal v = vv;
                if (v > i8.MAX || v < i8.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for i8");
                }
                return (sbyte)vv;
            }
        }

        public u8 as_u8_ort {
            get {
                var vv = GetBackingValue(this);
                decimal v = vv;
                if (v > u8.MAX || v < u8.MIN)
                {
                    throw new System.OverflowException("value " + vv + " too large for u8");
                }
                return (byte)vv;
            }
        }

        public i32 wrap_to_i32 => unchecked((int)GetBackingValue(this));
        public i16 wrap_to_i16 => unchecked((short)GetBackingValue(this));
        public u16 wrap_to_u16 => unchecked((ushort)GetBackingValue(this));
        public i8 wrap_to_i8 => unchecked((sbyte)GetBackingValue(this));
        public u8 wrap_to_u8 => unchecked((byte)GetBackingValue(this));

        public static bool operator ==(u32 a, u32 b)
        {
            var result = a.read_value == b.read_value;
            return result;
        }

        public static bool operator !=(u32 a, u32 b)
        {
            var result = a.read_value != b.read_value;
            return result;
        }


        public static u32 operator +(u32 a, u32 b)
        {
            var value = u32.GetBackingValue(a) + u32.GetBackingValue(b);
            if (value < u32.MIN) { throw new Exception("underflow!"); }
            if (value > u32.MAX) { throw new Exception("overflow!");  }
            u32 result = (uint)value;
            return result;
        }public static i64 operator +(u32 a, IHasI8 b)
        {
            var value = u32.GetBackingValue(a) + i8.GetBackingValue((i8)b);
            
            i64 result = (long)value;
            return result;
        }public static i64 operator +(u32 a, IHasI16 b)
        {
            var value = u32.GetBackingValue(a) + i16.GetBackingValue((i16)b);
            
            i64 result = (long)value;
            return result;
        }public static i64 operator +(u32 a, IHasI32 b)
        {
            var value = u32.GetBackingValue(a) + i32.GetBackingValue((i32)b);
            
            i64 result = (long)value;
            return result;
        }public static i64 operator +(u32 a, i8 b)
        {
            var value = u32.GetBackingValue(a) + i8.GetBackingValue(b);
            
            i64 result = (long)value;
            return result;
        }public static i64 operator +(u32 a, i16 b)
        {
            var value = u32.GetBackingValue(a) + i16.GetBackingValue(b);
            
            i64 result = (long)value;
            return result;
        }public static i64 operator +(u32 a, i32 b)
        {
            var value = u32.GetBackingValue(a) + i32.GetBackingValue(b);
            
            i64 result = (long)value;
            return result;
        }public static i64 operator +(u32 a, i64 b)
        {
            var value = u32.GetBackingValue(a) + i64.GetBackingValue(b);
            
            i64 result = (long)value;
            return result;
        }public static u32 operator +(u32 a, u8 b)
        {
            var value = u32.GetBackingValue(a) + u8.GetBackingValue(b);
            if (value < u32.MIN) { throw new Exception("underflow!"); }
            if (value > u32.MAX) { throw new Exception("overflow!");  }
            u32 result = (uint)value;
            return result;
        }public static u32 operator +(u32 a, u16 b)
        {
            var value = u32.GetBackingValue(a) + u16.GetBackingValue(b);
            if (value < u32.MIN) { throw new Exception("underflow!"); }
            if (value > u32.MAX) { throw new Exception("overflow!");  }
            u32 result = (uint)value;
            return result;
        }public static u32 operator +(u32 a, u32 b)
        {
            var value = u32.GetBackingValue(a) + u32.GetBackingValue(b);
            if (value < u32.MIN) { throw new Exception("underflow!"); }
            if (value > u32.MAX) { throw new Exception("overflow!");  }
            u32 result = (uint)value;
            return result;
        }public static u64 operator +(u32 a, u64 b)
        {
            var value = u32.GetBackingValue(a) + u64.GetBackingValue(b);
            
            u64 result = (ulong)value;
            return result;
        }public static u64 operator +(u32 a, u64 b)
        {
            var value = u32.GetBackingValue(a) + u64.GetBackingValue(b);
            
            u64 result = (ulong)value;
            return result;
        }



        public override string ToString()
        {
            return read_value.ToString();
        }

        public override int GetHashCode()
        {
            return v.GetHashCode();
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

                case i8  i: value = i8.GetBackingValue(i);  break;
                case i16 i: value = i16.GetBackingValue(i); break;
                case i32 i: value = i32.GetBackingValue(i); break;
                case i64 i: value = i64.GetBackingValue(i); break;
                case u8  i: value = u8.GetBackingValue(i);  break;
                case u16 i: value = u16.GetBackingValue(i); break;
                case u32 i: value = u32.GetBackingValue(i); break;
                case u64 i: value = u64.GetBackingValue(i); break;

                default: return false;
            }

            if (value < MIN || value > MAX) { return false; }
            return value == (uint)value;
        }
    }

}
