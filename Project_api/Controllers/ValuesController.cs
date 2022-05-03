using Project_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project_api.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public UserCreateReturn Post([FromBody] UserCreate newUser)
        {
            User user = new User() { userId = Guid.NewGuid(), userName = newUser.name, userEmail = newUser.email };

            using (var db = new DBLinqToSqlDataContext())
            {
                if (db.Users.Any(u => u.userEmail == user.userEmail))
                {
                    return new UserCreateReturn { state = false, playerId = db.Users.Single(u=>u.userEmail==user.userEmail).userId, message = "This email address is already being used" };
                }
                else
                {
                    db.Users.InsertOnSubmit(user);
                    db.SubmitChanges();
                    return new UserCreateReturn { state = true, playerId = user.userId, message = "User successfully created" };
                }
            }
        }

        ////PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
