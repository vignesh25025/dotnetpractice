﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentLibraryService : ILibraryService
    {
        public int GetMaxBooks()
        {
            return 10;
        }
    }
}
