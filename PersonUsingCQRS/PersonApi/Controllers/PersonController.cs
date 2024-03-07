using MediatR;
using Microsoft.AspNetCore.Mvc;
using PersonUsingCQRS.Application.Commands;
using PersonUsingCQRS.Application.Queries;
using PersonUsingCQRS.Models;
using System.ComponentModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonUsingCQRS.Controllers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        [Route("getpeople")]
        public async Task<IActionResult> GetPeople()
        {
            var list = await mediator.Send(new GetAllPeopleQuery());
            return Ok(list);
        }

        // GET api/<PersonController>/5
        [HttpGet]
        [Route("getperson")]
        public async Task<IActionResult> GetPersonById(Guid id)
        {
            var model = await mediator.Send(new GetPersonByIdQuery(id));
            return Ok(model);
        }

        // POST api/<PersonController>
        [HttpPost]
        [Route("addperson")]
        public async Task<IActionResult> AddPerson([FromBody] PersonModel value)
        {
            var model = await mediator.Send(new AddPersonCommand(
                value.Id,
                value.GivenName,
                value.Surname,
                value.Gender,
                value.BirthDate,
                value.BirthLocation,
                value.DeathDate,
                value.DeathLocation));
            return Ok(model);
        }

        // POST api/<PersonController>
        [HttpPost]
        [Route("recordbirth")]
        public async Task<IActionResult> RecordBirth(Guid id, DateTime birthDate, string birthLocation = "")
        {
            var model = await mediator.Send(new RecordBirthCommand(id, birthDate, birthLocation));
            return Ok(model);
        }
    }
}
