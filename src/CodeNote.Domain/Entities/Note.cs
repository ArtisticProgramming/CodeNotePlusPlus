using CodeNote.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Domain.Entities
{
    public class Note : EntityBase, IAggregateRoot
    {
        public string Title { get; set; }
        public long NoteTypeId { get; set; }

        public NoteType Type { get; set; }
        public ICollection<Code> Codes { get; set; }
    }
}
