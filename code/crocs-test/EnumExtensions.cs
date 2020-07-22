using crocs.lang;
using System;
using Xunit;

namespace crocs.lang
{
    public static class EnumExtensions
    {
        public static i8 to_i8_ort(this Enum value)
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

            return Numerics.convert_to_i8_ort(decimal_value);
        }
    }
}


namespace enum_tests
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
    public enum FruitId : short
    {
        APPLE, ORANGE, BANANA = 2000
    }

    public class EnumTests
    {
        [Fact]
        public void hand_test1()
        {
            //enum
            {
                //u8 b = (byte)FruitId.BANANA;  //good! causes compilation error
                FruitId fruit_id = FruitId.BANANA;
                u8 b = (byte)fruit_id;  //bad! silent truncation

                Assert.Throws<OverflowException>(() => {
                    i8 i8 = fruit_id.to_i8_ort();
                });

                Convert.ChangeType(FruitId.ORANGE, FruitId.ORANGE.GetTypeCode());
            }
        }
    }
}