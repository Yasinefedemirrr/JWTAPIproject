using MediatR;
using JWTProject.Application.CQRS.Commands.WeatherCommands;
using JWTProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace JWTProject.Application.CQRS.Handlers.WeatherHandlers
{
    public class UpdateWeatherCommandHandler : IRequestHandler<UpdateWeatherCommand, Unit>
    {
        private readonly AppDbContext _context;

        public UpdateWeatherCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateWeatherCommand request, CancellationToken cancellationToken)
        {
            var weather = await _context.Weathers.FirstOrDefaultAsync(w => w.Id == request.Id, cancellationToken);

            if (weather == null)
                return Unit.Value;

            weather.city = request.city;
            weather.Date = request.Date;
            weather.Tempature = request.Temperature;

            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
