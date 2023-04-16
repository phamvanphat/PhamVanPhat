using DoAnThucTap.DTOs.Entyties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTOs.Config
{
    public class ImageBookConfig : IEntityTypeConfiguration<ImageBook>
    {
        public void Configure(EntityTypeBuilder<ImageBook> builder)
        {

            builder.HasOne(m => m.books)
                .WithMany(m => m.images)
                .HasForeignKey(m => m.IdBook);
        }
    }
}
