using CodeNote.Domain.Entities;
using CodeNote.Domain.SeedWork;
using CodeNote.Infrastructure.SchemaDefinitions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeNote.Infrastructure.Persistence
{
    public class CodeNoteContext : DbContext, IUnitOfWork
    {
        public DbSet<Note> Note { get; set; }
        public DbSet<NoteType> Type { get; set; }
        public DbSet<Code> Code { get; set; }

        public CodeNoteContext(DbContextOptions<CodeNoteContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CodeEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new NoteEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new NoteTypeEntitySchemaConfiguration());

            //modelBuilder.Entity<Note>()
            //    .HasKey(b => b.Id)
            //    .HasName("PrimaryKey_CodeId");

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await base.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
