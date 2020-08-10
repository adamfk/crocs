
//NOTE! AUTO GENERATED

using crocs.lang;
using Xunit;

namespace crocs_tests
{
    public class AllNumericTests 
    {
        
        //NOTE! AUTO GENERATED
        [Fact]
        public void LiteralToType()
        {
            { i8 n = 0; Assert.Equal<i8>(0, n); }
            { i8 n = 0; Assert.Equal<i8>(0b0, n); }
            { i8 n = -1; Assert.Equal<i8>(-1, n); }
            { i8 n = -1; Assert.Equal<i8>(unchecked((sbyte)0b1111_1111), n); }
            { i8 n = 1; Assert.Equal<i8>(1, n); }
            { i8 n = 1; Assert.Equal<i8>(0b1, n); }
            { i8 n = -128; Assert.Equal<i8>(-128, n); }
            { i8 n = -128; Assert.Equal<i8>(unchecked((sbyte)0b1000_0000), n); }
            { i8 n = 127; Assert.Equal<i8>(127, n); }
            { i8 n = 127; Assert.Equal<i8>(0b1111_111, n); }

            { i16 n = 0; Assert.Equal<i16>(0, n); }
            { i16 n = 0; Assert.Equal<i16>(0b0, n); }
            { i16 n = -1; Assert.Equal<i16>(-1, n); }
            { i16 n = -1; Assert.Equal<i16>(unchecked((short)0b1111_1111_1111_1111), n); }
            { i16 n = 1; Assert.Equal<i16>(1, n); }
            { i16 n = 1; Assert.Equal<i16>(0b1, n); }
            { i16 n = -32768; Assert.Equal<i16>(-32768, n); }
            { i16 n = -32768; Assert.Equal<i16>(unchecked((short)0b1000_0000_0000_0000), n); }
            { i16 n = 32767; Assert.Equal<i16>(32767, n); }
            { i16 n = 32767; Assert.Equal<i16>(0b1111_1111_1111_111, n); }

            { i32 n = 0; Assert.Equal<i32>(0, n); }
            { i32 n = 0; Assert.Equal<i32>(0b0, n); }
            { i32 n = -1; Assert.Equal<i32>(-1, n); }
            { i32 n = -1; Assert.Equal<i32>(unchecked((int)0b1111_1111_1111_1111_1111_1111_1111_1111), n); }
            { i32 n = 1; Assert.Equal<i32>(1, n); }
            { i32 n = 1; Assert.Equal<i32>(0b1, n); }
            { i32 n = -2147483648; Assert.Equal<i32>(-2147483648, n); }
            { i32 n = -2147483648; Assert.Equal<i32>(unchecked((int)0b1000_0000_0000_0000_0000_0000_0000_0000), n); }
            { i32 n = 2147483647; Assert.Equal<i32>(2147483647, n); }
            { i32 n = 2147483647; Assert.Equal<i32>(0b1111_1111_1111_1111_1111_1111_1111_111, n); }

            { i64 n = 0; Assert.Equal<i64>(0, n); }
            { i64 n = 0; Assert.Equal<i64>(0b0, n); }
            { i64 n = -1; Assert.Equal<i64>(-1, n); }
            { i64 n = -1; Assert.Equal<i64>(unchecked((long)0b1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111), n); }
            { i64 n = 1; Assert.Equal<i64>(1, n); }
            { i64 n = 1; Assert.Equal<i64>(0b1, n); }
            { i64 n = -9223372036854775808; Assert.Equal<i64>(-9223372036854775808, n); }
            { i64 n = -9223372036854775808; Assert.Equal<i64>(unchecked((long)0b1000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000), n); }
            { i64 n = 9223372036854775807; Assert.Equal<i64>(9223372036854775807, n); }
            { i64 n = 9223372036854775807; Assert.Equal<i64>(0b1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_111, n); }

            { u8 n = 1; Assert.Equal<u8>(1, n); }
            { u8 n = 1; Assert.Equal<u8>(0b1, n); }
            { u8 n = 0; Assert.Equal<u8>(0, n); }
            { u8 n = 0; Assert.Equal<u8>(0b0, n); }
            { u8 n = 255; Assert.Equal<u8>(255, n); }
            { u8 n = 255; Assert.Equal<u8>(0b1111_1111, n); }

            { u16 n = 1; Assert.Equal<u16>(1, n); }
            { u16 n = 1; Assert.Equal<u16>(0b1, n); }
            { u16 n = 0; Assert.Equal<u16>(0, n); }
            { u16 n = 0; Assert.Equal<u16>(0b0, n); }
            { u16 n = 65535; Assert.Equal<u16>(65535, n); }
            { u16 n = 65535; Assert.Equal<u16>(0b1111_1111_1111_1111, n); }

            { u32 n = 1; Assert.Equal<u32>(1, n); }
            { u32 n = 1; Assert.Equal<u32>(0b1, n); }
            { u32 n = 0; Assert.Equal<u32>(0, n); }
            { u32 n = 0; Assert.Equal<u32>(0b0, n); }
            { u32 n = 4294967295; Assert.Equal<u32>(4294967295, n); }
            { u32 n = 4294967295; Assert.Equal<u32>(0b1111_1111_1111_1111_1111_1111_1111_1111, n); }

            { u64 n = 1; Assert.Equal<u64>(1, n); }
            { u64 n = 1; Assert.Equal<u64>(0b1, n); }
            { u64 n = 0; Assert.Equal<u64>(0, n); }
            { u64 n = 0; Assert.Equal<u64>(0b0, n); }
            { u64 n = 18446744073709551615; Assert.Equal<u64>(18446744073709551615, n); }
            { u64 n = 18446744073709551615; Assert.Equal<u64>(0b1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111_1111, n); }
        }

        
        //NOTE! AUTO GENERATED
        [Fact]
        public void WideningConversions()
        {
            { i8 n = 127; i16 wider = n; Assert.Equal<i16>(127, wider); Assert.Equal<i16>(127, wider);}
            { i8 n = 127; i32 wider = n; Assert.Equal<i32>(127, wider); Assert.Equal<i32>(127, wider);}
            { i8 n = 127; i64 wider = n; Assert.Equal<i64>(127, wider); Assert.Equal<i64>(127, wider);}

            { i16 n = 32767; i32 wider = n; Assert.Equal<i32>(32767, wider); Assert.Equal<i32>(32767, wider);}
            { i16 n = 32767; i64 wider = n; Assert.Equal<i64>(32767, wider); Assert.Equal<i64>(32767, wider);}

            { i32 n = 2147483647; i64 wider = n; Assert.Equal<i64>(2147483647, wider); Assert.Equal<i64>(2147483647, wider);}


            { u8 n = 255; u16 wider = n; Assert.Equal<u16>(255, wider); Assert.Equal<u16>(255, wider);}
            { u8 n = 255; u32 wider = n; Assert.Equal<u32>(255, wider); Assert.Equal<u32>(255, wider);}
            { u8 n = 255; u64 wider = n; Assert.Equal<u64>(255, wider); Assert.Equal<u64>(255, wider);}
            { u8 n = 255; i16 wider = n; Assert.Equal<i16>(255, wider); Assert.Equal<i16>(255, wider);}
            { u8 n = 255; i32 wider = n; Assert.Equal<i32>(255, wider); Assert.Equal<i32>(255, wider);}
            { u8 n = 255; i64 wider = n; Assert.Equal<i64>(255, wider); Assert.Equal<i64>(255, wider);}

            { u16 n = 65535; u32 wider = n; Assert.Equal<u32>(65535, wider); Assert.Equal<u32>(65535, wider);}
            { u16 n = 65535; u64 wider = n; Assert.Equal<u64>(65535, wider); Assert.Equal<u64>(65535, wider);}
            { u16 n = 65535; i32 wider = n; Assert.Equal<i32>(65535, wider); Assert.Equal<i32>(65535, wider);}
            { u16 n = 65535; i64 wider = n; Assert.Equal<i64>(65535, wider); Assert.Equal<i64>(65535, wider);}

            { u32 n = 4294967295; u64 wider = n; Assert.Equal<u64>(4294967295, wider); Assert.Equal<u64>(4294967295, wider);}
            { u32 n = 4294967295; i64 wider = n; Assert.Equal<i64>(4294967295, wider); Assert.Equal<i64>(4294967295, wider);}
        }

        
        //NOTE! AUTO GENERATED
        [Fact]
        public void AdditionTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { i8 result = i8 + i8; Assert.Equal<i8>(2, result); }
            { i8 result = i8 + 126; Assert.Equal<i8>(127, result); }
            { i16 result = i8 + i16; Assert.Equal<i16>(2, result); }
            { i16 result = i8 + 32766; Assert.Equal<i16>(32767, result); }
            { i32 result = i8 + i32; Assert.Equal<i32>(2, result); }
            { i32 result = i8 + 2147483646; Assert.Equal<i32>(2147483647, result); }
            { i64 result = i8 + i64; Assert.Equal<i64>(2, result); }
            { i64 result = i8 + 9223372036854775806; Assert.Equal<i64>(9223372036854775807, result); }
            { i16 result = i8 + u8; Assert.Equal<i16>(2, result); }
            { i16 result = i8 + 254; Assert.Equal<i16>(255, result); }
            { i32 result = i8 + u16; Assert.Equal<i32>(2, result); }
            { i32 result = i8 + 65534; Assert.Equal<i32>(65535, result); }
            { i64 result = i8 + u32; Assert.Equal<i64>(2, result); }
            { i64 result = i8 + 4294967294; Assert.Equal<i64>(4294967295, result); }

            { i16 result = i16 + i8; Assert.Equal<i16>(2, result); }
            { i16 result = i16 + 126; Assert.Equal<i16>(127, result); }
            { i16 result = i16 + i16; Assert.Equal<i16>(2, result); }
            { i16 result = i16 + 32766; Assert.Equal<i16>(32767, result); }
            { i32 result = i16 + i32; Assert.Equal<i32>(2, result); }
            { i32 result = i16 + 2147483646; Assert.Equal<i32>(2147483647, result); }
            { i64 result = i16 + i64; Assert.Equal<i64>(2, result); }
            { i64 result = i16 + 9223372036854775806; Assert.Equal<i64>(9223372036854775807, result); }
            { i16 result = i16 + u8; Assert.Equal<i16>(2, result); }
            { i16 result = i16 + 254; Assert.Equal<i16>(255, result); }
            { i32 result = i16 + u16; Assert.Equal<i32>(2, result); }
            { i32 result = i16 + 65534; Assert.Equal<i32>(65535, result); }
            { i64 result = i16 + u32; Assert.Equal<i64>(2, result); }
            { i64 result = i16 + 4294967294; Assert.Equal<i64>(4294967295, result); }

            { i32 result = i32 + i8; Assert.Equal<i32>(2, result); }
            { i32 result = i32 + 126; Assert.Equal<i32>(127, result); }
            { i32 result = i32 + i16; Assert.Equal<i32>(2, result); }
            { i32 result = i32 + 32766; Assert.Equal<i32>(32767, result); }
            { i32 result = i32 + i32; Assert.Equal<i32>(2, result); }
            { i32 result = i32 + 2147483646; Assert.Equal<i32>(2147483647, result); }
            { i64 result = i32 + i64; Assert.Equal<i64>(2, result); }
            { i64 result = i32 + 9223372036854775806; Assert.Equal<i64>(9223372036854775807, result); }
            { i32 result = i32 + u8; Assert.Equal<i32>(2, result); }
            { i32 result = i32 + 254; Assert.Equal<i32>(255, result); }
            { i32 result = i32 + u16; Assert.Equal<i32>(2, result); }
            { i32 result = i32 + 65534; Assert.Equal<i32>(65535, result); }
            { i64 result = i32 + u32; Assert.Equal<i64>(2, result); }
            { i64 result = i32 + 4294967294; Assert.Equal<i64>(4294967295, result); }

            { i64 result = i64 + i8; Assert.Equal<i64>(2, result); }
            { i64 result = i64 + 126; Assert.Equal<i64>(127, result); }
            { i64 result = i64 + i16; Assert.Equal<i64>(2, result); }
            { i64 result = i64 + 32766; Assert.Equal<i64>(32767, result); }
            { i64 result = i64 + i32; Assert.Equal<i64>(2, result); }
            { i64 result = i64 + 2147483646; Assert.Equal<i64>(2147483647, result); }
            { i64 result = i64 + i64; Assert.Equal<i64>(2, result); }
            { i64 result = i64 + 9223372036854775806; Assert.Equal<i64>(9223372036854775807, result); }
            { i64 result = i64 + u8; Assert.Equal<i64>(2, result); }
            { i64 result = i64 + 254; Assert.Equal<i64>(255, result); }
            { i64 result = i64 + u16; Assert.Equal<i64>(2, result); }
            { i64 result = i64 + 65534; Assert.Equal<i64>(65535, result); }
            { i64 result = i64 + u32; Assert.Equal<i64>(2, result); }
            { i64 result = i64 + 4294967294; Assert.Equal<i64>(4294967295, result); }

            { i16 result = u8 + i8; Assert.Equal<i16>(2, result); }
            { u8 result = u8 + 126; Assert.Equal<u8>(127, result); }
            { i16 result = u8 + i16; Assert.Equal<i16>(2, result); }
            { u16 result = u8 + 32766; Assert.Equal<u16>(32767, result); }
            { i32 result = u8 + i32; Assert.Equal<i32>(2, result); }
            { u32 result = u8 + 2147483646; Assert.Equal<u32>(2147483647, result); }
            { i64 result = u8 + i64; Assert.Equal<i64>(2, result); }
            { u64 result = u8 + 9223372036854775806; Assert.Equal<u64>(9223372036854775807, result); }
            { u8 result = u8 + u8; Assert.Equal<u8>(2, result); }
            { u8 result = u8 + 254; Assert.Equal<u8>(255, result); }
            { u16 result = u8 + u16; Assert.Equal<u16>(2, result); }
            { u16 result = u8 + 65534; Assert.Equal<u16>(65535, result); }
            { u32 result = u8 + u32; Assert.Equal<u32>(2, result); }
            { u32 result = u8 + 4294967294; Assert.Equal<u32>(4294967295, result); }
            { u64 result = u8 + u64; Assert.Equal<u64>(2, result); }
            { u64 result = u8 + 18446744073709551614; Assert.Equal<u64>(18446744073709551615, result); }

            { i32 result = u16 + i8; Assert.Equal<i32>(2, result); }
            { u16 result = u16 + 126; Assert.Equal<u16>(127, result); }
            { i32 result = u16 + i16; Assert.Equal<i32>(2, result); }
            { u16 result = u16 + 32766; Assert.Equal<u16>(32767, result); }
            { i32 result = u16 + i32; Assert.Equal<i32>(2, result); }
            { u32 result = u16 + 2147483646; Assert.Equal<u32>(2147483647, result); }
            { i64 result = u16 + i64; Assert.Equal<i64>(2, result); }
            { u64 result = u16 + 9223372036854775806; Assert.Equal<u64>(9223372036854775807, result); }
            { u16 result = u16 + u8; Assert.Equal<u16>(2, result); }
            { u16 result = u16 + 254; Assert.Equal<u16>(255, result); }
            { u16 result = u16 + u16; Assert.Equal<u16>(2, result); }
            { u16 result = u16 + 65534; Assert.Equal<u16>(65535, result); }
            { u32 result = u16 + u32; Assert.Equal<u32>(2, result); }
            { u32 result = u16 + 4294967294; Assert.Equal<u32>(4294967295, result); }
            { u64 result = u16 + u64; Assert.Equal<u64>(2, result); }
            { u64 result = u16 + 18446744073709551614; Assert.Equal<u64>(18446744073709551615, result); }

            { i64 result = u32 + i8; Assert.Equal<i64>(2, result); }
            { u32 result = u32 + 126; Assert.Equal<u32>(127, result); }
            { i64 result = u32 + i16; Assert.Equal<i64>(2, result); }
            { u32 result = u32 + 32766; Assert.Equal<u32>(32767, result); }
            { i64 result = u32 + i32; Assert.Equal<i64>(2, result); }
            { u32 result = u32 + 2147483646; Assert.Equal<u32>(2147483647, result); }
            { i64 result = u32 + i64; Assert.Equal<i64>(2, result); }
            { u64 result = u32 + 9223372036854775806; Assert.Equal<u64>(9223372036854775807, result); }
            { u32 result = u32 + u8; Assert.Equal<u32>(2, result); }
            { u32 result = u32 + 254; Assert.Equal<u32>(255, result); }
            { u32 result = u32 + u16; Assert.Equal<u32>(2, result); }
            { u32 result = u32 + 65534; Assert.Equal<u32>(65535, result); }
            { u32 result = u32 + u32; Assert.Equal<u32>(2, result); }
            { u32 result = u32 + 4294967294; Assert.Equal<u32>(4294967295, result); }
            { u64 result = u32 + u64; Assert.Equal<u64>(2, result); }
            { u64 result = u32 + 18446744073709551614; Assert.Equal<u64>(18446744073709551615, result); }

            { u64 result = u64 + u8; Assert.Equal<u64>(2, result); }
            { u64 result = u64 + 254; Assert.Equal<u64>(255, result); }
            { u64 result = u64 + u16; Assert.Equal<u64>(2, result); }
            { u64 result = u64 + 65534; Assert.Equal<u64>(65535, result); }
            { u64 result = u64 + u32; Assert.Equal<u64>(2, result); }
            { u64 result = u64 + 4294967294; Assert.Equal<u64>(4294967295, result); }
            { u64 result = u64 + u64; Assert.Equal<u64>(2, result); }
            { u64 result = u64 + 18446744073709551614; Assert.Equal<u64>(18446744073709551615, result); }
        }

        //NOTE! AUTO GENERATED
        [Fact]
        public void AdditionImplicitTypeTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { var result = i8 + i8; Assert.IsType<i8>(result); Assert.Equal<i8>(2, result); }
            { var result = i8 + 126; Assert.IsType<i8>(result); Assert.Equal<i8>(127, result); }
            { var result = i8 + i16; Assert.IsType<i16>(result); Assert.Equal<i16>(2, result); }
            { var result = i8 + 32766; Assert.IsType<i16>(result); Assert.Equal<i16>(32767, result); }
            { var result = i8 + i32; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i8 + 2147483646; Assert.IsType<i32>(result); Assert.Equal<i32>(2147483647, result); }
            { var result = i8 + i64; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i8 + 9223372036854775806; Assert.IsType<i64>(result); Assert.Equal<i64>(9223372036854775807, result); }
            { var result = i8 + u8; Assert.IsType<i16>(result); Assert.Equal<i16>(2, result); }
            { var result = i8 + 254; Assert.IsType<i16>(result); Assert.Equal<i16>(255, result); }
            { var result = i8 + u16; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i8 + 65534; Assert.IsType<i32>(result); Assert.Equal<i32>(65535, result); }
            { var result = i8 + u32; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i8 + 4294967294; Assert.IsType<i64>(result); Assert.Equal<i64>(4294967295, result); }
            { var result = i16 + i8; Assert.IsType<i16>(result); Assert.Equal<i16>(2, result); }
            { var result = i16 + 126; Assert.IsType<i16>(result); Assert.Equal<i16>(127, result); }
            { var result = i16 + i16; Assert.IsType<i16>(result); Assert.Equal<i16>(2, result); }
            { var result = i16 + 32766; Assert.IsType<i16>(result); Assert.Equal<i16>(32767, result); }
            { var result = i16 + i32; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i16 + 2147483646; Assert.IsType<i32>(result); Assert.Equal<i32>(2147483647, result); }
            { var result = i16 + i64; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i16 + 9223372036854775806; Assert.IsType<i64>(result); Assert.Equal<i64>(9223372036854775807, result); }
            { var result = i16 + u8; Assert.IsType<i16>(result); Assert.Equal<i16>(2, result); }
            { var result = i16 + 254; Assert.IsType<i16>(result); Assert.Equal<i16>(255, result); }
            { var result = i16 + u16; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i16 + 65534; Assert.IsType<i32>(result); Assert.Equal<i32>(65535, result); }
            { var result = i16 + u32; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i16 + 4294967294; Assert.IsType<i64>(result); Assert.Equal<i64>(4294967295, result); }
            { var result = i32 + i8; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i32 + 126; Assert.IsType<i32>(result); Assert.Equal<i32>(127, result); }
            { var result = i32 + i16; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i32 + 32766; Assert.IsType<i32>(result); Assert.Equal<i32>(32767, result); }
            { var result = i32 + i32; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i32 + 2147483646; Assert.IsType<i32>(result); Assert.Equal<i32>(2147483647, result); }
            { var result = i32 + i64; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i32 + 9223372036854775806; Assert.IsType<i64>(result); Assert.Equal<i64>(9223372036854775807, result); }
            { var result = i32 + u8; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i32 + 254; Assert.IsType<i32>(result); Assert.Equal<i32>(255, result); }
            { var result = i32 + u16; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = i32 + 65534; Assert.IsType<i32>(result); Assert.Equal<i32>(65535, result); }
            { var result = i32 + u32; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i32 + 4294967294; Assert.IsType<i64>(result); Assert.Equal<i64>(4294967295, result); }
            { var result = i64 + i8; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i64 + 126; Assert.IsType<i64>(result); Assert.Equal<i64>(127, result); }
            { var result = i64 + i16; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i64 + 32766; Assert.IsType<i64>(result); Assert.Equal<i64>(32767, result); }
            { var result = i64 + i32; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i64 + 2147483646; Assert.IsType<i64>(result); Assert.Equal<i64>(2147483647, result); }
            { var result = i64 + i64; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i64 + 9223372036854775806; Assert.IsType<i64>(result); Assert.Equal<i64>(9223372036854775807, result); }
            { var result = i64 + u8; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i64 + 254; Assert.IsType<i64>(result); Assert.Equal<i64>(255, result); }
            { var result = i64 + u16; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i64 + 65534; Assert.IsType<i64>(result); Assert.Equal<i64>(65535, result); }
            { var result = i64 + u32; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = i64 + 4294967294; Assert.IsType<i64>(result); Assert.Equal<i64>(4294967295, result); }
            { var result = u8 + i8; Assert.IsType<i16>(result); Assert.Equal<i16>(2, result); }
            { var result = u8 + 126; Assert.IsType<u8>(result); Assert.Equal<u8>(127, result); }
            { var result = u8 + i16; Assert.IsType<i16>(result); Assert.Equal<i16>(2, result); }
            { var result = u8 + 32766; Assert.IsType<u16>(result); Assert.Equal<u16>(32767, result); }
            { var result = u8 + i32; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = u8 + 2147483646; Assert.IsType<u32>(result); Assert.Equal<u32>(2147483647, result); }
            { var result = u8 + i64; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = u8 + 9223372036854775806; Assert.IsType<u64>(result); Assert.Equal<u64>(9223372036854775807, result); }
            { var result = u8 + u8; Assert.IsType<u8>(result); Assert.Equal<u8>(2, result); }
            { var result = u8 + 254; Assert.IsType<u8>(result); Assert.Equal<u8>(255, result); }
            { var result = u8 + u16; Assert.IsType<u16>(result); Assert.Equal<u16>(2, result); }
            { var result = u8 + 65534; Assert.IsType<u16>(result); Assert.Equal<u16>(65535, result); }
            { var result = u8 + u32; Assert.IsType<u32>(result); Assert.Equal<u32>(2, result); }
            { var result = u8 + 4294967294; Assert.IsType<u32>(result); Assert.Equal<u32>(4294967295, result); }
            { var result = u8 + u64; Assert.IsType<u64>(result); Assert.Equal<u64>(2, result); }
            { var result = u8 + 18446744073709551614; Assert.IsType<u64>(result); Assert.Equal<u64>(18446744073709551615, result); }
            { var result = u16 + i8; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = u16 + 126; Assert.IsType<u16>(result); Assert.Equal<u16>(127, result); }
            { var result = u16 + i16; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = u16 + 32766; Assert.IsType<u16>(result); Assert.Equal<u16>(32767, result); }
            { var result = u16 + i32; Assert.IsType<i32>(result); Assert.Equal<i32>(2, result); }
            { var result = u16 + 2147483646; Assert.IsType<u32>(result); Assert.Equal<u32>(2147483647, result); }
            { var result = u16 + i64; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = u16 + 9223372036854775806; Assert.IsType<u64>(result); Assert.Equal<u64>(9223372036854775807, result); }
            { var result = u16 + u8; Assert.IsType<u16>(result); Assert.Equal<u16>(2, result); }
            { var result = u16 + 254; Assert.IsType<u16>(result); Assert.Equal<u16>(255, result); }
            { var result = u16 + u16; Assert.IsType<u16>(result); Assert.Equal<u16>(2, result); }
            { var result = u16 + 65534; Assert.IsType<u16>(result); Assert.Equal<u16>(65535, result); }
            { var result = u16 + u32; Assert.IsType<u32>(result); Assert.Equal<u32>(2, result); }
            { var result = u16 + 4294967294; Assert.IsType<u32>(result); Assert.Equal<u32>(4294967295, result); }
            { var result = u16 + u64; Assert.IsType<u64>(result); Assert.Equal<u64>(2, result); }
            { var result = u16 + 18446744073709551614; Assert.IsType<u64>(result); Assert.Equal<u64>(18446744073709551615, result); }
            { var result = u32 + i8; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = u32 + 126; Assert.IsType<u32>(result); Assert.Equal<u32>(127, result); }
            { var result = u32 + i16; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = u32 + 32766; Assert.IsType<u32>(result); Assert.Equal<u32>(32767, result); }
            { var result = u32 + i32; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = u32 + 2147483646; Assert.IsType<u32>(result); Assert.Equal<u32>(2147483647, result); }
            { var result = u32 + i64; Assert.IsType<i64>(result); Assert.Equal<i64>(2, result); }
            { var result = u32 + 9223372036854775806; Assert.IsType<u64>(result); Assert.Equal<u64>(9223372036854775807, result); }
            { var result = u32 + u8; Assert.IsType<u32>(result); Assert.Equal<u32>(2, result); }
            { var result = u32 + 254; Assert.IsType<u32>(result); Assert.Equal<u32>(255, result); }
            { var result = u32 + u16; Assert.IsType<u32>(result); Assert.Equal<u32>(2, result); }
            { var result = u32 + 65534; Assert.IsType<u32>(result); Assert.Equal<u32>(65535, result); }
            { var result = u32 + u32; Assert.IsType<u32>(result); Assert.Equal<u32>(2, result); }
            { var result = u32 + 4294967294; Assert.IsType<u32>(result); Assert.Equal<u32>(4294967295, result); }
            { var result = u32 + u64; Assert.IsType<u64>(result); Assert.Equal<u64>(2, result); }
            { var result = u32 + 18446744073709551614; Assert.IsType<u64>(result); Assert.Equal<u64>(18446744073709551615, result); }
            { var result = u64 + u8; Assert.IsType<u64>(result); Assert.Equal<u64>(2, result); }
            { var result = u64 + 254; Assert.IsType<u64>(result); Assert.Equal<u64>(255, result); }
            { var result = u64 + u16; Assert.IsType<u64>(result); Assert.Equal<u64>(2, result); }
            { var result = u64 + 65534; Assert.IsType<u64>(result); Assert.Equal<u64>(65535, result); }
            { var result = u64 + u32; Assert.IsType<u64>(result); Assert.Equal<u64>(2, result); }
            { var result = u64 + 4294967294; Assert.IsType<u64>(result); Assert.Equal<u64>(4294967295, result); }
            { var result = u64 + u64; Assert.IsType<u64>(result); Assert.Equal<u64>(2, result); }
            { var result = u64 + 18446744073709551614; Assert.IsType<u64>(result); Assert.Equal<u64>(18446744073709551615, result); }
        }

        //NOTE! AUTO GENERATED
        [Fact]
        public void SubtractionTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { i8 result = i8 - i8; Assert.Equal<i8>(0, result); }
            { var result = i8 - i8; Assert.IsType<i8>(result); Assert.Equal<i8>(0, result); }
            { var result = i8 - 1; Assert.IsType<i8>(result); Assert.Equal<i8>(0, result); }
            { i16 result = i8 - i16; Assert.Equal<i16>(0, result); }
            { var result = i8 - i16; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { var result = i8 - 1; Assert.IsType<i8>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i8 - i32; Assert.Equal<i32>(0, result); }
            { var result = i8 - i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i8 - 1; Assert.IsType<i8>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i8 - i64; Assert.Equal<i64>(0, result); }
            { var result = i8 - i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i8 - 1; Assert.IsType<i8>(result); Assert.Equal<i64>(0, result); }
            { i16 result = i8 - u8; Assert.Equal<i16>(0, result); }
            { var result = i8 - u8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { var result = i8 - 1; Assert.IsType<i8>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i8 - u16; Assert.Equal<i32>(0, result); }
            { var result = i8 - u16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i8 - 1; Assert.IsType<i8>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i8 - u32; Assert.Equal<i64>(0, result); }
            { var result = i8 - u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i8 - 1; Assert.IsType<i8>(result); Assert.Equal<i64>(0, result); }
            { i16 result = i16 - i8; Assert.Equal<i16>(0, result); }
            { var result = i16 - i8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { var result = i16 - 1; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i16 result = i16 - i16; Assert.Equal<i16>(0, result); }
            { var result = i16 - i16; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { var result = i16 - 1; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i16 - i32; Assert.Equal<i32>(0, result); }
            { var result = i16 - i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i16 - 1; Assert.IsType<i16>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i16 - i64; Assert.Equal<i64>(0, result); }
            { var result = i16 - i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i16 - 1; Assert.IsType<i16>(result); Assert.Equal<i64>(0, result); }
            { i16 result = i16 - u8; Assert.Equal<i16>(0, result); }
            { var result = i16 - u8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { var result = i16 - 1; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i16 - u16; Assert.Equal<i32>(0, result); }
            { var result = i16 - u16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i16 - 1; Assert.IsType<i16>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i16 - u32; Assert.Equal<i64>(0, result); }
            { var result = i16 - u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i16 - 1; Assert.IsType<i16>(result); Assert.Equal<i64>(0, result); }
            { i32 result = i32 - i8; Assert.Equal<i32>(0, result); }
            { var result = i32 - i8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i32 - 1; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = i32 - i16; Assert.Equal<i32>(0, result); }
            { var result = i32 - i16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i32 - 1; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = i32 - i32; Assert.Equal<i32>(0, result); }
            { var result = i32 - i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i32 - 1; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i32 - i64; Assert.Equal<i64>(0, result); }
            { var result = i32 - i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i32 - 1; Assert.IsType<i32>(result); Assert.Equal<i64>(0, result); }
            { i32 result = i32 - u8; Assert.Equal<i32>(0, result); }
            { var result = i32 - u8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i32 - 1; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = i32 - u16; Assert.Equal<i32>(0, result); }
            { var result = i32 - u16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = i32 - 1; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i32 - u32; Assert.Equal<i64>(0, result); }
            { var result = i32 - u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i32 - 1; Assert.IsType<i32>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 - i8; Assert.Equal<i64>(0, result); }
            { var result = i64 - i8; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i64 - 1; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 - i16; Assert.Equal<i64>(0, result); }
            { var result = i64 - i16; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i64 - 1; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 - i32; Assert.Equal<i64>(0, result); }
            { var result = i64 - i32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i64 - 1; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 - i64; Assert.Equal<i64>(0, result); }
            { var result = i64 - i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i64 - 1; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 - u8; Assert.Equal<i64>(0, result); }
            { var result = i64 - u8; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i64 - 1; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 - u16; Assert.Equal<i64>(0, result); }
            { var result = i64 - u16; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i64 - 1; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 - u32; Assert.Equal<i64>(0, result); }
            { var result = i64 - u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = i64 - 1; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i16 result = u8 - i8; Assert.Equal<i16>(0, result); }
            { var result = u8 - i8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<i16>(0, result); }
            { i16 result = u8 - i16; Assert.Equal<i16>(0, result); }
            { var result = u8 - i16; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<i16>(0, result); }
            { i32 result = u8 - i32; Assert.Equal<i32>(0, result); }
            { var result = u8 - i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<i32>(0, result); }
            { i64 result = u8 - i64; Assert.Equal<i64>(0, result); }
            { var result = u8 - i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<i64>(0, result); }
            { u8 result = u8 - u8; Assert.Equal<u8>(0, result); }
            { var result = u8 - u8; Assert.IsType<u8>(result); Assert.Equal<u8>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<u8>(0, result); }
            { u16 result = u8 - u16; Assert.Equal<u16>(0, result); }
            { var result = u8 - u16; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<u16>(0, result); }
            { u32 result = u8 - u32; Assert.Equal<u32>(0, result); }
            { var result = u8 - u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<u32>(0, result); }
            { u64 result = u8 - u64; Assert.Equal<u64>(0, result); }
            { var result = u8 - u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { var result = u8 - 1; Assert.IsType<u8>(result); Assert.Equal<u64>(0, result); }
            { i32 result = u16 - i8; Assert.Equal<i32>(0, result); }
            { var result = u16 - i8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<i32>(0, result); }
            { i32 result = u16 - i16; Assert.Equal<i32>(0, result); }
            { var result = u16 - i16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<i32>(0, result); }
            { i32 result = u16 - i32; Assert.Equal<i32>(0, result); }
            { var result = u16 - i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<i32>(0, result); }
            { i64 result = u16 - i64; Assert.Equal<i64>(0, result); }
            { var result = u16 - i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<i64>(0, result); }
            { u16 result = u16 - u8; Assert.Equal<u16>(0, result); }
            { var result = u16 - u8; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u16 result = u16 - u16; Assert.Equal<u16>(0, result); }
            { var result = u16 - u16; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u32 result = u16 - u32; Assert.Equal<u32>(0, result); }
            { var result = u16 - u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<u32>(0, result); }
            { u64 result = u16 - u64; Assert.Equal<u64>(0, result); }
            { var result = u16 - u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { var result = u16 - 1; Assert.IsType<u16>(result); Assert.Equal<u64>(0, result); }
            { i64 result = u32 - i8; Assert.Equal<i64>(0, result); }
            { var result = u32 - i8; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<i64>(0, result); }
            { i64 result = u32 - i16; Assert.Equal<i64>(0, result); }
            { var result = u32 - i16; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<i64>(0, result); }
            { i64 result = u32 - i32; Assert.Equal<i64>(0, result); }
            { var result = u32 - i32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<i64>(0, result); }
            { i64 result = u32 - i64; Assert.Equal<i64>(0, result); }
            { var result = u32 - i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<i64>(0, result); }
            { u32 result = u32 - u8; Assert.Equal<u32>(0, result); }
            { var result = u32 - u8; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u32 result = u32 - u16; Assert.Equal<u32>(0, result); }
            { var result = u32 - u16; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u32 result = u32 - u32; Assert.Equal<u32>(0, result); }
            { var result = u32 - u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u64 result = u32 - u64; Assert.Equal<u64>(0, result); }
            { var result = u32 - u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { var result = u32 - 1; Assert.IsType<u32>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 - u8; Assert.Equal<u64>(0, result); }
            { var result = u64 - u8; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { var result = u64 - 1; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 - u16; Assert.Equal<u64>(0, result); }
            { var result = u64 - u16; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { var result = u64 - 1; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 - u32; Assert.Equal<u64>(0, result); }
            { var result = u64 - u32; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { var result = u64 - 1; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 - u64; Assert.Equal<u64>(0, result); }
            { var result = u64 - u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { var result = u64 - 1; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
        }
        //NOTE! AUTO GENERATED
        [Fact]
        public void MultiplicationTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { i8 result = i8 * i8; Assert.Equal<i8>(1, result); }
            { var result = i8 * i8; Assert.IsType<i8>(result); Assert.Equal<i8>(1, result); }
            { i16 result = i8 * i16; Assert.Equal<i16>(1, result); }
            { var result = i8 * i16; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i8 * i32; Assert.Equal<i32>(1, result); }
            { var result = i8 * i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i8 * i64; Assert.Equal<i64>(1, result); }
            { var result = i8 * i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = i8 * u8; Assert.Equal<i16>(1, result); }
            { var result = i8 * u8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i8 * u16; Assert.Equal<i32>(1, result); }
            { var result = i8 * u16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i8 * u32; Assert.Equal<i64>(1, result); }
            { var result = i8 * u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = i16 * i8; Assert.Equal<i16>(1, result); }
            { var result = i16 * i8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i16 result = i16 * i16; Assert.Equal<i16>(1, result); }
            { var result = i16 * i16; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i16 * i32; Assert.Equal<i32>(1, result); }
            { var result = i16 * i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i16 * i64; Assert.Equal<i64>(1, result); }
            { var result = i16 * i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = i16 * u8; Assert.Equal<i16>(1, result); }
            { var result = i16 * u8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i16 * u16; Assert.Equal<i32>(1, result); }
            { var result = i16 * u16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i16 * u32; Assert.Equal<i64>(1, result); }
            { var result = i16 * u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i32 result = i32 * i8; Assert.Equal<i32>(1, result); }
            { var result = i32 * i8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = i32 * i16; Assert.Equal<i32>(1, result); }
            { var result = i32 * i16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = i32 * i32; Assert.Equal<i32>(1, result); }
            { var result = i32 * i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i32 * i64; Assert.Equal<i64>(1, result); }
            { var result = i32 * i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i32 result = i32 * u8; Assert.Equal<i32>(1, result); }
            { var result = i32 * u8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = i32 * u16; Assert.Equal<i32>(1, result); }
            { var result = i32 * u16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i32 * u32; Assert.Equal<i64>(1, result); }
            { var result = i32 * u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 * i8; Assert.Equal<i64>(1, result); }
            { var result = i64 * i8; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 * i16; Assert.Equal<i64>(1, result); }
            { var result = i64 * i16; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 * i32; Assert.Equal<i64>(1, result); }
            { var result = i64 * i32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 * i64; Assert.Equal<i64>(1, result); }
            { var result = i64 * i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 * u8; Assert.Equal<i64>(1, result); }
            { var result = i64 * u8; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 * u16; Assert.Equal<i64>(1, result); }
            { var result = i64 * u16; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 * u32; Assert.Equal<i64>(1, result); }
            { var result = i64 * u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = u8 * i8; Assert.Equal<i16>(1, result); }
            { var result = u8 * i8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i16 result = u8 * i16; Assert.Equal<i16>(1, result); }
            { var result = u8 * i16; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = u8 * i32; Assert.Equal<i32>(1, result); }
            { var result = u8 * i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = u8 * i64; Assert.Equal<i64>(1, result); }
            { var result = u8 * i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { u8 result = u8 * u8; Assert.Equal<u8>(1, result); }
            { var result = u8 * u8; Assert.IsType<u8>(result); Assert.Equal<u8>(1, result); }
            { u16 result = u8 * u16; Assert.Equal<u16>(1, result); }
            { var result = u8 * u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u32 result = u8 * u32; Assert.Equal<u32>(1, result); }
            { var result = u8 * u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u64 result = u8 * u64; Assert.Equal<u64>(1, result); }
            { var result = u8 * u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { i32 result = u16 * i8; Assert.Equal<i32>(1, result); }
            { var result = u16 * i8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = u16 * i16; Assert.Equal<i32>(1, result); }
            { var result = u16 * i16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = u16 * i32; Assert.Equal<i32>(1, result); }
            { var result = u16 * i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = u16 * i64; Assert.Equal<i64>(1, result); }
            { var result = u16 * i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { u16 result = u16 * u8; Assert.Equal<u16>(1, result); }
            { var result = u16 * u8; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u16 result = u16 * u16; Assert.Equal<u16>(1, result); }
            { var result = u16 * u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u32 result = u16 * u32; Assert.Equal<u32>(1, result); }
            { var result = u16 * u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u64 result = u16 * u64; Assert.Equal<u64>(1, result); }
            { var result = u16 * u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { i64 result = u32 * i8; Assert.Equal<i64>(1, result); }
            { var result = u32 * i8; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = u32 * i16; Assert.Equal<i64>(1, result); }
            { var result = u32 * i16; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = u32 * i32; Assert.Equal<i64>(1, result); }
            { var result = u32 * i32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = u32 * i64; Assert.Equal<i64>(1, result); }
            { var result = u32 * i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { u32 result = u32 * u8; Assert.Equal<u32>(1, result); }
            { var result = u32 * u8; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 * u16; Assert.Equal<u32>(1, result); }
            { var result = u32 * u16; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 * u32; Assert.Equal<u32>(1, result); }
            { var result = u32 * u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u64 result = u32 * u64; Assert.Equal<u64>(1, result); }
            { var result = u32 * u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 * u8; Assert.Equal<u64>(1, result); }
            { var result = u64 * u8; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 * u16; Assert.Equal<u64>(1, result); }
            { var result = u64 * u16; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 * u32; Assert.Equal<u64>(1, result); }
            { var result = u64 * u32; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 * u64; Assert.Equal<u64>(1, result); }
            { var result = u64 * u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
        }
        //NOTE! AUTO GENERATED
        [Fact]
        public void DivisionTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { i8 result = i8 / i8; Assert.Equal<i8>(1, result); }
            { var result = i8 / i8; Assert.IsType<i8>(result); Assert.Equal<i8>(1, result); }
            { i16 result = i8 / i16; Assert.Equal<i16>(1, result); }
            { var result = i8 / i16; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i8 / i32; Assert.Equal<i32>(1, result); }
            { var result = i8 / i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i8 / i64; Assert.Equal<i64>(1, result); }
            { var result = i8 / i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = i8 / u8; Assert.Equal<i16>(1, result); }
            { var result = i8 / u8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i8 / u16; Assert.Equal<i32>(1, result); }
            { var result = i8 / u16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i8 / u32; Assert.Equal<i64>(1, result); }
            { var result = i8 / u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = i16 / i8; Assert.Equal<i16>(1, result); }
            { var result = i16 / i8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i16 result = i16 / i16; Assert.Equal<i16>(1, result); }
            { var result = i16 / i16; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i16 / i32; Assert.Equal<i32>(1, result); }
            { var result = i16 / i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i16 / i64; Assert.Equal<i64>(1, result); }
            { var result = i16 / i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = i16 / u8; Assert.Equal<i16>(1, result); }
            { var result = i16 / u8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = i16 / u16; Assert.Equal<i32>(1, result); }
            { var result = i16 / u16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i16 / u32; Assert.Equal<i64>(1, result); }
            { var result = i16 / u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i32 result = i32 / i8; Assert.Equal<i32>(1, result); }
            { var result = i32 / i8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = i32 / i16; Assert.Equal<i32>(1, result); }
            { var result = i32 / i16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = i32 / i32; Assert.Equal<i32>(1, result); }
            { var result = i32 / i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i32 / i64; Assert.Equal<i64>(1, result); }
            { var result = i32 / i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i32 result = i32 / u8; Assert.Equal<i32>(1, result); }
            { var result = i32 / u8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = i32 / u16; Assert.Equal<i32>(1, result); }
            { var result = i32 / u16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = i32 / u32; Assert.Equal<i64>(1, result); }
            { var result = i32 / u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 / i8; Assert.Equal<i64>(1, result); }
            { var result = i64 / i8; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 / i16; Assert.Equal<i64>(1, result); }
            { var result = i64 / i16; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 / i32; Assert.Equal<i64>(1, result); }
            { var result = i64 / i32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 / i64; Assert.Equal<i64>(1, result); }
            { var result = i64 / i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 / u8; Assert.Equal<i64>(1, result); }
            { var result = i64 / u8; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 / u16; Assert.Equal<i64>(1, result); }
            { var result = i64 / u16; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = i64 / u32; Assert.Equal<i64>(1, result); }
            { var result = i64 / u32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i16 result = u8 / i8; Assert.Equal<i16>(1, result); }
            { var result = u8 / i8; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i16 result = u8 / i16; Assert.Equal<i16>(1, result); }
            { var result = u8 / i16; Assert.IsType<i16>(result); Assert.Equal<i16>(1, result); }
            { i32 result = u8 / i32; Assert.Equal<i32>(1, result); }
            { var result = u8 / i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = u8 / i64; Assert.Equal<i64>(1, result); }
            { var result = u8 / i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { u8 result = u8 / u8; Assert.Equal<u8>(1, result); }
            { var result = u8 / u8; Assert.IsType<u8>(result); Assert.Equal<u8>(1, result); }
            { u16 result = u8 / u16; Assert.Equal<u16>(1, result); }
            { var result = u8 / u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u32 result = u8 / u32; Assert.Equal<u32>(1, result); }
            { var result = u8 / u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u64 result = u8 / u64; Assert.Equal<u64>(1, result); }
            { var result = u8 / u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { i32 result = u16 / i8; Assert.Equal<i32>(1, result); }
            { var result = u16 / i8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = u16 / i16; Assert.Equal<i32>(1, result); }
            { var result = u16 / i16; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i32 result = u16 / i32; Assert.Equal<i32>(1, result); }
            { var result = u16 / i32; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
            { i64 result = u16 / i64; Assert.Equal<i64>(1, result); }
            { var result = u16 / i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { u16 result = u16 / u8; Assert.Equal<u16>(1, result); }
            { var result = u16 / u8; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u16 result = u16 / u16; Assert.Equal<u16>(1, result); }
            { var result = u16 / u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u32 result = u16 / u32; Assert.Equal<u32>(1, result); }
            { var result = u16 / u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u64 result = u16 / u64; Assert.Equal<u64>(1, result); }
            { var result = u16 / u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { i64 result = u32 / i8; Assert.Equal<i64>(1, result); }
            { var result = u32 / i8; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = u32 / i16; Assert.Equal<i64>(1, result); }
            { var result = u32 / i16; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = u32 / i32; Assert.Equal<i64>(1, result); }
            { var result = u32 / i32; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { i64 result = u32 / i64; Assert.Equal<i64>(1, result); }
            { var result = u32 / i64; Assert.IsType<i64>(result); Assert.Equal<i64>(1, result); }
            { u32 result = u32 / u8; Assert.Equal<u32>(1, result); }
            { var result = u32 / u8; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 / u16; Assert.Equal<u32>(1, result); }
            { var result = u32 / u16; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 / u32; Assert.Equal<u32>(1, result); }
            { var result = u32 / u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u64 result = u32 / u64; Assert.Equal<u64>(1, result); }
            { var result = u32 / u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 / u8; Assert.Equal<u64>(1, result); }
            { var result = u64 / u8; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 / u16; Assert.Equal<u64>(1, result); }
            { var result = u64 / u16; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 / u32; Assert.Equal<u64>(1, result); }
            { var result = u64 / u32; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 / u64; Assert.Equal<u64>(1, result); }
            { var result = u64 / u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
        }
        //NOTE! AUTO GENERATED
        [Fact]
        public void ModulusTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { i8 result = i8 % i8; Assert.Equal<i8>(0, result); }
            { var result = i8 % i8; Assert.IsType<i8>(result); Assert.Equal<i8>(0, result); }
            { i16 result = i8 % i16; Assert.Equal<i16>(0, result); }
            { var result = i8 % i16; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i8 % i32; Assert.Equal<i32>(0, result); }
            { var result = i8 % i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i8 % i64; Assert.Equal<i64>(0, result); }
            { var result = i8 % i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i16 result = i8 % u8; Assert.Equal<i16>(0, result); }
            { var result = i8 % u8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i8 % u16; Assert.Equal<i32>(0, result); }
            { var result = i8 % u16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i8 % u32; Assert.Equal<i64>(0, result); }
            { var result = i8 % u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i16 result = i16 % i8; Assert.Equal<i16>(0, result); }
            { var result = i16 % i8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i16 result = i16 % i16; Assert.Equal<i16>(0, result); }
            { var result = i16 % i16; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i16 % i32; Assert.Equal<i32>(0, result); }
            { var result = i16 % i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i16 % i64; Assert.Equal<i64>(0, result); }
            { var result = i16 % i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i16 result = i16 % u8; Assert.Equal<i16>(0, result); }
            { var result = i16 % u8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i32 result = i16 % u16; Assert.Equal<i32>(0, result); }
            { var result = i16 % u16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i16 % u32; Assert.Equal<i64>(0, result); }
            { var result = i16 % u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i32 result = i32 % i8; Assert.Equal<i32>(0, result); }
            { var result = i32 % i8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = i32 % i16; Assert.Equal<i32>(0, result); }
            { var result = i32 % i16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = i32 % i32; Assert.Equal<i32>(0, result); }
            { var result = i32 % i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i32 % i64; Assert.Equal<i64>(0, result); }
            { var result = i32 % i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i32 result = i32 % u8; Assert.Equal<i32>(0, result); }
            { var result = i32 % u8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = i32 % u16; Assert.Equal<i32>(0, result); }
            { var result = i32 % u16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = i32 % u32; Assert.Equal<i64>(0, result); }
            { var result = i32 % u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 % i8; Assert.Equal<i64>(0, result); }
            { var result = i64 % i8; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 % i16; Assert.Equal<i64>(0, result); }
            { var result = i64 % i16; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 % i32; Assert.Equal<i64>(0, result); }
            { var result = i64 % i32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 % i64; Assert.Equal<i64>(0, result); }
            { var result = i64 % i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 % u8; Assert.Equal<i64>(0, result); }
            { var result = i64 % u8; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 % u16; Assert.Equal<i64>(0, result); }
            { var result = i64 % u16; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = i64 % u32; Assert.Equal<i64>(0, result); }
            { var result = i64 % u32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i16 result = u8 % i8; Assert.Equal<i16>(0, result); }
            { var result = u8 % i8; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i16 result = u8 % i16; Assert.Equal<i16>(0, result); }
            { var result = u8 % i16; Assert.IsType<i16>(result); Assert.Equal<i16>(0, result); }
            { i32 result = u8 % i32; Assert.Equal<i32>(0, result); }
            { var result = u8 % i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = u8 % i64; Assert.Equal<i64>(0, result); }
            { var result = u8 % i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { u8 result = u8 % u8; Assert.Equal<u8>(0, result); }
            { var result = u8 % u8; Assert.IsType<u8>(result); Assert.Equal<u8>(0, result); }
            { u16 result = u8 % u16; Assert.Equal<u16>(0, result); }
            { var result = u8 % u16; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u32 result = u8 % u32; Assert.Equal<u32>(0, result); }
            { var result = u8 % u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u64 result = u8 % u64; Assert.Equal<u64>(0, result); }
            { var result = u8 % u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { i32 result = u16 % i8; Assert.Equal<i32>(0, result); }
            { var result = u16 % i8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = u16 % i16; Assert.Equal<i32>(0, result); }
            { var result = u16 % i16; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i32 result = u16 % i32; Assert.Equal<i32>(0, result); }
            { var result = u16 % i32; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
            { i64 result = u16 % i64; Assert.Equal<i64>(0, result); }
            { var result = u16 % i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { u16 result = u16 % u8; Assert.Equal<u16>(0, result); }
            { var result = u16 % u8; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u16 result = u16 % u16; Assert.Equal<u16>(0, result); }
            { var result = u16 % u16; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u32 result = u16 % u32; Assert.Equal<u32>(0, result); }
            { var result = u16 % u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u64 result = u16 % u64; Assert.Equal<u64>(0, result); }
            { var result = u16 % u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { i64 result = u32 % i8; Assert.Equal<i64>(0, result); }
            { var result = u32 % i8; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = u32 % i16; Assert.Equal<i64>(0, result); }
            { var result = u32 % i16; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = u32 % i32; Assert.Equal<i64>(0, result); }
            { var result = u32 % i32; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { i64 result = u32 % i64; Assert.Equal<i64>(0, result); }
            { var result = u32 % i64; Assert.IsType<i64>(result); Assert.Equal<i64>(0, result); }
            { u32 result = u32 % u8; Assert.Equal<u32>(0, result); }
            { var result = u32 % u8; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u32 result = u32 % u16; Assert.Equal<u32>(0, result); }
            { var result = u32 % u16; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u32 result = u32 % u32; Assert.Equal<u32>(0, result); }
            { var result = u32 % u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u64 result = u32 % u64; Assert.Equal<u64>(0, result); }
            { var result = u32 % u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 % u8; Assert.Equal<u64>(0, result); }
            { var result = u64 % u8; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 % u16; Assert.Equal<u64>(0, result); }
            { var result = u64 % u16; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 % u32; Assert.Equal<u64>(0, result); }
            { var result = u64 % u32; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 % u64; Assert.Equal<u64>(0, result); }
            { var result = u64 % u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
        }
        //NOTE! AUTO GENERATED
        [Fact]
        public void BinaryOrTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { u8 result = u8 | 0b0010; Assert.Equal<u8>(0b0011, result); }
            { u8 b = 0b1100; u8 result = u8 | b; Assert.Equal<u8>(0b1101, result); }
            { u8 result = u8 | u8; Assert.Equal<u8>(0b0001, result); }
            { var result = u8 | u8; Assert.IsType<u8>(result); Assert.Equal<u8>(1, result); }
            { u8 result = u8 | 0b0010; Assert.Equal<u8>(0b0011, result); }
            { u16 b = 0b1100; u16 result = u8 | b; Assert.Equal<u16>(0b1101, result); }
            { u16 result = u8 | u16; Assert.Equal<u16>(0b0001, result); }
            { var result = u8 | u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u8 result = u8 | 0b0010; Assert.Equal<u8>(0b0011, result); }
            { u32 b = 0b1100; u32 result = u8 | b; Assert.Equal<u32>(0b1101, result); }
            { u32 result = u8 | u32; Assert.Equal<u32>(0b0001, result); }
            { var result = u8 | u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u8 result = u8 | 0b0010; Assert.Equal<u8>(0b0011, result); }
            { u64 b = 0b1100; u64 result = u8 | b; Assert.Equal<u64>(0b1101, result); }
            { u64 result = u8 | u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u8 | u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u16 result = u16 | 0b0010; Assert.Equal<u16>(0b0011, result); }
            { u8 b = 0b1100; u16 result = u16 | b; Assert.Equal<u16>(0b1101, result); }
            { u16 result = u16 | u8; Assert.Equal<u16>(0b0001, result); }
            { var result = u16 | u8; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u16 result = u16 | 0b0010; Assert.Equal<u16>(0b0011, result); }
            { u16 b = 0b1100; u16 result = u16 | b; Assert.Equal<u16>(0b1101, result); }
            { u16 result = u16 | u16; Assert.Equal<u16>(0b0001, result); }
            { var result = u16 | u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u16 result = u16 | 0b0010; Assert.Equal<u16>(0b0011, result); }
            { u32 b = 0b1100; u32 result = u16 | b; Assert.Equal<u32>(0b1101, result); }
            { u32 result = u16 | u32; Assert.Equal<u32>(0b0001, result); }
            { var result = u16 | u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u16 result = u16 | 0b0010; Assert.Equal<u16>(0b0011, result); }
            { u64 b = 0b1100; u64 result = u16 | b; Assert.Equal<u64>(0b1101, result); }
            { u64 result = u16 | u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u16 | u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u32 result = u32 | 0b0010; Assert.Equal<u32>(0b0011, result); }
            { u8 b = 0b1100; u32 result = u32 | b; Assert.Equal<u32>(0b1101, result); }
            { u32 result = u32 | u8; Assert.Equal<u32>(0b0001, result); }
            { var result = u32 | u8; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 | 0b0010; Assert.Equal<u32>(0b0011, result); }
            { u16 b = 0b1100; u32 result = u32 | b; Assert.Equal<u32>(0b1101, result); }
            { u32 result = u32 | u16; Assert.Equal<u32>(0b0001, result); }
            { var result = u32 | u16; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 | 0b0010; Assert.Equal<u32>(0b0011, result); }
            { u32 b = 0b1100; u32 result = u32 | b; Assert.Equal<u32>(0b1101, result); }
            { u32 result = u32 | u32; Assert.Equal<u32>(0b0001, result); }
            { var result = u32 | u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 | 0b0010; Assert.Equal<u32>(0b0011, result); }
            { u64 b = 0b1100; u64 result = u32 | b; Assert.Equal<u64>(0b1101, result); }
            { u64 result = u32 | u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u32 | u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 | 0b0010; Assert.Equal<u64>(0b0011, result); }
            { u8 b = 0b1100; u64 result = u64 | b; Assert.Equal<u64>(0b1101, result); }
            { u64 result = u64 | u8; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 | u8; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 | 0b0010; Assert.Equal<u64>(0b0011, result); }
            { u16 b = 0b1100; u64 result = u64 | b; Assert.Equal<u64>(0b1101, result); }
            { u64 result = u64 | u16; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 | u16; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 | 0b0010; Assert.Equal<u64>(0b0011, result); }
            { u32 b = 0b1100; u64 result = u64 | b; Assert.Equal<u64>(0b1101, result); }
            { u64 result = u64 | u32; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 | u32; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 | 0b0010; Assert.Equal<u64>(0b0011, result); }
            { u64 b = 0b1100; u64 result = u64 | b; Assert.Equal<u64>(0b1101, result); }
            { u64 result = u64 | u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 | u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
        }
        //NOTE! AUTO GENERATED
        [Fact]
        public void BinaryAndTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { u8 result = u8 & 0b0011; Assert.Equal<u8>(0b0001, result); }
            { u8 b = 0b1111; u8 result = u8 & b; Assert.Equal<u8>(0b0001, result); }
            { u8 result = u8 & u8; Assert.Equal<u8>(0b0001, result); }
            { var result = u8 & u8; Assert.IsType<u8>(result); Assert.Equal<u8>(1, result); }
            { u8 result = u8 & 0b0011; Assert.Equal<u8>(0b0001, result); }
            { u16 b = 0b1111; u16 result = u8 & b; Assert.Equal<u16>(0b0001, result); }
            { u16 result = u8 & u16; Assert.Equal<u16>(0b0001, result); }
            { var result = u8 & u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u8 result = u8 & 0b0011; Assert.Equal<u8>(0b0001, result); }
            { u32 b = 0b1111; u32 result = u8 & b; Assert.Equal<u32>(0b0001, result); }
            { u32 result = u8 & u32; Assert.Equal<u32>(0b0001, result); }
            { var result = u8 & u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u8 result = u8 & 0b0011; Assert.Equal<u8>(0b0001, result); }
            { u64 b = 0b1111; u64 result = u8 & b; Assert.Equal<u64>(0b0001, result); }
            { u64 result = u8 & u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u8 & u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u16 result = u16 & 0b0011; Assert.Equal<u16>(0b0001, result); }
            { u8 b = 0b1111; u16 result = u16 & b; Assert.Equal<u16>(0b0001, result); }
            { u16 result = u16 & u8; Assert.Equal<u16>(0b0001, result); }
            { var result = u16 & u8; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u16 result = u16 & 0b0011; Assert.Equal<u16>(0b0001, result); }
            { u16 b = 0b1111; u16 result = u16 & b; Assert.Equal<u16>(0b0001, result); }
            { u16 result = u16 & u16; Assert.Equal<u16>(0b0001, result); }
            { var result = u16 & u16; Assert.IsType<u16>(result); Assert.Equal<u16>(1, result); }
            { u16 result = u16 & 0b0011; Assert.Equal<u16>(0b0001, result); }
            { u32 b = 0b1111; u32 result = u16 & b; Assert.Equal<u32>(0b0001, result); }
            { u32 result = u16 & u32; Assert.Equal<u32>(0b0001, result); }
            { var result = u16 & u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u16 result = u16 & 0b0011; Assert.Equal<u16>(0b0001, result); }
            { u64 b = 0b1111; u64 result = u16 & b; Assert.Equal<u64>(0b0001, result); }
            { u64 result = u16 & u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u16 & u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u32 result = u32 & 0b0011; Assert.Equal<u32>(0b0001, result); }
            { u8 b = 0b1111; u32 result = u32 & b; Assert.Equal<u32>(0b0001, result); }
            { u32 result = u32 & u8; Assert.Equal<u32>(0b0001, result); }
            { var result = u32 & u8; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 & 0b0011; Assert.Equal<u32>(0b0001, result); }
            { u16 b = 0b1111; u32 result = u32 & b; Assert.Equal<u32>(0b0001, result); }
            { u32 result = u32 & u16; Assert.Equal<u32>(0b0001, result); }
            { var result = u32 & u16; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 & 0b0011; Assert.Equal<u32>(0b0001, result); }
            { u32 b = 0b1111; u32 result = u32 & b; Assert.Equal<u32>(0b0001, result); }
            { u32 result = u32 & u32; Assert.Equal<u32>(0b0001, result); }
            { var result = u32 & u32; Assert.IsType<u32>(result); Assert.Equal<u32>(1, result); }
            { u32 result = u32 & 0b0011; Assert.Equal<u32>(0b0001, result); }
            { u64 b = 0b1111; u64 result = u32 & b; Assert.Equal<u64>(0b0001, result); }
            { u64 result = u32 & u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u32 & u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 & 0b0011; Assert.Equal<u64>(0b0001, result); }
            { u8 b = 0b1111; u64 result = u64 & b; Assert.Equal<u64>(0b0001, result); }
            { u64 result = u64 & u8; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 & u8; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 & 0b0011; Assert.Equal<u64>(0b0001, result); }
            { u16 b = 0b1111; u64 result = u64 & b; Assert.Equal<u64>(0b0001, result); }
            { u64 result = u64 & u16; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 & u16; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 & 0b0011; Assert.Equal<u64>(0b0001, result); }
            { u32 b = 0b1111; u64 result = u64 & b; Assert.Equal<u64>(0b0001, result); }
            { u64 result = u64 & u32; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 & u32; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
            { u64 result = u64 & 0b0011; Assert.Equal<u64>(0b0001, result); }
            { u64 b = 0b1111; u64 result = u64 & b; Assert.Equal<u64>(0b0001, result); }
            { u64 result = u64 & u64; Assert.Equal<u64>(0b0001, result); }
            { var result = u64 & u64; Assert.IsType<u64>(result); Assert.Equal<u64>(1, result); }
        }
        //NOTE! AUTO GENERATED
        [Fact]
        public void BinaryXorTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { u8 result = u8 ^ 0b0011; Assert.Equal<u8>(0b0010, result); }
            { u8 b = 0b1111; u8 result = u8 ^ b; Assert.Equal<u8>(0b1110, result); }
            { u8 result = u8 ^ u8; Assert.Equal<u8>(0b0000, result); }
            { var result = u8 ^ u8; Assert.IsType<u8>(result); Assert.Equal<u8>(0, result); }
            { u8 result = u8 ^ 0b0011; Assert.Equal<u8>(0b0010, result); }
            { u16 b = 0b1111; u16 result = u8 ^ b; Assert.Equal<u16>(0b1110, result); }
            { u16 result = u8 ^ u16; Assert.Equal<u16>(0b0000, result); }
            { var result = u8 ^ u16; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u8 result = u8 ^ 0b0011; Assert.Equal<u8>(0b0010, result); }
            { u32 b = 0b1111; u32 result = u8 ^ b; Assert.Equal<u32>(0b1110, result); }
            { u32 result = u8 ^ u32; Assert.Equal<u32>(0b0000, result); }
            { var result = u8 ^ u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u8 result = u8 ^ 0b0011; Assert.Equal<u8>(0b0010, result); }
            { u64 b = 0b1111; u64 result = u8 ^ b; Assert.Equal<u64>(0b1110, result); }
            { u64 result = u8 ^ u64; Assert.Equal<u64>(0b0000, result); }
            { var result = u8 ^ u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u16 result = u16 ^ 0b0011; Assert.Equal<u16>(0b0010, result); }
            { u8 b = 0b1111; u16 result = u16 ^ b; Assert.Equal<u16>(0b1110, result); }
            { u16 result = u16 ^ u8; Assert.Equal<u16>(0b0000, result); }
            { var result = u16 ^ u8; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u16 result = u16 ^ 0b0011; Assert.Equal<u16>(0b0010, result); }
            { u16 b = 0b1111; u16 result = u16 ^ b; Assert.Equal<u16>(0b1110, result); }
            { u16 result = u16 ^ u16; Assert.Equal<u16>(0b0000, result); }
            { var result = u16 ^ u16; Assert.IsType<u16>(result); Assert.Equal<u16>(0, result); }
            { u16 result = u16 ^ 0b0011; Assert.Equal<u16>(0b0010, result); }
            { u32 b = 0b1111; u32 result = u16 ^ b; Assert.Equal<u32>(0b1110, result); }
            { u32 result = u16 ^ u32; Assert.Equal<u32>(0b0000, result); }
            { var result = u16 ^ u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u16 result = u16 ^ 0b0011; Assert.Equal<u16>(0b0010, result); }
            { u64 b = 0b1111; u64 result = u16 ^ b; Assert.Equal<u64>(0b1110, result); }
            { u64 result = u16 ^ u64; Assert.Equal<u64>(0b0000, result); }
            { var result = u16 ^ u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u32 result = u32 ^ 0b0011; Assert.Equal<u32>(0b0010, result); }
            { u8 b = 0b1111; u32 result = u32 ^ b; Assert.Equal<u32>(0b1110, result); }
            { u32 result = u32 ^ u8; Assert.Equal<u32>(0b0000, result); }
            { var result = u32 ^ u8; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u32 result = u32 ^ 0b0011; Assert.Equal<u32>(0b0010, result); }
            { u16 b = 0b1111; u32 result = u32 ^ b; Assert.Equal<u32>(0b1110, result); }
            { u32 result = u32 ^ u16; Assert.Equal<u32>(0b0000, result); }
            { var result = u32 ^ u16; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u32 result = u32 ^ 0b0011; Assert.Equal<u32>(0b0010, result); }
            { u32 b = 0b1111; u32 result = u32 ^ b; Assert.Equal<u32>(0b1110, result); }
            { u32 result = u32 ^ u32; Assert.Equal<u32>(0b0000, result); }
            { var result = u32 ^ u32; Assert.IsType<u32>(result); Assert.Equal<u32>(0, result); }
            { u32 result = u32 ^ 0b0011; Assert.Equal<u32>(0b0010, result); }
            { u64 b = 0b1111; u64 result = u32 ^ b; Assert.Equal<u64>(0b1110, result); }
            { u64 result = u32 ^ u64; Assert.Equal<u64>(0b0000, result); }
            { var result = u32 ^ u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 ^ 0b0011; Assert.Equal<u64>(0b0010, result); }
            { u8 b = 0b1111; u64 result = u64 ^ b; Assert.Equal<u64>(0b1110, result); }
            { u64 result = u64 ^ u8; Assert.Equal<u64>(0b0000, result); }
            { var result = u64 ^ u8; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 ^ 0b0011; Assert.Equal<u64>(0b0010, result); }
            { u16 b = 0b1111; u64 result = u64 ^ b; Assert.Equal<u64>(0b1110, result); }
            { u64 result = u64 ^ u16; Assert.Equal<u64>(0b0000, result); }
            { var result = u64 ^ u16; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 ^ 0b0011; Assert.Equal<u64>(0b0010, result); }
            { u32 b = 0b1111; u64 result = u64 ^ b; Assert.Equal<u64>(0b1110, result); }
            { u64 result = u64 ^ u32; Assert.Equal<u64>(0b0000, result); }
            { var result = u64 ^ u32; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
            { u64 result = u64 ^ 0b0011; Assert.Equal<u64>(0b0010, result); }
            { u64 b = 0b1111; u64 result = u64 ^ b; Assert.Equal<u64>(0b1110, result); }
            { u64 result = u64 ^ u64; Assert.Equal<u64>(0b0000, result); }
            { var result = u64 ^ u64; Assert.IsType<u64>(result); Assert.Equal<u64>(0, result); }
        }
        
        //NOTE! AUTO GENERATED
        [Fact]
        public void EqualsTest()
        {
            i8 i8 = 1;
            i16 i16 = 1;
            i32 i32 = 1;
            i64 i64 = 1;
            u8 u8 = 1;
            u16 u16 = 1;
            u32 u32 = 1;
            u64 u64 = 1;
            { bool result = i8 == i8; Assert.True(result); }
            { bool result = i8 != i8; Assert.False(result); }
            { bool result = i8 == 127; Assert.False(result); }
            { bool result = i8 != 127; Assert.True(result); }
            { bool result = 127 == i8; Assert.False(result); }
            { bool result = 127 != i8; Assert.True(result); }
            { bool result = i8 == i16; Assert.True(result); }
            { bool result = i8 != i16; Assert.False(result); }
            { bool result = i8 == 32767; Assert.False(result); }
            { bool result = i8 != 32767; Assert.True(result); }
            { bool result = 32767 == i8; Assert.False(result); }
            { bool result = 32767 != i8; Assert.True(result); }
            { bool result = i8 == i32; Assert.True(result); }
            { bool result = i8 != i32; Assert.False(result); }
            { bool result = i8 == 2147483647; Assert.False(result); }
            { bool result = i8 != 2147483647; Assert.True(result); }
            { bool result = 2147483647 == i8; Assert.False(result); }
            { bool result = 2147483647 != i8; Assert.True(result); }
            { bool result = i8 == i64; Assert.True(result); }
            { bool result = i8 != i64; Assert.False(result); }
            { bool result = i8 == 9223372036854775807; Assert.False(result); }
            { bool result = i8 != 9223372036854775807; Assert.True(result); }
            { bool result = 9223372036854775807 == i8; Assert.False(result); }
            { bool result = 9223372036854775807 != i8; Assert.True(result); }
            { bool result = i8 == u8; Assert.True(result); }
            { bool result = i8 != u8; Assert.False(result); }
            { bool result = i8 == 255; Assert.False(result); }
            { bool result = i8 != 255; Assert.True(result); }
            { bool result = 255 == i8; Assert.False(result); }
            { bool result = 255 != i8; Assert.True(result); }
            { bool result = i8 == u16; Assert.True(result); }
            { bool result = i8 != u16; Assert.False(result); }
            { bool result = i8 == 65535; Assert.False(result); }
            { bool result = i8 != 65535; Assert.True(result); }
            { bool result = 65535 == i8; Assert.False(result); }
            { bool result = 65535 != i8; Assert.True(result); }
            { bool result = i8 == u32; Assert.True(result); }
            { bool result = i8 != u32; Assert.False(result); }
            { bool result = i8 == 4294967295; Assert.False(result); }
            { bool result = i8 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == i8; Assert.False(result); }
            { bool result = 4294967295 != i8; Assert.True(result); }

            { bool result = i16 == i8; Assert.True(result); }
            { bool result = i16 != i8; Assert.False(result); }
            { bool result = i16 == 127; Assert.False(result); }
            { bool result = i16 != 127; Assert.True(result); }
            { bool result = 127 == i16; Assert.False(result); }
            { bool result = 127 != i16; Assert.True(result); }
            { bool result = i16 == i16; Assert.True(result); }
            { bool result = i16 != i16; Assert.False(result); }
            { bool result = i16 == 32767; Assert.False(result); }
            { bool result = i16 != 32767; Assert.True(result); }
            { bool result = 32767 == i16; Assert.False(result); }
            { bool result = 32767 != i16; Assert.True(result); }
            { bool result = i16 == i32; Assert.True(result); }
            { bool result = i16 != i32; Assert.False(result); }
            { bool result = i16 == 2147483647; Assert.False(result); }
            { bool result = i16 != 2147483647; Assert.True(result); }
            { bool result = 2147483647 == i16; Assert.False(result); }
            { bool result = 2147483647 != i16; Assert.True(result); }
            { bool result = i16 == i64; Assert.True(result); }
            { bool result = i16 != i64; Assert.False(result); }
            { bool result = i16 == 9223372036854775807; Assert.False(result); }
            { bool result = i16 != 9223372036854775807; Assert.True(result); }
            { bool result = 9223372036854775807 == i16; Assert.False(result); }
            { bool result = 9223372036854775807 != i16; Assert.True(result); }
            { bool result = i16 == u8; Assert.True(result); }
            { bool result = i16 != u8; Assert.False(result); }
            { bool result = i16 == 255; Assert.False(result); }
            { bool result = i16 != 255; Assert.True(result); }
            { bool result = 255 == i16; Assert.False(result); }
            { bool result = 255 != i16; Assert.True(result); }
            { bool result = i16 == u16; Assert.True(result); }
            { bool result = i16 != u16; Assert.False(result); }
            { bool result = i16 == 65535; Assert.False(result); }
            { bool result = i16 != 65535; Assert.True(result); }
            { bool result = 65535 == i16; Assert.False(result); }
            { bool result = 65535 != i16; Assert.True(result); }
            { bool result = i16 == u32; Assert.True(result); }
            { bool result = i16 != u32; Assert.False(result); }
            { bool result = i16 == 4294967295; Assert.False(result); }
            { bool result = i16 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == i16; Assert.False(result); }
            { bool result = 4294967295 != i16; Assert.True(result); }

            { bool result = i32 == i8; Assert.True(result); }
            { bool result = i32 != i8; Assert.False(result); }
            { bool result = i32 == 127; Assert.False(result); }
            { bool result = i32 != 127; Assert.True(result); }
            { bool result = 127 == i32; Assert.False(result); }
            { bool result = 127 != i32; Assert.True(result); }
            { bool result = i32 == i16; Assert.True(result); }
            { bool result = i32 != i16; Assert.False(result); }
            { bool result = i32 == 32767; Assert.False(result); }
            { bool result = i32 != 32767; Assert.True(result); }
            { bool result = 32767 == i32; Assert.False(result); }
            { bool result = 32767 != i32; Assert.True(result); }
            { bool result = i32 == i32; Assert.True(result); }
            { bool result = i32 != i32; Assert.False(result); }
            { bool result = i32 == 2147483647; Assert.False(result); }
            { bool result = i32 != 2147483647; Assert.True(result); }
            { bool result = 2147483647 == i32; Assert.False(result); }
            { bool result = 2147483647 != i32; Assert.True(result); }
            { bool result = i32 == i64; Assert.True(result); }
            { bool result = i32 != i64; Assert.False(result); }
            { bool result = i32 == 9223372036854775807; Assert.False(result); }
            { bool result = i32 != 9223372036854775807; Assert.True(result); }
            { bool result = 9223372036854775807 == i32; Assert.False(result); }
            { bool result = 9223372036854775807 != i32; Assert.True(result); }
            { bool result = i32 == u8; Assert.True(result); }
            { bool result = i32 != u8; Assert.False(result); }
            { bool result = i32 == 255; Assert.False(result); }
            { bool result = i32 != 255; Assert.True(result); }
            { bool result = 255 == i32; Assert.False(result); }
            { bool result = 255 != i32; Assert.True(result); }
            { bool result = i32 == u16; Assert.True(result); }
            { bool result = i32 != u16; Assert.False(result); }
            { bool result = i32 == 65535; Assert.False(result); }
            { bool result = i32 != 65535; Assert.True(result); }
            { bool result = 65535 == i32; Assert.False(result); }
            { bool result = 65535 != i32; Assert.True(result); }
            { bool result = i32 == u32; Assert.True(result); }
            { bool result = i32 != u32; Assert.False(result); }
            { bool result = i32 == 4294967295; Assert.False(result); }
            { bool result = i32 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == i32; Assert.False(result); }
            { bool result = 4294967295 != i32; Assert.True(result); }

            { bool result = i64 == i8; Assert.True(result); }
            { bool result = i64 != i8; Assert.False(result); }
            { bool result = i64 == 127; Assert.False(result); }
            { bool result = i64 != 127; Assert.True(result); }
            { bool result = 127 == i64; Assert.False(result); }
            { bool result = 127 != i64; Assert.True(result); }
            { bool result = i64 == i16; Assert.True(result); }
            { bool result = i64 != i16; Assert.False(result); }
            { bool result = i64 == 32767; Assert.False(result); }
            { bool result = i64 != 32767; Assert.True(result); }
            { bool result = 32767 == i64; Assert.False(result); }
            { bool result = 32767 != i64; Assert.True(result); }
            { bool result = i64 == i32; Assert.True(result); }
            { bool result = i64 != i32; Assert.False(result); }
            { bool result = i64 == 2147483647; Assert.False(result); }
            { bool result = i64 != 2147483647; Assert.True(result); }
            { bool result = 2147483647 == i64; Assert.False(result); }
            { bool result = 2147483647 != i64; Assert.True(result); }
            { bool result = i64 == i64; Assert.True(result); }
            { bool result = i64 != i64; Assert.False(result); }
            { bool result = i64 == 9223372036854775807; Assert.False(result); }
            { bool result = i64 != 9223372036854775807; Assert.True(result); }
            { bool result = 9223372036854775807 == i64; Assert.False(result); }
            { bool result = 9223372036854775807 != i64; Assert.True(result); }
            { bool result = i64 == u8; Assert.True(result); }
            { bool result = i64 != u8; Assert.False(result); }
            { bool result = i64 == 255; Assert.False(result); }
            { bool result = i64 != 255; Assert.True(result); }
            { bool result = 255 == i64; Assert.False(result); }
            { bool result = 255 != i64; Assert.True(result); }
            { bool result = i64 == u16; Assert.True(result); }
            { bool result = i64 != u16; Assert.False(result); }
            { bool result = i64 == 65535; Assert.False(result); }
            { bool result = i64 != 65535; Assert.True(result); }
            { bool result = 65535 == i64; Assert.False(result); }
            { bool result = 65535 != i64; Assert.True(result); }
            { bool result = i64 == u32; Assert.True(result); }
            { bool result = i64 != u32; Assert.False(result); }
            { bool result = i64 == 4294967295; Assert.False(result); }
            { bool result = i64 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == i64; Assert.False(result); }
            { bool result = 4294967295 != i64; Assert.True(result); }

            { bool result = u8 == i8; Assert.True(result); }
            { bool result = u8 != i8; Assert.False(result); }
            { bool result = u8 == 127; Assert.False(result); }
            { bool result = u8 != 127; Assert.True(result); }
            { bool result = 127 == u8; Assert.False(result); }
            { bool result = 127 != u8; Assert.True(result); }
            { bool result = u8 == i16; Assert.True(result); }
            { bool result = u8 != i16; Assert.False(result); }
            { bool result = u8 == 32767; Assert.False(result); }
            { bool result = u8 != 32767; Assert.True(result); }
            { bool result = 32767 == u8; Assert.False(result); }
            { bool result = 32767 != u8; Assert.True(result); }
            { bool result = u8 == i32; Assert.True(result); }
            { bool result = u8 != i32; Assert.False(result); }
            { bool result = u8 == 2147483647; Assert.False(result); }
            { bool result = u8 != 2147483647; Assert.True(result); }
            { bool result = 2147483647 == u8; Assert.False(result); }
            { bool result = 2147483647 != u8; Assert.True(result); }
            { bool result = u8 == i64; Assert.True(result); }
            { bool result = u8 != i64; Assert.False(result); }
            { bool result = u8 == 9223372036854775807; Assert.False(result); }
            { bool result = u8 != 9223372036854775807; Assert.True(result); }
            { bool result = 9223372036854775807 == u8; Assert.False(result); }
            { bool result = 9223372036854775807 != u8; Assert.True(result); }
            { bool result = u8 == u8; Assert.True(result); }
            { bool result = u8 != u8; Assert.False(result); }
            { bool result = u8 == 255; Assert.False(result); }
            { bool result = u8 != 255; Assert.True(result); }
            { bool result = 255 == u8; Assert.False(result); }
            { bool result = 255 != u8; Assert.True(result); }
            { bool result = u8 == u16; Assert.True(result); }
            { bool result = u8 != u16; Assert.False(result); }
            { bool result = u8 == 65535; Assert.False(result); }
            { bool result = u8 != 65535; Assert.True(result); }
            { bool result = 65535 == u8; Assert.False(result); }
            { bool result = 65535 != u8; Assert.True(result); }
            { bool result = u8 == u32; Assert.True(result); }
            { bool result = u8 != u32; Assert.False(result); }
            { bool result = u8 == 4294967295; Assert.False(result); }
            { bool result = u8 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == u8; Assert.False(result); }
            { bool result = 4294967295 != u8; Assert.True(result); }
            { bool result = u8 == u64; Assert.True(result); }
            { bool result = u8 != u64; Assert.False(result); }
            { bool result = u8 == 18446744073709551615; Assert.False(result); }
            { bool result = u8 != 18446744073709551615; Assert.True(result); }
            { bool result = 18446744073709551615 == u8; Assert.False(result); }
            { bool result = 18446744073709551615 != u8; Assert.True(result); }

            { bool result = u16 == i8; Assert.True(result); }
            { bool result = u16 != i8; Assert.False(result); }
            { bool result = u16 == 127; Assert.False(result); }
            { bool result = u16 != 127; Assert.True(result); }
            { bool result = 127 == u16; Assert.False(result); }
            { bool result = 127 != u16; Assert.True(result); }
            { bool result = u16 == i16; Assert.True(result); }
            { bool result = u16 != i16; Assert.False(result); }
            { bool result = u16 == 32767; Assert.False(result); }
            { bool result = u16 != 32767; Assert.True(result); }
            { bool result = 32767 == u16; Assert.False(result); }
            { bool result = 32767 != u16; Assert.True(result); }
            { bool result = u16 == i32; Assert.True(result); }
            { bool result = u16 != i32; Assert.False(result); }
            { bool result = u16 == 2147483647; Assert.False(result); }
            { bool result = u16 != 2147483647; Assert.True(result); }
            { bool result = 2147483647 == u16; Assert.False(result); }
            { bool result = 2147483647 != u16; Assert.True(result); }
            { bool result = u16 == i64; Assert.True(result); }
            { bool result = u16 != i64; Assert.False(result); }
            { bool result = u16 == 9223372036854775807; Assert.False(result); }
            { bool result = u16 != 9223372036854775807; Assert.True(result); }
            { bool result = 9223372036854775807 == u16; Assert.False(result); }
            { bool result = 9223372036854775807 != u16; Assert.True(result); }
            { bool result = u16 == u8; Assert.True(result); }
            { bool result = u16 != u8; Assert.False(result); }
            { bool result = u16 == 255; Assert.False(result); }
            { bool result = u16 != 255; Assert.True(result); }
            { bool result = 255 == u16; Assert.False(result); }
            { bool result = 255 != u16; Assert.True(result); }
            { bool result = u16 == u16; Assert.True(result); }
            { bool result = u16 != u16; Assert.False(result); }
            { bool result = u16 == 65535; Assert.False(result); }
            { bool result = u16 != 65535; Assert.True(result); }
            { bool result = 65535 == u16; Assert.False(result); }
            { bool result = 65535 != u16; Assert.True(result); }
            { bool result = u16 == u32; Assert.True(result); }
            { bool result = u16 != u32; Assert.False(result); }
            { bool result = u16 == 4294967295; Assert.False(result); }
            { bool result = u16 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == u16; Assert.False(result); }
            { bool result = 4294967295 != u16; Assert.True(result); }
            { bool result = u16 == u64; Assert.True(result); }
            { bool result = u16 != u64; Assert.False(result); }
            { bool result = u16 == 18446744073709551615; Assert.False(result); }
            { bool result = u16 != 18446744073709551615; Assert.True(result); }
            { bool result = 18446744073709551615 == u16; Assert.False(result); }
            { bool result = 18446744073709551615 != u16; Assert.True(result); }

            { bool result = u32 == i8; Assert.True(result); }
            { bool result = u32 != i8; Assert.False(result); }
            { bool result = u32 == 127; Assert.False(result); }
            { bool result = u32 != 127; Assert.True(result); }
            { bool result = 127 == u32; Assert.False(result); }
            { bool result = 127 != u32; Assert.True(result); }
            { bool result = u32 == i16; Assert.True(result); }
            { bool result = u32 != i16; Assert.False(result); }
            { bool result = u32 == 32767; Assert.False(result); }
            { bool result = u32 != 32767; Assert.True(result); }
            { bool result = 32767 == u32; Assert.False(result); }
            { bool result = 32767 != u32; Assert.True(result); }
            { bool result = u32 == i32; Assert.True(result); }
            { bool result = u32 != i32; Assert.False(result); }
            { bool result = u32 == 2147483647; Assert.False(result); }
            { bool result = u32 != 2147483647; Assert.True(result); }
            { bool result = 2147483647 == u32; Assert.False(result); }
            { bool result = 2147483647 != u32; Assert.True(result); }
            { bool result = u32 == i64; Assert.True(result); }
            { bool result = u32 != i64; Assert.False(result); }
            { bool result = u32 == 9223372036854775807; Assert.False(result); }
            { bool result = u32 != 9223372036854775807; Assert.True(result); }
            { bool result = 9223372036854775807 == u32; Assert.False(result); }
            { bool result = 9223372036854775807 != u32; Assert.True(result); }
            { bool result = u32 == u8; Assert.True(result); }
            { bool result = u32 != u8; Assert.False(result); }
            { bool result = u32 == 255; Assert.False(result); }
            { bool result = u32 != 255; Assert.True(result); }
            { bool result = 255 == u32; Assert.False(result); }
            { bool result = 255 != u32; Assert.True(result); }
            { bool result = u32 == u16; Assert.True(result); }
            { bool result = u32 != u16; Assert.False(result); }
            { bool result = u32 == 65535; Assert.False(result); }
            { bool result = u32 != 65535; Assert.True(result); }
            { bool result = 65535 == u32; Assert.False(result); }
            { bool result = 65535 != u32; Assert.True(result); }
            { bool result = u32 == u32; Assert.True(result); }
            { bool result = u32 != u32; Assert.False(result); }
            { bool result = u32 == 4294967295; Assert.False(result); }
            { bool result = u32 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == u32; Assert.False(result); }
            { bool result = 4294967295 != u32; Assert.True(result); }
            { bool result = u32 == u64; Assert.True(result); }
            { bool result = u32 != u64; Assert.False(result); }
            { bool result = u32 == 18446744073709551615; Assert.False(result); }
            { bool result = u32 != 18446744073709551615; Assert.True(result); }
            { bool result = 18446744073709551615 == u32; Assert.False(result); }
            { bool result = 18446744073709551615 != u32; Assert.True(result); }

            { bool result = u64 == u8; Assert.True(result); }
            { bool result = u64 != u8; Assert.False(result); }
            { bool result = u64 == 255; Assert.False(result); }
            { bool result = u64 != 255; Assert.True(result); }
            { bool result = 255 == u64; Assert.False(result); }
            { bool result = 255 != u64; Assert.True(result); }
            { bool result = u64 == u16; Assert.True(result); }
            { bool result = u64 != u16; Assert.False(result); }
            { bool result = u64 == 65535; Assert.False(result); }
            { bool result = u64 != 65535; Assert.True(result); }
            { bool result = 65535 == u64; Assert.False(result); }
            { bool result = 65535 != u64; Assert.True(result); }
            { bool result = u64 == u32; Assert.True(result); }
            { bool result = u64 != u32; Assert.False(result); }
            { bool result = u64 == 4294967295; Assert.False(result); }
            { bool result = u64 != 4294967295; Assert.True(result); }
            { bool result = 4294967295 == u64; Assert.False(result); }
            { bool result = 4294967295 != u64; Assert.True(result); }
            { bool result = u64 == u64; Assert.True(result); }
            { bool result = u64 != u64; Assert.False(result); }
            { bool result = u64 == 18446744073709551615; Assert.False(result); }
            { bool result = u64 != 18446744073709551615; Assert.True(result); }
            { bool result = 18446744073709551615 == u64; Assert.False(result); }
            { bool result = 18446744073709551615 != u64; Assert.True(result); }
        }

    }
}
