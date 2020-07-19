using crocs.lang;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

// See https://github.com/adamfk/crocs/issues/8
namespace numerics_typedef_test
{
    using i8_mv = i8;   //`using` style typedef. See https://github.com/adamfk/crocs/issues/8

    // new type style typedef
    // https://github.com/adamfk/crocs/issues/8
    public struct i8_psi : ICrocsObj, IHasI8
    {
        private bool _destructed;
        private sbyte _value;

        public i8_psi(sbyte value)
        {
            _destructed = false;
            _value = value;
        }

        public void Dispose()
        {
            _destructed = true;
        }

        public void _throw_if_destructed()
        {
            if (_destructed)
            {
                throw new MemberAccessException();
            }
        }

        public static implicit operator i8_psi(sbyte num) { return new i8_psi(num); }
        public static implicit operator i8_psi(i8 num) { return new i8_psi(num); }
        public static implicit operator i8(i8_psi num) { return num._value; }
        //public static implicit operator decimal(i8_psi num) { return num._value; }
    }

    public class Test
    {
        [Fact]
        public void typedef_test1()
        {
            {
                //it all just works... but has some issues too see https://github.com/adamfk/crocs/issues/8
                i8_mv mv = 3;   //`using` style typedef
                mv = 10;
                mv = mv + 10;
            }
            {
                i8_psi psi = 10;
                i8 i8 = 10;
                psi = psi + i8;
                //psi = psi + 1;    //this doesn't work
            }

        }
    }

}

