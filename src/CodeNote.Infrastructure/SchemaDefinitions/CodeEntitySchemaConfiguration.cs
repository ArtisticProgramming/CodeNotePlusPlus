using CodeNote.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Infrastructure.SchemaDefinitions
{
    public class CodeEntitySchemaConfiguration : IEntityTypeConfiguration<Code>
    {
        public void Configure(EntityTypeBuilder<Code> builder)
        {
            builder.ToTable("Code");
            builder.HasKey(x => x.Id);

            builder.HasOne(e => e.NoteCode)
            .WithMany(c => c.Codes)
            .HasForeignKey(x => x.NoteId)
            .Metadata.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
