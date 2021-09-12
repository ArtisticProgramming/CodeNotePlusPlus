using CodeNote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeNote.Application.Contracts.Persistence
{
    public interface INoteRepository : IAsyncRepository<Note>
    {
        Task<IEnumerable<Note>> GetNoteByUserId(long userId);

    }
}
