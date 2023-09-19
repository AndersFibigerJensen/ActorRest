using ClassLibrary1;
using ClassLibrary2;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ActorRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private ITeachersRepository _Teacherrepository;

        public TeachersController(ITeachersRepository teachersRepository)
        {
            _Teacherrepository = teachersRepository;
        }


        // GET: api/<TeachersController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _Teacherrepository.Get();
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public Teacher? GetById(int id)
        {
            return _Teacherrepository.GetByID(id);
        }

        // POST api/<TeachersController>
        [HttpPost]
        public Teacher Post([FromBody] Teacher NewTeacher)
        {
            return _Teacherrepository.AddTeacher(NewTeacher);
        }

        // PUT api/<TeachersController>/5
        [HttpPut("{id}")]
        public Teacher Put(int id, [FromBody] Teacher teach)
        {
            return _Teacherrepository.EditTeacher(id, teach);

        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public Teacher Delete(int id)
        {
            return _Teacherrepository.DeleteTeacher(id);
        }
    }
}
