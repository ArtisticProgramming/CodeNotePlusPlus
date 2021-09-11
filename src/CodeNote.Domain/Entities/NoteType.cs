using CodeNote.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Domain.Entities
{
    public class NoteType : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
