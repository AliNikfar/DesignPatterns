using Prototype;



//using shallow Copy:
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