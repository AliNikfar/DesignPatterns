
//Short Description about ProtoType : 

// When we have a Large Scale Method And it Takes so Much Energy and resources to create a new instance
// like so much parameters to fill! we can make a new instance and keep it on a place like caches or any type of Db
// then whenever we need to make another new instance we can copy the First instance that we kept.
public class LargeObjectShallowCopy //: ICloneable
{

    //Shallow Copy
    public LargeObjectShallowCopy Clone()
    {
        return (LargeObjectShallowCopy)MemberwiseClone();
    }

}
