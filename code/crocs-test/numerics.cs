using crocs_obj;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

//Problem: c# primitives don't implement IDisposable.
//This one is rather important... wouldn't want to create LinkedListObj<T> class and LinkedListPrimitive<T> class. No way.
//we need a common disposable root type.

using i8_psi = System.SByte;

namespace crocs_obj
{
    public struct i16 : IDisposable
    {
        
        private short value;
        //public i8_psi p;

        private i16(short value)
        {
            value = 0;
            this.value = value;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public static implicit operator short(i16 value)
        {
            return value.value;
        }

        public static implicit operator i16(short value)
        {
            return new i16(value);
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
            i16 a = 123;
            i16 aa = 123;
            i16 ac = (i16)(a + aa);

            short b = a;
            i16 c = (short)(b + a);
            short s1 = 1;
            short s2 = 3;
            short s3 = (short)(s1 + s2);
            s1 += s2;

            using i16 num = 66;
        }
    }

}
