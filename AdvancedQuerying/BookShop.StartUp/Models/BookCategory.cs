using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Models
{
    internal class BookCategory
    {
        public int BookId { get; set; }

        public int CategoryId { get; set; }

        public Book Book { get; set; }
        public Category Category { get; set; }
    }
}
