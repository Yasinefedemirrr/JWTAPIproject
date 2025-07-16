using MediatR;
using JWTProject.Application.CQRS.Result.WeatherResults;

namespace JWTProject.Application.CQRS.Queries.WeatherQuery
{
    public class GetAllWeatherQuery : IRequest<List<GetWeatherQueryResult>>
    {
    }
}