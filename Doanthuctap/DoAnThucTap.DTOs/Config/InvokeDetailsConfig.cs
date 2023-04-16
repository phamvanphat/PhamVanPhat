using DoAnThucTap.DTOs.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTOs.Config
{
    public class InvokeDetailsConfig:IEntityTypeConfiguration<InvokeDetails>
    {
        public void Configure(EntityTypeBuilder<InvokeDetails> builder)
        {

            builder.HasOne(m => m.invoke)
                .WithMany(m => m.invokeDetails)
                .HasForeignKey(m => m.IdInvoke);
        }
    }

}
