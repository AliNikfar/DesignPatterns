

//Short Description about ProtoType : 

// When we have a Large Scale Method And it Takes so Much Energy and resources to create a new instance
// like so much parameters to fill! we can make a new instance and keep it on a place like caches or any type of Db
// then whenever we need to make another new instance we can copy the First instance that we kept.

//using shallow Copy:

using Prototype;

LargeObjectShallowCopy largeObject = new LargeObjectShallowCopy();


var newInstance = largeObject.Clone();
var newInstance1 = largeObject.Clone();
var newInstance2 = largeObject.Clone();
var newInstance3 = largeObject.Clone();

//using DeepCopy

LargeObjectDeepCopy largeObject1 = new LargeObjectDeepCopy();
 
var newInstance5 = largeObject1.Clone();
var newInstance6 = largeObject1.Clone();
var newInstance7 = largeObject1.Clone();
var newInstance8 = largeObject1.Clone();

Console.WriteLine("Hello, World!");