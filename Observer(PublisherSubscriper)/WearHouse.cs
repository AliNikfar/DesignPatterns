//Short Description About Observer:  when we have a Object that Other Objects Depend to it ! 
// whenever this Object has changed Other Objects have to know.







public class WearHouse : ISubject
{
    public List<IObserver> List { get; set; } = new List<IObserver> ();
    private int _product;

    public int Product
    {
        get { return _product; }
        set {
            _product = value;
            foreach (var item in List)
            {
                item.Update ();
            }
                
           }
    }
    public void Register(IObserver observer)
    {
        List.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        List.Remove(observer);
    }
}
