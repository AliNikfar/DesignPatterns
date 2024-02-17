//Short Description About Observer:  when we have a Object that Other Objects Depend to it ! 
// whenever this Object has changed Other Objects have to know.







public class Department : IObserver
{
    public int DeptId { get; set; }
    public void Update()
    {
        Console.WriteLine($"{DeptId} Is Sad");
    }
}
