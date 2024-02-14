namespace Proxy
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        void Add(Person person);
        Person GetById(int id);
    }
}
