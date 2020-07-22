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
        private const string indent = "            ";
        static readonly string dir_path = GenSimNumerics.dir_path;
        static readonly TypeInfo[] types = GenSimNumerics.types;
        readonly string varTypeOneValueDefinitions = "";    //i8 i8 = 1; i16 i16 = 1; ...

        public GenSimNumericTests()
        {
            var varTypeOneValueDefinitions = "";    
            foreach (var type in types)
            {
                varTypeOneValueDefinitions += indent + $"{type.crocs_name} {type.crocs_name} = 1;\n";
            }
            this.varTypeOneValueDefinitions = varTypeOneValueDefinitions.Trim();
        }

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
        {GenAdditionTests()}
        {GenSubtractionTests()}
        {GenMultiplicationTests()}
        {GenDivisionTests()}
        {GenModulusTests()}
        {GenBinaryOrTests()}
        {GenBinaryAndTests()}
        { GenBinaryXorTests()}
    }}
}}
";

            //
            //{ GenBinaryShiftLeftTests()}
            //{ GenBinaryShiftRightTests()}
            //{ GenBinaryInversionTests()}

            File.WriteAllText(dir_path + "AllNumericTests.cs", output);
        }

        public string GenLiteralConversionTest()
        {
            var inner = "";
            foreach (var type in types)
            {
                void genInner(decimal value)
                {
                    inner += indent + $"{{ {type.crocs_name} n = {value}; Assert.Equal<{type.crocs_name}>({value}, n); }}\n";

                    var binary = type.ToBinary(value);
                    binary = String.Join("_", ChunksUpto(binary, 4));
                    binary = $"0b{binary}";
                    if (value < 0)
                    {
                        binary = $"unchecked(({type.GetBackingTypeName()}){binary})";
                    }
                    inner += indent + $"{{ {type.crocs_name} n = {value}; Assert.Equal<{type.crocs_name}>({binary}, n); }}\n";
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
            foreach (var type in types)
            {
                var widerTypes = GenSimNumerics.GetWideningConversions(type);

                foreach (var widerType in widerTypes)
                {
                    inner += indent + $"{{ {type.crocs_name} n = {type.GetMaxValue()}; {widerType.crocs_name} wider = n; Assert.Equal<{widerType.crocs_name}>({type.GetMaxValue()}, wider); Assert.Equal<{widerType.crocs_name}>({type.GetMaxValue()}, wider);}}\n";
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

        public string GenSubtractionTests()
        {
            var inner = "";
            foreach (var type in types)
            {
                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;

                    //{ i32 result = u16 - i8; Assert.Equal<i32>(0, result); }
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} - {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(0, result); }}\n";
                    //{ var result = u16 - i8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
                    inner += indent + $"{{ var result = {type.crocs_name} - {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(0, result); }}\n";
                    inner += indent + $"{{ var result = {type.crocs_name} - 1; Assert.IsType<{type.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(0, result); }}\n";
                }
            }

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void SubtractionTest()
        {{
            {varTypeOneValueDefinitions}
            {inner.Trim()}
        }}
        ";

            return output.Trim();
        }

        public string GenMultiplicationTests()
        {
            var inner = "";
            foreach (var type in types)
            {
                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;

                    //{ i32 result = u16 * i8; Assert.Equal<i32>(1, result); }
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} * {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(1, result); }}\n";
                    //{ var result = u16 * i8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
                    inner += indent + $"{{ var result = {type.crocs_name} * {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(1, result); }}\n";
                }
            }

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void MultiplicationTest()
        {{
            {varTypeOneValueDefinitions}
            {inner.Trim()}
        }}
        ";

            return output.Trim();
        }

        public string GenDivisionTests()
        {
            var inner = "";
            foreach (var type in types)
            {
                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;

                    //{ i32 result = u16 / i8; Assert.Equal<i32>(1, result); }
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} / {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(1, result); }}\n";
                    //{ var result = u16 / i8; Assert.IsType<i32>(result); Assert.Equal<i32>(1, result); }
                    inner += indent + $"{{ var result = {type.crocs_name} / {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(1, result); }}\n";
                }
            }

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void DivisionTest()
        {{
            {varTypeOneValueDefinitions}
            {inner.Trim()}
        }}
        ";

            return output.Trim();
        }

        public string GenModulusTests()
        {
            var inner = "";
            foreach (var type in types)
            {
                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;

                    //{ i32 result = u16 % i8; Assert.Equal<i32>(0, result); }
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} % {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(0, result); }}\n";
                    //{ var result = u16 % i8; Assert.IsType<i32>(result); Assert.Equal<i32>(0, result); }
                    inner += indent + $"{{ var result = {type.crocs_name} % {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(0, result); }}\n";
                }
            }

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void ModulusTest()
        {{
            {varTypeOneValueDefinitions}
            {inner.Trim()}
        }}
        ";

            return output.Trim();
        }

        //GenBinaryOrTests
        public string GenBinaryOrTests()
        {
            var inner = "";
            foreach (var type in types)
            {
                if (type.is_signed) continue;

                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;
                    if (resultType.is_signed) continue;

                    //{ u16 result = u16 | 0b0010; Assert.Equal<u16>(0b0011, result); }
                    inner += indent + $"{{ {type.crocs_name} result = {type.crocs_name} | 0b0010; Assert.Equal<{type.crocs_name}>(0b0011, result); }}\n";
                    inner += indent + $"{{ {otherType.crocs_name} b = 0b1100; {resultType.crocs_name} result = {type.crocs_name} | b; Assert.Equal<{resultType.crocs_name}>(0b1101, result); }}\n";
                    //{ u32 result = u16 | u32; Assert.Equal<u32>(0b0001, result); }
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} | {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(0b0001, result); }}\n";
                    inner += indent + $"{{ var result = {type.crocs_name} | {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(1, result); }}\n";
                }
            }

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void BinaryOrTest()
        {{
            {varTypeOneValueDefinitions}
            {inner.Trim()}
        }}
        ";

            return output.Trim();
        }

        public string GenBinaryAndTests()
        {
            var inner = "";
            foreach (var type in types)
            {
                if (type.is_signed) continue;

                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;
                    if (resultType.is_signed) continue;

                    inner += indent + $"{{ {type.crocs_name} result = {type.crocs_name} & 0b0011; Assert.Equal<{type.crocs_name}>(0b0001, result); }}\n";
                    inner += indent + $"{{ {otherType.crocs_name} b = 0b1111; {resultType.crocs_name} result = {type.crocs_name} & b; Assert.Equal<{resultType.crocs_name}>(0b0001, result); }}\n";
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} & {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(0b0001, result); }}\n";
                    inner += indent + $"{{ var result = {type.crocs_name} & {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(1, result); }}\n";
                }
            }

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void BinaryAndTest()
        {{
            {varTypeOneValueDefinitions}
            {inner.Trim()}
        }}
        ";

            return output.Trim();
        }

        public string GenBinaryXorTests()
        {
            var inner = "";
            foreach (var type in types)
            {
                if (type.is_signed) continue;

                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;
                    if (resultType.is_signed) continue;

                    inner += indent + $"{{ {type.crocs_name} result = {type.crocs_name} ^ 0b0011; Assert.Equal<{type.crocs_name}>(0b0010, result); }}\n";
                    inner += indent + $"{{ {otherType.crocs_name} b = 0b1111; {resultType.crocs_name} result = {type.crocs_name} ^ b; Assert.Equal<{resultType.crocs_name}>(0b1110, result); }}\n";
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} ^ {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(0b0000, result); }}\n";
                    inner += indent + $"{{ var result = {type.crocs_name} ^ {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(0, result); }}\n";
                }
            }

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void BinaryXorTest()
        {{
            {varTypeOneValueDefinitions}
            {inner.Trim()}
        }}
        ";

            return output.Trim();
        }

        public string GenAdditionTests()
        {
            //TODO test overflows

            var inner = "";
            var implicitTestInner = "";
            foreach (var type in types)
            {
                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;

                    //{ i32 result = u16 + i8; Assert.Equal<i32>(2, result); }
                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} + {otherType.crocs_name}; Assert.Equal<{resultType.crocs_name}>(2, result); }}\n";
                    implicitTestInner += indent + $"{{ var result = {type.crocs_name} + {otherType.crocs_name}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>(2, result); }}\n";

                    resultType = type.GetResultTypeFromLiteral(otherType.GetMaxValue() - 1);

                    inner += indent + $"{{ {resultType.crocs_name} result = {type.crocs_name} + {otherType.GetMaxValue() - 1}; Assert.Equal<{resultType.crocs_name}>({otherType.GetMaxValue()}, result); }}\n";

                    //{ var result = u16 + i8; Assert.IsType<i32>(result); Assert.Equal<int>(2, result); }
                    implicitTestInner += indent + $"{{ var result = {type.crocs_name} + {otherType.GetMaxValue() - 1}; Assert.IsType<{resultType.crocs_name}>(result); Assert.Equal<{resultType.crocs_name}>({otherType.GetMaxValue()}, result); }}\n";
                }

                inner += "\n";
            }
            inner = inner.Trim();
            implicitTestInner = implicitTestInner.Trim();

            var output = $@"
        //NOTE! AUTO GENERATED
        [Fact]
        public void AdditionTest()
        {{
            {varTypeOneValueDefinitions}
            {inner}
        }}

        //NOTE! AUTO GENERATED
        [Fact]
        public void AdditionImplicitTypeTest()
        {{
            {varTypeOneValueDefinitions}
            {implicitTestInner}
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
