using crocs.lang;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

//Problem: c# primitives don't implement IDisposable.
//This one is rather important... wouldn't want to create LinkedListObj<T> class and LinkedListPrimitive<T> class. No way.
//we need a common disposable root type.

using i8_psi = System.SByte;

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
