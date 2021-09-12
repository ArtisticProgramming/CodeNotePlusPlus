using CodeNote.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeNote.Domain.Entities
{
    public class Code :EntityBase
    {
        public string Description { get; set; }
        public string CodeSnippet { get; set; }
        public string ProgrammingLanguages { get; set; }
        public Note Note { get; set; }
        public long NoteId { get; set; }
    }
}
