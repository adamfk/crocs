﻿using System.Reflection;
using System.Runtime.Serialization;

namespace crocs
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

        /// <summary>
        /// copies an object to a memory block of that type
        /// When would you use this? To return a structure by copy from a function.
        /// </summary>
        public static implicit operator mem<T>(T obj)
        {
            return new mem<T>(memory.shallow_clone<T>(obj));
        }
    }

    public class memory
    {
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
    }
}
