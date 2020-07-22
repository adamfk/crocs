using crocs.lang;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;

//Problem: c# primitives don't implement IDisposable.
//This one is rather important... wouldn't want to create LinkedListObj<T> class and LinkedListPrimitive<T> class. No way.
//we need a common disposable root type.

namespace crocs.lang
{
    //these are needed to avoid implicit conversion confusion with integer literals when mixing signed and unsigned.
    // See https://github.com/adamfk/crocs/issues/12
    public interface IHasU8  { }
    public interface IHasU16 { }
    public interface IHasU32 { }
    public interface IHasU64 { }
    public interface IHasI8  { }
    public interface IHasI16 { }
    public interface IHasI32 { }
    public interface IHasI64 { }

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





        // Only throws for invalid shift amounts.
        public static u8 shift_right_ort(u8 value, u32 shift_amount)
        {
            if (shift_amount >= 8)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '8'");
            }
            return truncate_to_u8(value >> Numerics.convert_to_i32_ort(shift_amount));
        }

        //note will not throw if high bits truncated. Only throws for invalid shift amounts.
        public static u8 shift_left_ort(u8 value, u32 shift_amount)
        {
            if (shift_amount >= 8)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '8'");
            }
            return truncate_to_u8(value << Numerics.convert_to_i32_ort(shift_amount));
        }

        // Only throws for invalid shift amounts.
        public static u16 shift_right_ort(u16 value, u32 shift_amount)
        {
            if (shift_amount >= 16)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '16'");
            }
            return truncate_to_u16(value >> Numerics.convert_to_i32_ort(shift_amount));
        }

        //note will not throw if high bits truncated. Only throws for invalid shift amounts.
        public static u16 shift_left_ort(u16 value, u32 shift_amount)
        {
            if (shift_amount >= 16)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '16'");
            }
            return truncate_to_u16(value << Numerics.convert_to_i32_ort(shift_amount));
        }

        // Only throws for invalid shift amounts.
        public static u32 shift_right_ort(u32 value, u32 shift_amount)
        {
            if (shift_amount >= 32)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '32'");
            }
            return truncate_to_u32(value >> Numerics.convert_to_i32_ort(shift_amount));
        }

        //note will not throw if high bits truncated. Only throws for invalid shift amounts.
        public static u32 shift_left_ort(u32 value, u32 shift_amount)
        {
            if (shift_amount >= 32)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '32'");
            }
            return truncate_to_u32(value << Numerics.convert_to_i32_ort(shift_amount));
        }

        // Only throws for invalid shift amounts.
        public static u64 shift_right_ort(u64 value, u32 shift_amount)
        {
            if (shift_amount >= 64)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '64'");
            }
            return truncate_to_u64(value >> Numerics.convert_to_i32_ort(shift_amount));
        }

        //note will not throw if high bits truncated. Only throws for invalid shift amounts.
        public static u64 shift_left_ort(u64 value, u32 shift_amount)
        {
            if (shift_amount >= 64)
            {
                //TODOLOW consider and refine
                //https://stackoverflow.com/questions/18918256/is-right-shift-undefined-behavior-if-the-count-is-larger-than-the-width-of-the-t
                throw new System.OverflowException($"can't shift '{shift_amount}' by more than width of integer '64'");
            }
            return truncate_to_u64(value << Numerics.convert_to_i32_ort(shift_amount));
        }






        public static i8 convert_to_i8_ort(decimal value)
        {
            if (value > i8.MAX || value < i8.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i8");
            }
            return (sbyte)value;
        }

        public static i8 truncate_to_i8(decimal value)
        {
            return unchecked((sbyte)value);
        }

        public static i16 convert_to_i16_ort(decimal value)
        {
            if (value > i16.MAX || value < i16.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i16");
            }
            return (short)value;
        }

        public static i16 truncate_to_i16(decimal value)
        {
            return unchecked((short)value);
        }

        public static i32 convert_to_i32_ort(decimal value)
        {
            if (value > i32.MAX || value < i32.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i32");
            }
            return (int)value;
        }

        public static i32 truncate_to_i32(decimal value)
        {
            return unchecked((int)value);
        }

        public static i64 convert_to_i64_ort(decimal value)
        {
            if (value > i64.MAX || value < i64.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for i64");
            }
            return (long)value;
        }

        public static i64 truncate_to_i64(decimal value)
        {
            return unchecked((long)value);
        }

        public static u8 convert_to_u8_ort(decimal value)
        {
            if (value > u8.MAX || value < u8.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u8");
            }
            return (byte)value;
        }

        public static u8 truncate_to_u8(decimal value)
        {
            return unchecked((byte)value);
        }

        public static u16 convert_to_u16_ort(decimal value)
        {
            if (value > u16.MAX || value < u16.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u16");
            }
            return (ushort)value;
        }

        public static u16 truncate_to_u16(decimal value)
        {
            return unchecked((ushort)value);
        }

        public static u32 convert_to_u32_ort(decimal value)
        {
            if (value > u32.MAX || value < u32.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u32");
            }
            return (uint)value;
        }

        public static u32 truncate_to_u32(decimal value)
        {
            return unchecked((uint)value);
        }

        public static u64 convert_to_u64_ort(decimal value)
        {
            if (value > u64.MAX || value < u64.MIN)
            {
                throw new System.OverflowException("value " + value + " too large for u64");
            }
            return (ulong)value;
        }

        public static u64 truncate_to_u64(decimal value)
        {
            return unchecked((ulong)value);
        }


    }
}

namespace numerics_test
{
    public class Test
    {
        [Fact]
        public void hand_test1()
        {
            {
                i8 i8 = 1;
                u8 u8 = 1;
                var c = i8 + u8;
            }

            { u8 u8 = 255; Assert.True(u8 > 127); }

            //note how we don't need comparison overload for u8,u64 as u8 is promoted to u64
            { u8 u8 = 255; u64 u64 = u8; Assert.True(u8 == u64); }

            //for now, we let crocs ints to be promoted to c# primitive `int` for this comparison
            { u8 u8 = 127; i8 i8 = 127; Assert.True(u8 == i8); }

            { short a = 34; short b = 12; var c = a | b; Assert.IsType<int>(c); }

            { i16 a = 34; i16 b = 12; var c = a - b; Assert.IsType<i16>(c); Assert.Equal<i16>(22, c); }
        }
    }
}


