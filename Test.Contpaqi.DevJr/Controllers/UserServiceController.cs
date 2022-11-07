using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Contpaqi.DevJr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserServiceController : ControllerBase
    {
        private readonly ILogger<UserServiceController> _logger;
        private readonly IGetUsersCommand _getUsersCommand;

        public UserServiceController(ILogger<UserServiceController> logger,
            IGetUsersCommand getUsersCommand)
        {
            _logger = logger;
            _getUsersCommand = getUsersCommand;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_getUsersCommand.Get());
        }

        [HttpGet]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(_getUsersCommand.FindById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetByDepartament(string departament)
        {
            throw new NotImplementedException();
        }
    }
}
