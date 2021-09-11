using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Domain.SeedWork
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
