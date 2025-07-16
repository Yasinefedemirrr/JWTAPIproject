using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTproject.Domain.Entities
{
    public class Weather
    {
        public int Id { get; set; }
        public string city { get; set; }
        public DateTime Date { get; set; }
        public int Tempature { get; set; }

    }
}   