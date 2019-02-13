using LwsAuthUI.Models;
using System.Web.Http;

namespace LwsAuthUI.Controllers.Api
{
    public class OfficeOnlyController : ApiController
    {
        [Authorize(Roles = "Office")]
        public Person GetPerson()
        {
            Person person = new Person
            {
                Name = "Office",
                Age = 34
            };

            return person;
        }
    }
}