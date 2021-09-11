using CodeNote.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Domain.Entities
{
    public class Code : EntityBase
    {
        public long Description { get; set; }
        public string CodeSnippet { get; set; }
        public string ProgrammingLanguages { get; set; }
        public Note NoteCode { get; set; }
        public long NoteId { get; set; }
    }
}
