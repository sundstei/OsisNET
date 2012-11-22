namespace Osis.Repositories
{
    public class BaseRepository
    {
        private DatabaseContext _context;

        protected BaseRepository()
        {
            _context = new DatabaseContext();
        }
    }
}