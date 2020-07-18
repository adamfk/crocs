using System.Reflection;
using System.Runtime.Serialization;

namespace crocs.lang
{
    public class mem<T> where T : crocs_obj
    {
        private T obj;

        public mem(T obj)
        {
            this.obj = obj;
        }

        /// <summary>
        /// copies a memory object to a reference of that type.
        /// When would you use this? To receive a structure by reference from a function.
        /// </summary>
        public static implicit operator T(mem<T> mem)
        {
            return memory.shallow_clone<T>(mem.obj);
        }

        //opt for explicit memory copies for now
        ///// <summary>
        ///// copies an object to a memory block of that type
        ///// When would you use this? To return a structure by copy from a function.
        ///// </summary>
        //public static implicit operator mem<T>(T obj)
        //{
        //    return new mem<T>(memory.shallow_clone<T>(obj));
        //}
    }

    public class memory
    {
        public static mem<T> copy<T>(T source) where T: crocs_obj
        {
            return new mem<T>(source);
        }

        public static void copy_to<T>(T destination, T source) where T : crocs_obj
        {
            destination._throw_if_destructed();
            source._throw_if_destructed();

            //use reflection to construct field objects
            var fields = destination.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in fields)
            {
                field.SetValue(destination, field.GetValue(source));
            }
        }

        //source doesn't need to have a public parameterless constructor.
        public static T shallow_clone<T>(T source) where T : crocs_obj
        {
            //see https://stackoverflow.com/questions/390578/creating-instance-of-type-without-default-constructor-in-c-sharp-using-reflectio
            T copy = (T)FormatterServices.GetUninitializedObject(typeof(T)); //does not call ctor

            memory.copy_to(copy, source);

            return copy;
        }

        /// <summary>
        /// stack allocates and constructs an object
        /// Prefer to use this method if your object has no default constructor.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static mem<T> place<T>() where T : crocs_obj, new()
        {
            return new mem<T>(new T());
        }

        /// <summary>
        /// stack allocates an already constructed object.
        /// use when your object has no default constructor.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>        
        public static mem<T> place<T>(T obj) where T : crocs_obj
        {
            return new mem<T>(obj);
        }
    }

    public static class memory_extensions
    {
        public static void copy_from<T>(this T copy_to, T copy_from) where T : crocs_obj
        {
            memory.copy_to(source: copy_to, destination: copy_from);
        }

        ////this method not needed as mem<T> will implicitly convert to T
        //public static void copy_from<T>(this T copy_to, mem<T> copy_from) where T : crocs_obj
        //{
        //    memory.copy_to(source:copy_to, destination: copy_from);
        //}
    }

}
