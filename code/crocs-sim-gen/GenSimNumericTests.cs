using System;
using System.Collections.Generic;
using System.IO;
using Xunit;


//TODO put in num._throw_if_destructed(); in as many places as possible
//TODO check widening conversions. I think some are missing.

namespace crocs_sim
{
    public class GenSimNumericTests
    {
        static readonly string dir_path = GenSimNumerics.dir_path;
        static readonly TypeInfo[] types = GenSimNumerics.types;

        [Fact]
        public void GenTests()
        {
            var output = $@"
//NOTE! AUTO GENERATED

using crocs.lang;
using Xunit;

namespace crocs_tests
{{
    public class AllNumericTests 
    {{
        {GenLiteralConversionTest()}
        {GenWindeningConversionTest()}
        {GenArithmeticTest()}
    }}
}}
";

            File.WriteAllText(dir_path + "AllNumericTests.cs", output);
        }

        public string GenLiteralConversionTest()
        {
            var inner = "";
            var tab = "            ";
            foreach (var type in types)
            {
                void genInner(decimal value)
                {
                    inner += tab + $"{{ {type.crocs_name} n = {value}; Assert.Equal<{type.crocs_name}>({value}, n); }}\n";

                    var binary = type.ToBinary(value);
                    binary = String.Join("_", ChunksUpto(binary, 4));
                    binary = $"0b{binary}";
                    if (value < 0)
                    {
                        binary = $"unchecked(({type.GetBackingTypeName()}){binary})";
                    }
                    inner += tab + $"{{ {type.crocs_name} n = {value}; Assert.Equal<{type.crocs_name}>({binary}, n); }}\n";
                }

                if (type.is_signed)
                {
                    genInner(0);
                    genInner(-1);
                }
                genInner(1);

                genInner(type.GetMinValue());
                genInner(type.GetMaxValue());
                inner += "\n";
            }
            inner = inner.Trim();

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void LiteralToType()
        {{
            {inner}
        }}
";
            return output;
        }

        public string GenWindeningConversionTest()
        {
            var inner = "";
            var tab = "            ";
            foreach (var type in types)
            {
                var widerTypes = GenSimNumerics.GetWideningConversions(type);

                foreach (var widerType in widerTypes)
                {
                    inner += tab + $"{{ {type.crocs_name} n = {type.GetMaxValue()}; {widerType.crocs_name} wider = n; Assert.Equal<{widerType.crocs_name}>({type.GetMaxValue()}, wider); Assert.Equal<{widerType.crocs_name}>({type.GetMaxValue()}, wider);}}\n";
                }

                inner += "\n";
            }
            inner = inner.Trim();

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void WideningConversions()
        {{
            {inner}
        }}
";
            return output;
        }

        public string GenArithmeticTest()
        {
            var inner = "";
            var pickyInner = "";
            var tab = "            ";
            var topDecl = "";
            foreach (var type in types)
            {

                topDecl += tab + $"{type.crocs_name} {type.crocs_name} = 1;\n";

                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;

                    //{ i32 result = u16 + i8; Assert.Equal<int>(2, result); }
                    inner += tab + $"{{ {resultType.crocs_name} result = {type.crocs_name} + {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(2, result); }}\n";
                    pickyInner += tab + $"{{ var result = {type.crocs_name} + {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(2, result); }}\n";

                    resultType = type.GetResultTypeFromLiteral(otherType.GetMaxValue() - 1);

                    inner += tab + $"{{ {resultType.crocs_name} result = {type.crocs_name} + {otherType.GetMaxValue() - 1}; Assert.Equal<{resultType.crocs_name}>({otherType.GetMaxValue()}, result); }}\n";

                    //{ var result = u16 + i8; Assert.IsType<i32>(result); Assert.Equal<int>(2, result); }
                    pickyInner += tab + $"{{ var result = {type.crocs_name} + {otherType.GetMaxValue() - 1}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>({otherType.GetMaxValue()}, result); }}\n";
                }

                inner += "\n";
            }
            topDecl = topDecl.Trim();
            inner = inner.Trim();
            pickyInner = pickyInner.Trim();

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void Arithmetic()
        {{
            {topDecl}
            {inner}
        }}

        //NOTE! AUTO GENERATED
        [Fact]
        public void PickyTypeArithmetic()
        {{
            {topDecl}
            {pickyInner}
        }}
";
            return output;
        }

        static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
        {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

    }
}
