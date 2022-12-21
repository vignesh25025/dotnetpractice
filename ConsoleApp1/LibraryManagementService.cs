namespace ConsoleApp1
{
    public class LibraryManagementService
    {

        public int GetMaxBooks(ILibraryService libraryService)
        {
            return libraryService.GetMaxBooks();
        }
    }
}
