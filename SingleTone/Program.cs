using SingleTone;

// create a new instance with calling static proprties
//SiteSetting._count = 123;
var instance = SiteSetting.Instance;
instance.SiteName = "Site Name 1";
Console.WriteLine(instance.SiteName.ToString());
var instance2 = SiteSetting.Instance;
Console.WriteLine(instance2.SiteName.ToString());



