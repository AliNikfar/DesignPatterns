//Short Descpription about FlyWeight:
// when we have a object and it has some static objects and also
// dynamic objects , we can make a instance of static objects for statics and 
// then implement new of our object for dynamics and save the Sources For creating instantioation 

using FlyWeight;

var a1 = AlphabetFactory.GetAlpha("A");
var a2 = AlphabetFactory.GetAlpha("A");
var b1 = AlphabetFactory.GetAlpha("B");

a1.Print(1, 2, "Red");
a1.Print(2, 2, "Blue");
b1.Print(3, 2, "Yellow");

Console.ReadLine();

