namespace ConsoleApp1
{
    public class LibraryManagementService
    {
        ILibraryService libraryService;
        public LibraryManagementService(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }
        public int GetMaxBooks()
        {
            libraryService.count = 10;
            return libraryService.GetMaxBooks();
        }
    }
}
