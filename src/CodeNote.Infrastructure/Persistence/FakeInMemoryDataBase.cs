using CodeNote.Domain.Entities;
using CodeNote.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Infrastructure.Persistence
{
    public class FakeInMemoryDataBase : IFakeInMemoryDataBase
    {
        public List<Note> GetAllNote()
        {
            return new List<Note>()
            {
                new Note(){Id=1,CreatedBy="",Title="CQRS Pattern",Type=new NoteType(){ Id=1,Name="Pattern"},NoteTypeId=1 },
                new Note(){Id=2,CreatedBy="",Title="CQRS Bug",Type=new NoteType(){ Id=2,Name="bug"},NoteTypeId=1 },
                new Note(){Id=3,CreatedBy="",Title="CQRS Note",Type=new NoteType(){ Id=3,Name="Note"},NoteTypeId=1 }
            };
        }
    }
}
