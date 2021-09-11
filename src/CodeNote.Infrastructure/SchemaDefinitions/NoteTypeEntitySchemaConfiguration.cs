using CodeNote.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Infrastructure.SchemaDefinitions
{
    class NoteTypeEntitySchemaConfiguration : IEntityTypeConfiguration<NoteType>
    {
        public void Configure(EntityTypeBuilder<NoteType> builder)
        {

            builder.ToTable("NoteType");

            builder.HasKey(x => x.Id);


        }
    }
}