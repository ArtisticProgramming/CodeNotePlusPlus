using AutoMapper;
using CodeNote.Application.Contracts.Persistence;
using CodeNote.Domain.SeedWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeNote.Application.Features.Note.Queries
{
    public class GetNoteListQueryHandler : IRequestHandler<GetNoteListQuery, IEnumerable<NotesVm>>, IQuery
    {
        private readonly IMapper _mapper;
        private readonly INoteRepository _noteRepository;
        public GetNoteListQueryHandler(IMapper mapper, INoteRepository noteRepository)
        {
            _mapper = mapper;
            _noteRepository = noteRepository;
        }
        public async Task<IEnumerable<NotesVm>> Handle(GetNoteListQuery request, CancellationToken cancellationToken)
        {
            var notelist = await _noteRepository.GetAllAsync();
            var result = notelist.Select(x => _mapper.Map<NotesVm>(x)).ToList();
            return result;
        }
    }
}
