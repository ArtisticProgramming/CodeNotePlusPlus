﻿using CodeNote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Domain.SeedWork
{
    public interface IFakeInMemoryDataBase
    {
        List<Note> GetAllNote();
    }
}