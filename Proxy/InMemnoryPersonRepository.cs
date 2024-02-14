namespace Proxy
{
    public class InMemnoryPersonRepository : IPersonRepository
    {
        private readonly List<Person> list = new List<Person>
        {
            new Person { PersonID = 1,FirstName =" First ",LastName ="Person1"},
            new Person { PersonID = 1,FirstName =" Second ",LastName ="Person2"}
        }; 

        public void Add(Person person)
        {
            person.PersonID = list.Count + 1;
            list.Add(person);
        }

        public List<Person> GetAll()
        {
            return list;
        }

        public Person GetById(int id)
        {
            return list.FirstOrDefault(x => x.PersonID == id);  
        }
    }
}
