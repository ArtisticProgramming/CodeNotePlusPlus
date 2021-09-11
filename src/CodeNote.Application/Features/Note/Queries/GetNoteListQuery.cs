using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Application.Features.Note.Queries
{
    public class GetNoteListQuery : IRequest<IEnumerable<NotesVm>>
    {
        public long UserId { get; set; }
        public GetNoteListQuery(long userId)
        {
            if (userId == 0)
                throw new ArgumentException(nameof(userId));
            UserId = userId;
        }

    }
}
