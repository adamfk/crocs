namespace crocs_test
{
    public class mem<T> where T : crocs_obj, new()
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
            return crocs_obj.shallow_copy<T>(mem.obj);
        }

        /// <summary>
        /// copies an object to a memory block of that type
        /// When would you use this? To return a structure by copy from a function.
        /// </summary>
        public static implicit operator mem<T>(T obj)
        {
            return crocs_obj.shallow_copy<T>(obj);
        }
    }
}
