using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTProject.Application.CQRS.Result.WeatherResults
{
    public class GetWeatherQueryResult
    {
        public int Id { get; set; }
        public string city { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
    }
}
