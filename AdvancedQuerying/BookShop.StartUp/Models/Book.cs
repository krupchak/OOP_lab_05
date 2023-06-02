using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Models
{
    internal class Book
    {
        public int BookId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Copies { get; set; }
        public decimal Price { get; set; }
        public enum editType
        {
            Normal,
            Promo,
            Gold
        }
        public editType EditionType { get; set; }
        public enum ageRestriction
        {
            Minor,
            Teen,
            Adult
        }
        public ageRestriction AgeRestriction { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
