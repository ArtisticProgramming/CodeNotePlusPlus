using CodeNote.Application.Contracts.Persistence;
using CodeNote.Domain.Entities;
using CodeNote.Domain.SeedWork;
using CodeNote.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeNote.Infrastructure.Repositories
{
    public class NoteRepository : RepositoryBase<Note>, INoteRepository
    {
        public NoteRepository(CodeNoteContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Note>> GetNoteByUserId(long userId)
        {
            var notes = await _dbContext.Note.ToListAsync();
            return notes;
        }
    }
}
