using DoAnThucTap.DTOs.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTOs.Config
{
    public class BookConfig: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.HasOne(m => m.categoryBook)
                .WithMany(m => m.books)
                .HasForeignKey(m => m.IdCategpryBook);
        }
    }
}
