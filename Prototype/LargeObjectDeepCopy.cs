

namespace Prototype
{
    public class InnerClass
    {
        public int count { get; set; }
    }

 
    public class LargeObjectDeepCopy:IClonable<LargeObjectDeepCopy>
    {
        public int Count { get; set; }
        public InnerClass InnerClass { get; set; } = new InnerClass();

        //Deep Copy
        public LargeObjectDeepCopy Clone()
        {
            return (LargeObjectDeepCopy)MemberwiseClone();
        }

    }
}
