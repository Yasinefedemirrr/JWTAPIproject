using MediatR;
using JWTProject.Application.CQRS.Queries.WeatherQuery;
using JWTProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using JWTproject.Application.Features.CQRS.Result.WeatherResults;

namespace JWTProject.Application.CQRS.Handlers.WeatherHandlers
{
    public class GetWeatherByIdQueryHandler : IRequestHandler<GetWeatherByIdQuery, GetWeatherByIdQueryResult>
    {
        private readonly AppDbContext _context;

        public GetWeatherByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<GetWeatherByIdQueryResult> Handle(GetWeatherByIdQuery request, CancellationToken cancellationToken)
        {
            var weather = await _context.Weathers
                .FirstOrDefaultAsync(w => w.Id == request.Id, cancellationToken);

            if (weather == null)
                return null;

            return new GetWeatherByIdQueryResult
            {
                Id = weather.Id,
                city = weather.city,
                Date = weather.Date,
                Temperature = weather.Tempature,
            };
        }
    }
}
