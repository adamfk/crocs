using System.Collections.Generic;
using System.IO;
using Xunit;


//TODO put in num._throw_if_destructed(); in as many places as possible
//TODO check widening conversions. I think some are missing.

namespace crocs_sim
{
    public class GenSimNumerics
    {
        public static readonly string dir_path = @"..\..\..\..\crocs-test\generated\";
        
        public static readonly TypeInfo[] types = {
            new TypeInfo("i8"), new TypeInfo("i16"), new TypeInfo("i32"), new TypeInfo("i64"), new TypeInfo("u8"), new TypeInfo("u16"), new TypeInfo("u32"), new TypeInfo("u64"),
        };

        [Fact]
        public void MakeAll()
        {
            foreach (var type in types)
            {
                var output = Build(type);
                File.WriteAllText(dir_path + type.crocs_name + ".cs", output);
            }
        }

        [Fact]
        public void OutputNumericsMethods()
        {
            File.WriteAllText(dir_path + "numerics_methods.txt", BuildConvertToTypeOrtFunctions());
        }

        public string BuildConvertToTypeOrtFunctions()
        {
            string output = "";
            foreach (var type in types)
            {
                var narrowTypeName = type.crocs_name;

                //TODOLOW don't use decimal types
                output += $@"
        public static {narrowTypeName} convert_to_{narrowTypeName}_ort(decimal value)
        {{
            if (value > {narrowTypeName}.MAX || value < {narrowTypeName}.MIN)
            {{
                throw new System.OverflowException(""value "" + value + "" too large for {narrowTypeName}"");
            }}
            return ({type.GetBackingTypeName()})value;
        }}
";
            }

            return output;
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
                wideningConversions += $"        public static implicit operator {widerType.crocs_name}({typeInfo.crocs_name} num) {{ return num._value; }}\n";
                asTypeConversions += $"        public {widerType.crocs_name} as_{widerType.crocs_name} => _value;\n";
            }

            var narrowingConversions = "";
            var wrappingConversions = "";
            //var saturatingConversions = FINISH ME //TODOLOW finish

            foreach (var narrowTypeInfo in smallerTypes)
            {
                var narrowTypeName = narrowTypeInfo.crocs_name;

                //TODOLOW don't use decimal types
                narrowingConversions += $"        public {narrowTypeName} as_{narrowTypeName}_ort => Numerics.convert_to_{narrowTypeName}_ort(_value);\n";

                wrappingConversions += $"        public {narrowTypeName} wrap_to_{narrowTypeName} => unchecked(({narrowTypeInfo.GetBackingTypeName()})_value);\n";
            }

            var template = $@"
//NOTE! AUTO GENERATED FILE
using System;
using crocs.lang;

#pragma warning disable IDE1006 // Naming Styles

namespace crocs.lang
{{
    public struct {typeInfo.crocs_name} : ICrocsObj, IHas{typeInfo.crocs_name.ToUpper()}
    {{
        private bool _destructed;

        public const {backing_type} MAX = {typeInfo.GetMaxValue()};
        public const {backing_type} MIN = {typeInfo.GetMinValue()};

        private {backing_type} _value;

        public {typeInfo.crocs_name}({backing_type} value)
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

        public static implicit operator {typeInfo.crocs_name}({backing_type} num) {{ return new {typeInfo.crocs_name}(num); }}
        public static implicit operator {backing_type}({typeInfo.crocs_name} num) {{ return num._value; }}
        public static implicit operator decimal({typeInfo.crocs_name} num) {{ return num._value; }}

        //explicit widening conversions
        { asTypeConversions.Trim() }

        //implicit widening conversions
        { wideningConversions.Trim() }

        //narrowing conversions
        { narrowingConversions.Trim() }

        //wrapping conversions
        { wrappingConversions.Trim() }

        //comparison operators
        { GenComparisonOperator(typeInfo, "==") }
        { GenComparisonOperator(typeInfo, "!=") }
        //TODO add more operators

        //overflowing operators
        { GenOverflowingOperator(typeInfo, "+").Trim() }
        //TODO add more operators

        public override string ToString() => _value.ToString();

        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj) => Numerics.object_equals_number(obj, _value);
    }}

}}
";

            return template;
        }


        private static string GenOverflowingOperator(TypeInfo classType, string op)
        {
            var result = "";

            result += GenOverflowingOperator(classType, classType.crocs_name, classType, op);

            //for mixing signed and unsigned
            // See https://github.com/adamfk/crocs/issues/12 specifically for IHas
            foreach (var otherType in types)
            {
                if (classType.is_signed == otherType.is_signed) continue;    //only care about mixing

                TypeInfo resultType = classType.GetResultType(otherType);
                if (resultType.width > 64) continue;

                if (classType.is_signed == false && classType.CanPromoteToOrViceVersa(otherType) == false)
                {
                    result += GenOverflowingOperator(classType, "IHas" + otherType.crocs_name.ToUpper(), resultType, op, otherValueGetter: $"({otherType.crocs_name})b");
                }
            }

            //{ i32 result = i16 + 65534; Assert.Equal<int>(65535, result); }
            foreach (var otherType in types)
            {
                TypeInfo resultType = classType.GetResultType(otherType);
                if (resultType.width > 64) continue;
                if (resultType.width <= classType.width) continue;
                if (classType.CanPromoteTo(otherType) && classType.is_signed == otherType.is_signed)
                {
                    result += GenOverflowingOperator(classType, otherType.crocs_name, resultType, op);
                }
            }

            return result;
        }

        private static string GenOverflowingOperator(TypeInfo classType, string otherTypeName, TypeInfo resultType, string op, string otherValueGetter = "b")
        {
            return $"        public static {resultType.crocs_name} operator {op}({classType.crocs_name} a, {otherTypeName} b) => Numerics.convert_to_{resultType.crocs_name}_ort((decimal)a + (decimal){otherValueGetter});\n";
        }

        private static string GenComparisonOperator(TypeInfo classType, string op)
        {
            var backingType = classType.GetBackingTypeName();
            var crocsType = classType.crocs_name;
            return $"public static bool operator {op}({crocsType} a, {crocsType} b) => ({backingType})a {op} ({backingType})b;";
        }


        public static List<TypeInfo> GetWideningConversions(TypeInfo typeInfo)
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
