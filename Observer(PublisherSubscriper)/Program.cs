//Short Description About Observer:  when we have a Object that Other Objects Depend to it ! 
// whenever this Object has changed Other Objects have to know.

Person person1 = new Person()
{
    FullName = "Ali Nikfar"
};
Person person2 = new Person()
{
    FullName = "Jason Rezaean"
};

Department saleDepartment = new Department()
{ DeptId = 1 };

Department sendDepartment = new Department()
{ DeptId = 2 };


WearHouse Subject = new WearHouse();
Subject.Register(person1);
Subject.Register(person2);
Subject.Register(saleDepartment);
Subject.Register(sendDepartment);

Subject.Product = 2;
Console.WriteLine("-------------------");
Subject.Product = 3;
Console.WriteLine("-------------------");
Subject.Remove(person1);
Subject.Product = 2;
Console.WriteLine("-------------------");
Console.ReadKey();
