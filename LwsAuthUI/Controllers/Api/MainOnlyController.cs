using LwsAuthUI.Models;
using System.Web.Http;

namespace LwsAuthUI.Controllers.Api
{
    public class MainOnlyController : ApiController
    {
        [Authorize(Roles = "Main")]
        public Person GetPerson()
        {
            Person person = new Person
            {
                Name = "Main",
                Age = 34
            };

            return person;
        }
    }
}