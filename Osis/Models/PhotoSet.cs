using System.Collections.Generic;

namespace Osis.Models
{
    public class PhotoSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Photo> Photos { get; set; }
    }
}