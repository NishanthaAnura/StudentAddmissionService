using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAddmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAddmissionController : ControllerBase
    {
        // GET: api/<StudentAddmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel addmissionObj1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel addmissionObj2 = new StudentAdmissionDetailsModel();

            addmissionObj1.StudentID = 1;
            addmissionObj1.StudentName = "Anura";
            addmissionObj1.StudentClass = "X";
            addmissionObj1.DateofJoining = DateTime.Now;

            addmissionObj2.StudentID = 2;
            addmissionObj2.StudentName = "Nishantha";
            addmissionObj2.StudentClass = "XI";
            addmissionObj2.DateofJoining = DateTime.Now;

            List<StudentAdmissionDetailsModel> listOfObj = new List<StudentAdmissionDetailsModel>
            {
                addmissionObj1,
                addmissionObj2
            };
            return listOfObj;
        }

        // GET api/<StudentAddmissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAddmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAddmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAddmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
