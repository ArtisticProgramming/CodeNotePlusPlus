using CodeNote.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Infrastructure.SchemaDefinitions
{
    public class NoteEntitySchemaConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {

            builder.ToTable("CodeNote");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(e => e.Type)
            .WithMany(c => c.Notes)
            .HasForeignKey(x => x.NoteTypeId)
            .Metadata.DeleteBehavior = DeleteBehavior.Restrict;


            //builder.HasOne(e => e.Project)
            //.WithMany(c => c.CodeNotes)
            //.HasForeignKey(x => x.ProjectId)
            //.Metadata.DeleteBehavior = DeleteBehavior.Restrict;


            //builder.Property(x => x.ProjectId).IsRequired();
            //builder.Property(x => x.GeneralSubjectId).IsRequired();
            //builder.Property(x => x.UserId).IsRequired();
            //builder.Property(x => x.NoteTypeId).IsRequired();
            //builder.Property(x => x.IsBookMarked).IsRequired();
            //builder.Property(x => x.SpecificSubjectId);


            //builder.HasOne(e => e.Type)
            //.WithOne()
            //.Metadata.DeleteBehavior = DeleteBehavior.Restrict;
            //.HasForeignKey(x => x.NoteTypeId)
            //.Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            //builder.HasOne(e => e.Project)
            //.WithMany(c => c.CodeNotes)
            //.HasForeignKey(x => x.ProjectId)
            //.Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            //builder.HasOne(e => e.GeneralSubject)
            //.WithMany(c => c.CodeNotes)
            //.HasForeignKey(x => x.GeneralSubjectId).Metadata.DeleteBehavior = DeleteBehavior.Restrict;


            //builder.HasOne(e => e.SpecificSubject)
            //.WithMany(c => c.CodeNotes)
            //.HasForeignKey(x => x.SpecificSubjectId).Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            //builder.HasOne(e => e.User)
            //.WithMany(c => c.CodeNotes)
            //.HasForeignKey(x => x.UserId).Metadata.DeleteBehavior = DeleteBehavior.Restrict;

        }
    }
}
