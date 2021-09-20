using CodeNote.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeNote.Infrastructure.Persistence
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodeNoteContext(serviceProvider.GetRequiredService<DbContextOptions<CodeNoteContext>>()))
            {
                // Look for any board games.
                if (context.Note.Any())
                {
                    return;   // Data was already seeded
                }

                if (context.Type.Any())
                {
                    return;   // Data was already seeded
                }

                context.Note.AddRange(
                    new Note
                    {
                        Id = 1,
                        Title = "CQRS Pat000000000tern",
                        CreatedBy = "Mostafa",
                        CreatedDate = new DateTime(),
                        LastModifiedBy = "Reza",
                        LastModifiedDate = new DateTime(),
                        NoteTypeId = 1,
                        Codes = new List<Code>() {
                             new Code(){ Id=1,Description="cqrs pattern C# implementation",CodeSnippet="cqrs pattern C# implementation code snippet .... "},
                             new Code(){ Id=2,Description="cqrs pattern VB implementation",CodeSnippet="cqrs pattern VB implementation code snippet .... "},
                             new Code(){ Id=3,Description="cqrs pattern Python implementation",CodeSnippet="cqrs pattern Python implementation code snippet .... "}
                        }
                    },
                    new Note
                    {
                        Id = 2,
                        Title = "Create Table Sql server",
                        CreatedBy = "John",
                        CreatedDate = new DateTime(),
                        LastModifiedBy = "Reza",
                        LastModifiedDate = new DateTime(),
                        NoteTypeId = 2,
                        Codes = new List<Code>() {
                            new Code(){ Id=5,Description="Create Table Sql server",CodeSnippet="Create Table Sql server code snippet .... "}
                        }
                    },
                    new Note
                    {
                        Id = 3,
                        Title = "How to create a struct in Golang",
                        CreatedBy = "Irani",
                        CreatedDate = new DateTime(),
                        LastModifiedBy = "Reza",
                        LastModifiedDate = new DateTime(),
                        NoteTypeId = 2,
                        Codes = new List<Code>() {
                            new Code(){ Id=6,Description="How to create a struct in Golang",CodeSnippet="How to create a struct in Golang code snippet .... "}
                        }
                    }
                    );

                context.SaveChanges();
            }

        }
    }
}
