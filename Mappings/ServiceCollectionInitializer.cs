using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Data.FileStoring.Contract;
using DavidTielke.PMA.Logic.PersonManagement;
using DavidTielke.PMA.Logic.PersonManagement.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace Mappings
{
    public class ServiceCollectionInitializer
    {
        public IServiceCollection Initialize(IServiceCollection services)
        {
            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonParser, PersonParser>();
            services.AddTransient<IFileReader, FileReader>();

            return services;
        }
    }
}
