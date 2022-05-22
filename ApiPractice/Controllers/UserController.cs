using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiPractice.Models;

namespace ApiPractice.Controllers
{


    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private IUsers users;
        
        public UserController(IUsers users)
        {
            this.users = users;
        }
      
        // GET: UserController
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {

            var lista = users.GetUsers();
            return lista;
        }

        // GET: UserController/Details/5
        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = users.GetUser(id);
            if (user != null) return user;

            return NotFound();
        }



        // POST: UserController/Create
        [HttpPost]

        public ActionResult<User> AddUser(User user)
        {
            User useradd = new() { Id = user.Id, Age = user.Age, Name = user.Name };
            users.AddUser(useradd);

            return Created(useradd.Id.ToString(),useradd);

        }

        [HttpPut("{id}")]


        public ActionResult UserUpdate(int id,User userData)
        {

            var userUpdate=users.GetUser(id);

            if (userUpdate is null)
            {
                return NotFound();
            }

            users.UpdateUser(userData);

            return NoContent();

        }


        [HttpDelete("{id}")]


        public ActionResult DeleteUser(int id)
        {
            var userUpdate = users.GetUser(id);

            if (userUpdate is null)
            {
                return NotFound();
            }
            users.DeleteUser(id);

            return NoContent();
        }

    }
}
