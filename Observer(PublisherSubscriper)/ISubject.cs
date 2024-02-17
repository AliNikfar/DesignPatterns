//Short Description About Observer:  when we have a Object that Other Objects Depend to it ! 
// whenever this Object has changed Other Objects have to know.






public interface ISubject
{
    List<IObserver> List { get; set; }
    void Register(IObserver observer);
    void Remove(IObserver observer);
}
