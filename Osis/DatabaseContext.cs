using System.Data.Entity;
using Osis.Domain.Security;
using Osis.Models;

namespace Osis
{
    public class DatabaseContext : DbContext
    {
        public IDbSet<Person> Persons { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Job> Jobs { get; set; }
        public IDbSet<Photo> Photos { get; set; }

        public IDbSet<UserProfile> UserProfiles { get; set; }
    }
}