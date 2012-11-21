using System.Collections.Generic;

namespace Osis.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Shoot> Shoots { get; set; }
        public IList<Location> Locations { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Fee Fee { get; set; }
    }

    public class Fee
    {
        public int Id { get; set; }
    }
}