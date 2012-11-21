namespace Osis.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public Country Country { get; set; }
        public string County { get; set; }
    }
}