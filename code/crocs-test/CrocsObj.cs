using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace crocs.lang
{
    public interface ICrocsObj : IDisposable
    {
        void _throw_if_destructed();
    }

    public class CrocsObj : ICrocsObj
    {
        private bool destructed = false;

        public void Dispose()
        {
            destructed = true;
        }

        public void _throw_if_destructed()
        {
            if (destructed)
            {
                throw new MemberAccessException();
            }
        }
    }
}
