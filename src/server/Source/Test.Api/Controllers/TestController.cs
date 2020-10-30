namespace Test.Api.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Test.Services;

    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IPersonDataStore _personDataStore;
        public TestController(IPersonDataStore personDataStore) => _personDataStore = personDataStore;
        public List<Person> Get() => _personDataStore.GetData();
    }

  
}