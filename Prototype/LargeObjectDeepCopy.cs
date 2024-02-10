

namespace Prototype
{
    public class LargeObjectDeepCopy
    {
        public int Count { get; set; }

        //Deep Copy
        public LargeObjectDeepCopy Clone()
        {
            return (LargeObjectDeepCopy)MemberwiseClone();
        }

    }
}
