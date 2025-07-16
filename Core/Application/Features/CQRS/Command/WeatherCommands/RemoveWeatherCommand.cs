using MediatR;

namespace JWTProject.Application.CQRS.Commands.WeatherCommands
{
    public class RemoveWeatherCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public RemoveWeatherCommand(int id)
        {
            Id = id;
        }
    }
}
