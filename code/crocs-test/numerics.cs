using crocs.lang;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

//Problem: c# primitives don't implement IDisposable.
//This one is rather important... wouldn't want to create LinkedListObj<T> class and LinkedListPrimitive<T> class. No way.
//we need a common disposable root type.

using i8_psi = System.SByte;

namespace crocs.lang
{
    public class Numerics
    {
        public static bool object_equals_number(object obj, decimal value) {
            if (obj == null) { return false; }

            decimal obj_value;

            switch (obj)
            {
                case sbyte  i: obj_value = i; break;
                case short  i: obj_value = i; break;
                case int    i: obj_value = i; break;
                case long   i: obj_value = i; break;
                case byte   i: obj_value = i; break;
                case ushort i: obj_value = i; break;
                case uint   i: obj_value = i; break;
                case ulong  i: obj_value = i; break;

                case i8  i: obj_value = i;  break;
                case i16 i: obj_value = i; break;
                case i32 i: obj_value = i; break;
                case i64 i: obj_value = i; break;
                case u8  i: obj_value = i;  break;
                case u16 i: obj_value = i; break;
                case u32 i: obj_value = i; break;
                case u64 i: obj_value = i; break;

                default: return false;
            }

            return obj_value == value;
        }

        public static u64 convert_to_u64_ort(decimal value)
        {
            if (value > u64.MAX || value < u64.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u64");
            }
            return (ulong)value;
        }

        public static i64 convert_to_i64_ort(decimal value)
        {
            if (value > i64.MAX || value < i64.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i64");
            }
            return (long)value;
        }

        public static i32 convert_to_i32_ort(decimal value)
        {
            if (value > i32.MAX || value < i32.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i32");
            }
            return (int)value;
        }

        public static u32 convert_to_u32_ort(decimal value)
        {
            if (value > u32.MAX || value < u32.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u32");
            }
            return (uint)value;
        }

        public static i16 convert_to_i16_ort(decimal value)
        {
            if (value > i16.MAX || value < i16.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i16");
            }
            return (short)value;
        }

        public static u16 convert_to_u16_ort(decimal value)
        {
            if (value > u16.MAX || value < u16.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u16");
            }
            return (ushort)value;
        }

        public static i8 convert_to_i8_ort(decimal value)
        {
            if (value > i8.MAX || value < i8.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i8");
            }
            return (sbyte)value;
        }

        public static u8 convert_to_u8_ort(decimal value)
        {
            if (value > u8.MAX || value < u8.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u8");
            }
            return (byte)value;
        }

    }
}

namespace numerics_test
{
    public class Test
    {
        [Fact]
        public void test1()
        {
            i8 i8 = 1;
            u8 u8 = 1;
            { var c = i8 + u8; }
            
            u32 u32 = 1;
            { var c = i8 + u32; }
        }
    }

}
