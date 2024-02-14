namespace Proxy
{
    public class CachePersonRepository : IPersonRepository
    {
        private readonly IPersonRepository repository;

        public CachePersonRepository(IPersonRepository repository)
        {
            this.repository = repository;
        }

        public void Add(Person person)
        {
            repository.Add(person);
        }

        public List<Person> GetAll()
        {
            //check if exists in  Cache
            if (1==1)
            {
                var result = repository.GetAll();
                //Add Result to Cache
            }
            var cacheResult = new List<Person>();  //Read from Cache
            return cacheResult;
        }

        public Person GetById(int id)
        {
            if (1 == 1)
            {
                var result = repository.GetAll();
                //Add Result to Cache
            }
            var cacheResult = new Person();  //Read from Cache
            return cacheResult;
        }
    }
}
