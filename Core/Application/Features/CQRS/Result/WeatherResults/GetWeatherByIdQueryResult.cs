using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTproject.Application.Features.CQRS.Result.WeatherResults
{
    public class GetWeatherByIdQueryResult
    {
        public int Id { get; set; }
        public string city { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
    }
}


