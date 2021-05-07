using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonServiceDocker.Data;
using PersonServiceDocker.Models;

namespace PersonServiceDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("get/{id}")]
        public Person GetPerson(int id)
        {
            return PersonRepository.GetById(id);
        }
        [HttpGet("remove")]
        public string RemovePerson()
        {
            PersonRepository.Remove();
            return "Last person remove. Total count: "
            + PersonRepository.GetCount();
        }
        [HttpGet("all")]
        public List<Person> GetPersons()
        {
            return PersonRepository.GetAll();
        }
        [HttpPost("person/save")]
        public string AddPerson([FromBody] Person person)
        {
            return PersonRepository.Save(person);
        }
    }
}
