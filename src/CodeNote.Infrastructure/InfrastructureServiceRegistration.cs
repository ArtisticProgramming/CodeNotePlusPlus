using CodeNote.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
using CodeNote.Infrastructure.Repositories;
using CodeNote.Application.Contracts.Persistence;


namespace CodeNote.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region DB Creation Config
            //Sql server DB
            //services.AddDbContext<CodeNotContext>(
            //    option => option.UseSqlServer(configuration.GetConnectionString("CodeNoteConnectionString")),);

            //In Memory DB
            services.AddDbContext<CodeNoteContext>(options => options.UseInMemoryDatabase(databaseName: "CodeNoteDb"));
            #endregion


            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<INoteRepository, NoteRepository>();

            return services;
        }
    }
}
