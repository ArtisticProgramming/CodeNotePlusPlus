using CodeNote.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeNote.Domain.Entities
{
    public class Note : EntityBase
    {
        public string Title { get; set; }
        public long NoteTypeId { get; set; }

        public NoteType NoteType { get; set; }
        public ICollection<Code> Codes { get; set; }
    }
}
