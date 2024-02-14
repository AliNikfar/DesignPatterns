// short Description about Proxy : 
// When We want to change , use or extend an object whitout change the Orginal Object
// or any type of using a Object Without  direct Access , controlled Access  to the Orginal Object.

using Proxy;
bool cacheSetting  = false;

IPersonRepository personRepository = cacheSetting? new  CachePersonRepository(new InMemnoryPersonRepository()) : new InMemnoryPersonRepository();
var searchResult = personRepository.GetAll();
foreach (var person in searchResult)
{
    Console.WriteLine($"{person.PersonID} {person.FirstName}  {person.LastName}");
}

