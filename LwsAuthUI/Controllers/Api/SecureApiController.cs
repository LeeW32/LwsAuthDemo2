﻿using LwsAuthUI.Models;
using System.Web.Http;

namespace LwsAuthUI.Controllers.Api
{
    [Authorize]
    public class SecureApiController : ApiController
    {
        public Person GetPerson()
        {
            Person person = new Person
            {
                Name = "Dilbert",
                Age = 34
            };

            return person;
        }
    }
}