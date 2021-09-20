using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CodeNote.Application.Contracts.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CodeNote.Application.Features.Note.Commands.AddNote
{
    public class AddNoteCommandHandler : IRequestHandler<AddNoteCommand>
    {
        private readonly INoteRepository _noteRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddNoteCommandHandler> _logger;

        public AddNoteCommandHandler(INoteRepository noteRepository,
                                     IMapper mapper,
                                     ILogger<AddNoteCommandHandler> logger)
        {
            _noteRepository = noteRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(AddNoteCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<CodeNote.Domain.Entities.Note>(request);

            await _noteRepository.AddAsync(result);

            return Unit.Value;
        }
    }
}
