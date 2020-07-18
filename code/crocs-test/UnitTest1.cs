using crocs.lang;
using Xunit;

using static crocs.lang.memory;

namespace crocs_test
{

    public class Stereo : crocs_obj
    {
        public int volume;

        public Stereo()
        {

        }

        public Stereo(int volume)
        {
            this.volume = volume;
        }
    }

    public class Example
    {
        public mem<Stereo> build_stereo(int volume)
        {
            using Stereo s1 = place<Stereo>();
            s1.volume = volume;
            using Stereo s2 = place(new Stereo(volume));
            return copy(s1); //or memory.copy() for full
        }

        //most common scenario. catch with Roslyn code analysis/fix.
        public Stereo build_stereo_bad()
        {
            using Stereo s1 = place<Stereo>();
            return s1;  //bad! need code rule to catch this kind of thing.
        }

        //harder to catch. Low priority.
        public Stereo build_stereo_bad_2()
        {
            using Stereo s1 = memory.place<Stereo>();
            Stereo s2 = s1;
            return s2;  //still bad! need code rule to catch this kind of thing.
        }

        //this one is the hardest to catch and would require indepth analysis. Rely on pre_c simulation, c debugging or more competent users for now.
        public Stereo build_stereo_bad_3()
        {
            Stereo some_external_function_somewhere(Stereo a, Stereo b) { return a; }

            using Stereo s1 = memory.place<Stereo>();
            using Stereo s2 = memory.place<Stereo>();
            Stereo s3 = some_external_function_somewhere(s1, s2);
            return s3;  //still bad! need code rule to catch this kind of thing.
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
