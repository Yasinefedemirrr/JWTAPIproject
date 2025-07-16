using MediatR;
using JWTProject.Application.CQRS.Commands.WeatherCommands;
using JWTProject.Persistance.Context;
using JWTproject.Domain.Entities;

namespace JWTProject.Application.CQRS.Handlers.WeatherHandlers
{
    public class CreateWeatherCommandHandler : IRequestHandler<CreateWeatherCommand, Unit>
    {
        private readonly AppDbContext _context;

        public CreateWeatherCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateWeatherCommand request, CancellationToken cancellationToken)
        {
            var weather = new Weather
            {
                city = request.city,
                Date = request.Date,
                Tempature = request.Temperature,
            };

            await _context.Weathers.AddAsync(weather, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
