using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;

namespace crocs_sim
{
    public class TypeInfo
    {
        public readonly bool is_signed;
        public readonly char sign_char;
        public readonly int width;
        public readonly string memory_name;
        public readonly string full_name;   //differs for references which aren't implemented anymore. may be added back later

        public TypeInfo(string type_name)
        {
            var regex = new Regex(@"([iu])(\d+)");

            Match match = regex.Match(type_name);

            sign_char = match.Groups[1].Value[0];
            width = int.Parse(match.Groups[2].Value);

            is_signed = sign_char == 'i';

            memory_name = "" + sign_char + width;
            full_name = type_name;
        }

        public string ToBinary(decimal value)
        {
            string v = memory_name switch
            {
                "i8" => Convert.ToString(unchecked((byte)(SByte)value), 2),
                "i16" => Convert.ToString((Int16)value, 2),
                "i32" => Convert.ToString((Int32)value, 2),
                "i64" => Convert.ToString((Int64)value, 2),
                "u8" => Convert.ToString((Byte)value, 2),
                "u16" => Convert.ToString(unchecked((Int16)(UInt16)value), 2),
                "u32" => Convert.ToString(unchecked((Int32)(UInt32)value), 2),
                "u64" => Convert.ToString(unchecked((Int64)(ulong)value), 2),
                _ => throw new Exception(),
            };
            return v;
        }

        public decimal GetMinValue()
        {
            return memory_name switch
            {
                "i8" => SByte.MinValue,
                "i16" => Int16.MinValue,
                "i32" => Int32.MinValue,
                "i64" => Int64.MinValue,
                "u8" => Byte.MinValue,
                "u16" => UInt16.MinValue,
                "u32" => UInt32.MinValue,
                "u64" => UInt64.MinValue,
                _ => throw new Exception(),
            };
        }

        public decimal GetMaxValue()
        {
            return memory_name switch
            {
                "i8" => SByte.MaxValue,
                "i16" => Int16.MaxValue,
                "i32" => Int32.MaxValue,
                "i64" => Int64.MaxValue,
                "u8" => Byte.MaxValue,
                "u16" => UInt16.MaxValue,
                "u32" => UInt32.MaxValue,
                "u64" => UInt64.MaxValue,
                _ => throw new Exception(),
            };
        }

        public string GetBackingTypeName()
        {
            string backing_type;

            switch (memory_name)
            {
                case "i8": backing_type = "sbyte"; break;
                case "i16": backing_type = "short"; break;
                case "i32": backing_type = "int"; break;
                case "i64": backing_type = "long"; break;
                case "u8": backing_type = "byte"; break;
                case "u16": backing_type = "ushort"; break;
                case "u32": backing_type = "uint"; break;
                case "u64": backing_type = "ulong"; break;
                default: throw new Exception();
            }

            return backing_type;
        }

        public static TypeInfo GetSingleUnsignedType(TypeInfo a, TypeInfo b)
        {
            TypeInfo result_a = (a.is_signed == false) ? a : null;
            TypeInfo result_b = (b.is_signed == false) ? b : null;

            if (result_a != null && result_b != null)
            {
                throw new Exception("only one should be");
            }

            return result_a ?? result_b;
        }

        public static TypeInfo GetSingleSignedType(TypeInfo a, TypeInfo b)
        {
            TypeInfo result_a = (a.is_signed) ? a : null;
            TypeInfo result_b = (b.is_signed) ? b : null;

            if (result_a != null && result_b != null)
            {
                throw new Exception("only one should be");
            }

            return result_a ?? result_b;
        }

        public (TypeInfo unsigned, TypeInfo signed) DetermineUnsignedSigned(TypeInfo a, TypeInfo b)
        {
            (TypeInfo unsigned, TypeInfo signed) result = (GetSingleUnsignedType(a, b), GetSingleSignedType(a, b));
            return result;
        }

        public TypeInfo GetResultType(TypeInfo other)
        {
            int width = Math.Max(this.width, other.width);
            char sign_char;

            if (is_signed ^ other.is_signed)
            {
                sign_char = 'i';

                if (this.CanPromoteToOrViceVersa(other))
                {
                    //nothing to do
                }
                else
                {
                    width *= 2; //needs to promote to next largest
                }
            }
            else if (is_signed)
            {
                //both signed
                sign_char = 'i';
            }
            else
            {
                //both unsigned
                sign_char = 'u';
            }

            var result = new TypeInfo("" + sign_char + width);
            return result;
        }

        public TypeInfo GetResultTypeFromLiteral(decimal literal_value)
        {
            TypeInfo result;
            int new_width = width;

            if (literal_value >= 0)
            {
                //want literal value to stick with sign of this type

                while (true)
                {

                    result = new TypeInfo("" + sign_char + new_width);

                    decimal max = result.GetMaxValue();
                    decimal min = result.GetMinValue();

                    if (literal_value <= max && literal_value >= min)
                    {
                        break;
                    }
                    else
                    {
                        new_width *= 2;
                    }
                }
            }
            else
            {
                //literal value is negative. result type must be signed
                while (true)
                {
                    //want literal value to stick with sign of this type
                    result = new TypeInfo("i" + new_width);

                    decimal max = result.GetMaxValue();
                    decimal min = result.GetMinValue();

                    if (literal_value <= max && literal_value >= min)
                    {
                        break;
                    }
                    else
                    {
                        new_width *= 2;
                    }
                }

            }

            return result;
        }

        public bool CanPromoteTo(TypeInfo other)
        {
            bool canPromote;

            if (is_signed && !other.is_signed)
            {
                canPromote = false;
            }
            else
            {
                canPromote = width < other.width;
            }

            return canPromote;
        }

        public bool CanPromoteToOrViceVersa(TypeInfo other)
        {
            return this.CanPromoteTo(other) || other.CanPromoteTo(this);
        }

        public TypeInfo? GetSmallerSameSign()
        {
            int newWidth = this.width / 2;

            if (newWidth >= 8)
            {
                return new TypeInfo(sign_char + width.ToString());
            }
            return null;
        }

        public bool Equals(TypeInfo other)
        {
            return full_name.Equals(other.full_name);
        }
    }

    public class GenSimNumerics
    {
        //[Fact]
        //public void MakeI8()
        //{
        //    var dir_path = @"..\..\..\";
        //    var output = Build("i8");
        //    File.WriteAllText(dir_path + "i8.cs", output);
        //}
        private static readonly TypeInfo[] types = {
            new TypeInfo("i8"), new TypeInfo("i16"), new TypeInfo("i32"), new TypeInfo("i64"), new TypeInfo("u8"), new TypeInfo("u16"), new TypeInfo("u32"), new TypeInfo("u64"),
        };

        [Fact]
        public void MakeAll()
        {
            const string dir_path = @"..\..\..\..\crocs-test\generated\";

            foreach (var type in types)
            {
                var output = Build(type);
                File.WriteAllText(dir_path + type.full_name + ".cs", output);
            }
        }

        [Fact]
        public void GenTests()
        {
            const string dir_path = @"..\..\..\..\crocs-test\generated\";
            var output = $@"
//NOTE! AUTO GENERATED

using crocs.lang;
using Xunit;
using FluentAssertions;

namespace torc
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

        static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
        {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

        public string GenLiteralConversionTest()
        {
            var inner = "";
            var tab = "            ";
            foreach (var type in types)
            {
                void genInner(decimal value)
                {
                    inner += tab + $"{{ {type.full_name} n = {value}; Assert.Equal<{type.memory_name}>({value}, n); }}\n";

                    var binary = type.ToBinary(value);
                    binary = String.Join("_", ChunksUpto(binary, 4));
                    binary = $"0b{binary}";
                    if (value < 0)
                    {
                        binary = $"unchecked(({type.GetBackingTypeName()}){binary})";
                    }
                    inner += tab + $"{{ {type.full_name} n = {value}; Assert.Equal<{type.memory_name}>({binary}, n); }}\n";
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
                var widerTypes = GetWideningConversions(type);

                foreach (var widerType in widerTypes)
                {
                    inner += tab + $"{{ {type.full_name} n = {type.GetMaxValue()}; {type.full_name}r r = n.r; {widerType.full_name} wider = n; Assert.Equal<{widerType.memory_name}>({type.GetMaxValue()}, wider); wider = r; Assert.Equal<{widerType.memory_name}>({type.GetMaxValue()}, wider);}}\n";
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

                topDecl += tab + $"{type.full_name} {type.full_name} = {type.memory_name}.r;\n";

                foreach (var otherType in types)
                {
                    var resultType = type.GetResultType(otherType);
                    if (resultType.width > 64) continue;

                    //{ i32 result = u16 + i8; Assert.Equal<int>(2, result); }
                    inner += tab + $"{{ {resultType.full_name} result = {type.full_name} + {otherType.full_name}; Assert.Equal<{resultType.memory_name}>(2, result); }}\n";
                    pickyInner += tab + $"{{ var result = {type.full_name} + {otherType.full_name}; Assert.IsType<{resultType.full_name}>(result); Assert.Equal<{resultType.memory_name}>(2, result); }}\n";

                    resultType = type.GetResultTypeFromLiteral(otherType.GetMaxValue() - 1);

                    inner += tab + $"{{ {resultType.full_name} result = {type.full_name} + {otherType.GetMaxValue() - 1}; Assert.Equal<{resultType.memory_name}>({otherType.GetMaxValue()}, result); }}\n";

                    //{ var result = u16 + i8; Assert.IsType<i32>(result); Assert.Equal<int>(2, result); }
                    pickyInner += tab + $"{{ var result = {type.full_name} + {otherType.GetMaxValue() - 1}; Assert.IsType<{resultType.full_name}>(result); Assert.Equal<{resultType.memory_name}>({otherType.GetMaxValue()}, result); }}\n";
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

        private static string GenOverflowChecks(TypeInfo typeInfo)
        {
            if (typeInfo.width >= 64)
            {
                return "";
            }

            var overflowChecks = $@"
            if (value < {typeInfo.memory_name}.MIN) {{ throw new Exception(""underflow!""); }}
            if (value > {typeInfo.memory_name}.MAX) {{ throw new Exception(""overflow!"");  }}
                ".Trim();

            return overflowChecks;
        }

        public string Build(TypeInfo typeInfo)
        {
            string backing_type = typeInfo.GetBackingTypeName();

            List<TypeInfo> smallerTypes = GetSmallerTypes(typeInfo);

            var wideningConversions = "";

            var asTypeConversions = ""; //needed for mixing signed and unsigned where the unsigned needs promoting

            var widenToTypes = GetWideningConversions(typeInfo);
            foreach (var widerType in widenToTypes)
            {
                wideningConversions += $"        public static implicit operator {widerType.memory_name}({typeInfo.memory_name} num) {{ return num._value; }}\n";
                asTypeConversions += $"\n        public {widerType.memory_name} as_{widerType.memory_name} => _value;";
            }

            var narrowingConversions = "";
            var wrappingConversions = "";
            //var saturatingConversions = FINISH ME //TODO finish

            foreach (var narrowTypeInfo in smallerTypes)
            {
                var narrowTypeName = narrowTypeInfo.memory_name;

                //TODOLOW don't use decimal types
                narrowingConversions += $@"
        public {narrowTypeName} as_{narrowTypeName}_ort {{
            get {{
                var vv = _value;
                decimal v = vv;
                if (v > {narrowTypeName}.MAX || v < {narrowTypeName}.MIN)
                {{
                    throw new System.OverflowException(""value "" + vv + "" too large for {narrowTypeName}"");
                }}
                return ({narrowTypeInfo.GetBackingTypeName()})vv;
            }}
        }}
";

                wrappingConversions += $"        public {narrowTypeName} wrap_to_{narrowTypeName} => unchecked(({narrowTypeInfo.GetBackingTypeName()})_value);\n";
            }

            var template = $@"
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace torc.lang
{{
    public struct {typeInfo.memory_name} : ICrocsObj
    {{
        private bool _destructed;

        public const {backing_type} MAX = {typeInfo.GetMaxValue()};
        public const {backing_type} MIN = {typeInfo.GetMinValue()};

        private {backing_type} _value;

        public {typeInfo.memory_name}({backing_type} value)
        {{
            _destructed = false;
            _value = value;
        }}

        public void Dispose()
        {{
            _destructed = true;
        }}

        public void _throw_if_destructed()
        {{
            if (_destructed)
            {{
                throw new MemberAccessException();
            }}
        }}

        public static implicit operator {typeInfo.memory_name}({backing_type} num) {{ return new {typeInfo.memory_name}(num); }}
        public static implicit operator {backing_type}({typeInfo.memory_name} num) {{ return num._value; }}
        public static implicit operator decimal({typeInfo.memory_name} num) {{ return num._value; }}

        {asTypeConversions}

        { wideningConversions.Trim() }

        { narrowingConversions.Trim() }

        { wrappingConversions.Trim() }

        { GenComparisonOperator(typeInfo, "==") + "\n" }
        { GenComparisonOperator(typeInfo, "!=") + "\n" }

        { GenOverflowingOperator(typeInfo, "+") + "\n" }


        public override string ToString()
        {{
            return _value.ToString();
        }}

        public override int GetHashCode()
        {{
            return _value.GetHashCode();
        }}

        public override bool Equals(object obj)
        {{
            if (obj == null) {{ return false; }}
            if (ReferenceEquals(this, obj)) {{ return true; }}

            decimal value;

            switch (obj)
            {{
                case sbyte  i: value = i; break;
                case short  i: value = i; break;
                case int    i: value = i; break;
                case long   i: value = i; break;
                case byte   i: value = i; break;
                case ushort i: value = i; break;
                case uint   i: value = i; break;
                case ulong  i: value = i; break;

                case i8  i: value = i;  break;
                case i16 i: value = i; break;
                case i32 i: value = i; break;
                case i64 i: value = i; break;
                case u8  i: value = i;  break;
                case u16 i: value = i; break;
                case u32 i: value = i; break;
                case u64 i: value = i; break;

                default: return false;
            }}

            if (value < MIN || value > MAX) {{ return false; }}
            return value == ({backing_type})value;
        }}
    }}

}}
";

            return template;
        }


        private static string GenOverflowingOperator(TypeInfo classType, string op)
        {
            var result = "";

            //for mixing signed and unsigned
            //foreach (var otherType in types)
            //{
            //    if (classType.is_signed == otherType.is_signed) continue;    //only care about mixing

            //    TypeInfo resultType = classType.GetResultType(otherType);
            //    if (resultType.width > 64) continue;

            //    if (classType.is_signed == false && classType.CanPromoteToOrViceVersa(otherType) == false)
            //    {
            //        result += GenOverflowingOperator(classType, "IHas" + otherType.full_name.ToUpper(), resultType, op, otherValueGetter: $"b");
            //    }
            //}

            //foreach (var otherType in types)
            //{
            //    TypeInfo resultType = classType.GetResultType(otherType);
            //    if (resultType.width > 64) continue;

            //    result += GenOverflowingOperator(classType, otherType.full_name, resultType, op);
            //}

            //{ i32 result = i16 + 65534; Assert.Equal<int>(65535, result); }
            foreach (var otherType in types)
            {
                TypeInfo resultType = classType.GetResultType(otherType);
                if (resultType.width > 64) continue;
                if (resultType.width <= classType.width) continue;
                if (classType.CanPromoteTo(otherType))
                {
                    result += GenOverflowingOperator(classType, otherType.memory_name, resultType, op);
                }
            }

            return result;
        }

        private static string GenOverflowingOperator(TypeInfo classType, string otherTypeName, TypeInfo resultType, string op, string otherValueGetter = null)
        {
            otherValueGetter = otherValueGetter ?? $"b";

            var template = $@"
        public static {resultType.full_name} operator {op}({classType.full_name} a, {otherTypeName} b)
        {{
            var value = (decimal)a {op} (decimal){otherValueGetter};
            {GenOverflowChecks(resultType)}
            {resultType.full_name} result = ({resultType.GetBackingTypeName()})value;
            return result;
        }}";
            return template.Trim();
        }

        private static string GenComparisonOperator(TypeInfo classType, string op)
        {
            var backingType = classType.GetBackingTypeName();
            var crocsType = classType.full_name;
            var template = $@"
        public static bool operator {op}({crocsType} a, {crocsType} b)
        {{
            var result = ({backingType})a {op} ({backingType})b;
            return result;
        }}";
            return template.Trim();
        }


        private static List<TypeInfo> GetWideningConversions(TypeInfo typeInfo)
        {
            List<TypeInfo> wideningConversions = new List<TypeInfo>();
            AddWideningForWidth(wideningConversions, typeInfo.sign_char, typeInfo.width);

            if (typeInfo.is_signed == false)
            {
                AddWideningForWidth(wideningConversions, 'i', typeInfo.width);
            }

            return wideningConversions;
        }

        private static List<TypeInfo> GetSmallerTypes(TypeInfo info)
        {
            List<TypeInfo> smallerTypes = new List<TypeInfo>();
            int width = info.width;
            var other_sign = info.is_signed ? "u" : "i";

            smallerTypes.Add(new TypeInfo(other_sign + info.width));

            while (true)
            {
                width /= 2;
                if (width < 8)
                {
                    break;
                }
                smallerTypes.Add(new TypeInfo("i" + width));
                smallerTypes.Add(new TypeInfo("u" + width));
            }

            return smallerTypes;
        }

        private static void AddWideningForWidth(List<TypeInfo> wideningConversions, char sign_char, int width)
        {
            while (true)
            {
                width *= 2;
                if (width > 64)
                {
                    break;
                }
                wideningConversions.Add(new TypeInfo("" + sign_char + width));
            }
        }
    }
}
