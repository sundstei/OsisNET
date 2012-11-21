using System;
using System.Collections.Generic;

namespace Osis.Models
{
    public class Shoot
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<PhotoSet> PhotoSets { get; set; }
    }
}