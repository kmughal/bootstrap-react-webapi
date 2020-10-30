
namespace Test.Services
{
    using System.Collections.Generic;
    public class PersonDataStore : IPersonDataStore
    {
        public List<Person> GetData() => new List<Person> { new Person("khurram", "shahzad") };
    }


    public interface IPersonDataStore
    {
        List<Person> GetData();
    }


    public record Person(string Firstname, string Lastname);
}
