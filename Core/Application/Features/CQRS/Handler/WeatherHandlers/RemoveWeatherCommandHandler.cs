using MediatR;
using JWTProject.Application.CQRS.Commands.WeatherCommands;
using JWTProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace JWTProject.Application.CQRS.Handlers.WeatherHandlers
{
    public class RemoveWeatherCommandHandler : IRequestHandler<RemoveWeatherCommand, Unit>
    {
        private readonly AppDbContext _context;

        public RemoveWeatherCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveWeatherCommand request, CancellationToken cancellationToken)
        {
            var weather = await _context.Weathers.FirstOrDefaultAsync(w => w.Id == request.Id, cancellationToken);

            if (weather == null)
                return Unit.Value;

            _context.Weathers.Remove(weather);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
