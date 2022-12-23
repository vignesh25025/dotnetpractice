using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentLibraryService : ILibraryService
    {
        private int booksCount;
        public int count { get => booksCount; set => booksCount = value; }

        public int GetMaxBooks()
        {
            return 10;
        }
    }
}
