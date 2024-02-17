//Short Description About Observer:  when we have a Object that Other Objects Depend to it ! 
// whenever this Object has changed Other Objects have to know.







public class Person : IObserver
{
    public string FullName { get; set; }
    public void Update()
    {
        Console.WriteLine($"{FullName} Is HAppy");
    }
}
