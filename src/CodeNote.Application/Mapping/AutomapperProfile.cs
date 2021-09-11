using AutoMapper;
using CodeNote.Application.Features.Note.Queries;
using CodeNote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Application.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Note, NotesVm>().ReverseMap();
        }
    }
}
