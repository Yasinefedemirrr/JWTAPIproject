using MediatR;

namespace JWTProject.Application.CQRS.Commands.WeatherCommands
{
    public class CreateWeatherCommand : IRequest
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
    }
}
