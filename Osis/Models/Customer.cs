namespace Osis.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public Person CustomerDetails { get; set; }
        public Address Address { get; set; }
    }
}