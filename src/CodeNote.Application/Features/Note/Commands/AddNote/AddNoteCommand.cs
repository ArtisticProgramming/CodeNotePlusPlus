using System;
using MediatR;

namespace CodeNote.Application.Features.Note.Commands.AddNote
{
    public class AddNoteCommand : IRequest
    {
        public AddNoteCommand()
        {
        }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
