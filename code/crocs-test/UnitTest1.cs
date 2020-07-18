using crocs;
using Xunit;

namespace crocs_test
{

    public class Stereo : crocs_obj
    {
        public int volume;
    }

    public class Example
    {
        public mem<Stereo> build_stereo(int volume)
        {
            using Stereo s1 = stack_mem.place<Stereo>();
            using Stereo s2 = stack_mem.place(new Stereo());
            return s1;
        }

        public Stereo build_stereo_bad(int volume)
        {
            using Stereo s1 = stack_mem.place<Stereo>();
            return s1;  //bad! need code rule to catch this kind of thing.
        }

        public Stereo build_stereo_bad_2(int volume)
        {
            using Stereo s1 = stack_mem.place<Stereo>();
            Stereo s2 = s1;
            return s2;  //bad! need code rule to catch this kind of thing.
        }
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
        }
    }
}
