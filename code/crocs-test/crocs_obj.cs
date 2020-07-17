using System;
using System.Reflection;

namespace crocs_test
{
    public class crocs_obj : IDisposable
    {
        private bool destructed = false;

        public void Dispose()
        {
            destructed = true;
        }

        public static T shallow_copy<T>(T source) where T : crocs_obj, new()
        {
            if (source.destructed)
            {
                throw new MemberAccessException();
            }

            T copy = new T();

            //use reflection to construct field objects
            var fields = copy.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in fields)
            {
                var fieldType = field.FieldType;
                var typeToCreate = fieldType;
                field.SetValue(copy, field.GetValue(source));
            }

            return copy;
        }
    }
}
