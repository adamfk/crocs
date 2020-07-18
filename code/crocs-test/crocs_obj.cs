using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace crocs.lang
{
    public class crocs_obj : IDisposable
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
