using CodeNote.API.SeedWork;
using CodeNote.Application.Features.Note.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IMediator _mediator;
        public NoteController(IMediator mediator) : base(mediator)
        {
            _mediator = _mediator;
        }

        [HttpGet("{userId}", Name = "GetNotes")]
        [ProducesResponseType(typeof(IEnumerable<NotesVm>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<NotesVm>>> GetNotes(long userId)
        {
            var query = new GetNoteListQuery(userId);

            IEnumerable<NotesVm> result = await Send(query);

            return Ok(result);
        }



    }
}
