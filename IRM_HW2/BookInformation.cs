using System;
using System.Collections.Generic;
using System.Text;

namespace IRM_HW2
{
    class BookInformation
    {
        public int bookID { get; set; }

        public string bookPath { get; set; }

        public BookInformation(int _bookID, string _bookPath) 
        {
            this.bookID = _bookID;
            this.bookPath = _bookPath;
        }
    }
}
