using MediatR;

namespace JWTProject.Application.CQRS.Commands.WeatherCommands
{
    public class UpdateWeatherCommand : IRequest
    {
        public int Id { get; set; }
        public string city { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
    }
}
