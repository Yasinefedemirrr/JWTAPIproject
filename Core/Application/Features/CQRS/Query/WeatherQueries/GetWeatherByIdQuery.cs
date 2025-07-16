using MediatR;
using JWTProject.Application.CQRS.Result.WeatherResults;
using JWTproject.Application.Features.CQRS.Result.WeatherResults;

namespace JWTProject.Application.CQRS.Queries.WeatherQuery
{
    public class GetWeatherByIdQuery : IRequest<GetWeatherByIdQueryResult>
    {
        public int Id { get; set; }

        public GetWeatherByIdQuery(int id)
        {
            Id = id;
        }
    }
}
