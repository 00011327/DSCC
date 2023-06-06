namespace LibraryUI.Repository
{
    public class RepositoryBase
    {
        protected BooksContext _context { get; set; }

        public RepositoryBase(BooksContext context)
        {
            _context = context;
        }
    }
}
