using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using efCorePracties.Models;
using efCorePracties.Controllers.Models;

namespace efCorePracties.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly PersonDbContext _persondbContext;
        public StudentController(PersonDbContext personDb)
        {
            _persondbContext = personDb;

        }

        [HttpGet]
        [Route("GetAllListStudent")]
        public IActionResult GetAllListStudent()
        {
            var StudentList = _persondbContext.people.ToList();
            return Ok(StudentList);
        }

        [HttpPost]
        [Route("SaveChange")]
        public IActionResult SaveOrChange(Person person)
        {
            _persondbContext.people.Add(person);
            _persondbContext.SaveChanges();
            return Ok(person.Id);
        }

        [HttpPut]
        [Route("UpdatePerson")]
        public IActionResult UpdatePerson(Person person)
        {
            _persondbContext.people.Update(person);
            _persondbContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        [Route("DeletePerson")]
        public IActionResult DeletePerson(int id)
        {
            var SelectedUser = _persondbContext.people.Where(it => it.Id == id).FirstOrDefault();
            if (SelectedUser == null)
            {
                return NotFound();
            }

            _persondbContext.people.Remove(SelectedUser);
            _persondbContext.SaveChanges();
            return NotFound();
        }



    }
}
