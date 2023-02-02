using Microsoft.AspNetCore.Authentication;

namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string code { get; set; }
        
        public double Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        // Navication Poperty
        public IEnumerable<Walk> Walks { get; set; }


    }
}