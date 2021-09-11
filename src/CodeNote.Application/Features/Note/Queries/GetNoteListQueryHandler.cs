using AutoMapper;
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
    public class GetNoteListQueryHandler : IRequestHandler<GetNoteListQuery, IEnumerable<NotesVm>>
    {
        private readonly IMapper _mapper;
        private readonly IFakeInMemoryDataBase _iFakeInMemoryDataBase;
        public GetNoteListQueryHandler(IMapper mapper, IFakeInMemoryDataBase iFakeInMemoryDataBase)
        {
            _mapper = mapper;
            _iFakeInMemoryDataBase = iFakeInMemoryDataBase;
        }
        public async Task<IEnumerable<NotesVm>> Handle(GetNoteListQuery request, CancellationToken cancellationToken)
        {
            var notelist = await Task.Run(() => _iFakeInMemoryDataBase.GetAllNote());
            var result = notelist.Select(x => _mapper.Map<NotesVm>(x)).ToList();
            return result;
        }
    }
}
