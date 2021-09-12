using CodeNote.API.SeedWork;
using CodeNote.Application.Features.Note.Queries;
using CodeNote.Domain.Entities;
using CodeNote.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeNote.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : BaseAPIController
    {
        private readonly CodeNoteContext _codeNoteContext;
        public NoteController(IMediator mediator, CodeNoteContext dbContext) : base(mediator)
        {
            _codeNoteContext = dbContext;
        }

        [HttpGet("{userId}", Name = "GetNotes")]
        [ProducesResponseType(typeof(IEnumerable<NotesVm>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<NotesVm>>> GetNotes(long userId)
        {
            var query = new GetNoteListQuery(userId);
            IEnumerable<NotesVm> result = await SendQuery(query);
            return Ok(result);
        }


        [HttpGet( Name = "GetNotesFromDb")]
        [ProducesResponseType(typeof(IEnumerable<Note>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Note>>> GetNotesFromDb()
        {
            List<Domain.Entities.Note> data = await _codeNoteContext.Note.ToListAsync();
            return Ok(data);
        }

    }
}
