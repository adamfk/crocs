namespace crocs
{
    public class stack_mem
    {
        public static mem<T> place<T>() where T : crocs_obj, new()
        {
            return new T();
        }

        public static mem<T> place<T>(T obj) where T : crocs_obj
        {
            return new mem<T>(obj);
        }
    }
}
