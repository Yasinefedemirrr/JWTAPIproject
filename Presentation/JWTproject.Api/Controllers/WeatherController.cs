using MediatR;
using Microsoft.AspNetCore.Mvc;
using JWTProject.Application.CQRS.Commands.WeatherCommands;
using JWTProject.Application.CQRS.Queries.WeatherQuery;
using JWTProject.Application.CQRS.Result.WeatherResults;

namespace JWTProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Weather
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllWeatherQuery());
            return Ok(result);
        }

        // GET: api/Weather/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetWeatherByIdQuery(id));
            return Ok(result);
        }

        // POST: api/Weather
        [HttpPost]
        public async Task<IActionResult> Create(CreateWeatherCommand command)
        {
            await _mediator.Send(command);
            return Ok("Weather created successfully.");
        }

        // PUT: api/Weather
        [HttpPut]
        public async Task<IActionResult> Update(UpdateWeatherCommand command)
        {
            await _mediator.Send(command);
            return Ok("Weather updated successfully.");
        }

        // DELETE: api/Weather/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveWeatherCommand(id));
            return Ok("Weather deleted successfully.");
        }
    }
}
