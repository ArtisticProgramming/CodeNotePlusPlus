using CodeNote.Domain.Entities;
using CodeNote.Domain.SeedWork;
using CodeNote.Infrastructure.SchemaDefinitions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


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