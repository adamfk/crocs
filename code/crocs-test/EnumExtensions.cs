using crocs.lang;
using System;
using Xunit;

namespace crocs.lang
{
    public static class EnumExtensions
    {
        private static decimal enum_value_to_decimal(this Enum value)
        {
            //https://stackoverflow.com/questions/3565310/getting-enum-value-via-reflection
            Type underlyingType = Enum.GetUnderlyingType(value.GetType());
            object underlyingValue = Convert.ChangeType(value, underlyingType);

            decimal decimal_value;

            switch (underlyingValue)
            {
                case SByte v: decimal_value = v; break;
                case Int16 v: decimal_value = v; break;
                case Int32 v: decimal_value = v; break;
                case Int64 v: decimal_value = v; break;
                case Byte v: decimal_value = v; break;
                case UInt16 v: decimal_value = v; break;
                case UInt32 v: decimal_value = v; break;
                case UInt64 v: decimal_value = v; break;
                default: throw new Exception("unknown underlying type type: " + underlyingType);
            }

            return decimal_value;
        }

        public static i8 to_i8_ort(this Enum value)
        {
            return Numerics.sim_convert_to_i8_ort(enum_value_to_decimal(value));
        }

        public static i8 wrap_to_i8(this Enum value)
        {
            //TODOLOW decide on "wrap" or "truncate" terminology
            return Numerics.sim_truncate_to_i8(enum_value_to_decimal(value));
        }
    }
}


namespace enum_tests
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
    public enum FruitId : short
    {
        APPLE, ORANGE, BANANA_2000 = 2000
    }

    public class EnumTests
    {

        [Fact]
        public void enum_cast_throws()
        {
            FruitId fruit_id = FruitId.BANANA_2000;

            Assert.Throws<OverflowException>(() => {
                u8 b = (byte)fruit_id;  //throws if overflow checks are enabled. Bad otherwise.
            });
        }

        [Fact]
        public void to_i8_ort()
        {
            //u8 b = (byte)FruitId.BANANA_2000;  //good! causes compilation error

            FruitId fruit_id = FruitId.BANANA_2000;

            Assert.Throws<OverflowException>(() => {
                i8 i8 = fruit_id.to_i8_ort();
            });
        }

        [Fact]
        public void wrap_to_i8()
        {
            FruitId fruit_id = FruitId.BANANA_2000;

            i8 i8 = fruit_id.wrap_to_i8();
            Assert.Equal(-48, i8);
        }
    }
}