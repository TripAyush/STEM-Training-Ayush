using System;
using System.Collections.Generic;
using System.Text;

namespace DALLibrary
{
    public class ModelBook
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string AuthorName { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
    }
}
