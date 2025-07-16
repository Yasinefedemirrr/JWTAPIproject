using MediatR;
using JWTProject.Application.CQRS.Queries.WeatherQuery;
using JWTProject.Application.CQRS.Result.WeatherResults;
using JWTProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace JWTProject.Application.CQRS.Handlers.WeatherHandlers
{
    public class GetAllWeatherQueryHandler : IRequestHandler<GetAllWeatherQuery, List<GetWeatherQueryResult>>
    {
        private readonly AppDbContext _context;

        public GetAllWeatherQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetWeatherQueryResult>> Handle(GetAllWeatherQuery request, CancellationToken cancellationToken)
        {
            return await _context.Weathers
                .Select(w => new GetWeatherQueryResult
                {
                    Id = w.Id,
                    city = w.city,
                    Date = w.Date,
                    Temperature =w.Tempature,
                })
                .ToListAsync();
        }
    }
}
