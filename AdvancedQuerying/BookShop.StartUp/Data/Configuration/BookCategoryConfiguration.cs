using BookShop.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data.Configuration
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        void IEntityTypeConfiguration<BookCategory>.Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.ToTable("BookCategories")
                .HasKey(bc => new { bc.CategoryId, bc.BookId });
        }
    }
}