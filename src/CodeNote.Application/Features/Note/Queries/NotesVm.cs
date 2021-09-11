using CodeNote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Application.Features.Note.Queries
{
    public class NotesVm
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public long NoteTypeId { get; set; }
        public NoteType Type { get; set; }
        public ICollection<Code> Codes { get; set; }
    }
}
