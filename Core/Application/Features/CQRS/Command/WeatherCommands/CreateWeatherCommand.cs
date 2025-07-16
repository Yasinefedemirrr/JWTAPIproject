using MediatR;

namespace JWTProject.Application.CQRS.Commands.WeatherCommands
{
    public class CreateWeatherCommand : IRequest<Unit>
    {
        public string city { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
    }
}
