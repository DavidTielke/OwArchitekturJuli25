using DavidTielke.PMA.CrossCutting.Configuration.Contract;
using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;
using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            new ServiceCollectionInitializer().Initialize(services);
            services.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();

            var provider = services.BuildServiceProvider();

            var config = provider.GetRequiredService<IConfigurator>();
            config.Set("PersonManagement", "AgeThreshold", 10);
            config.Set("DataStoring", "CsvPath", "data.csv");

            var displayCommands = provider.GetRequiredService<IPersonDisplayCommands>();

            displayCommands.DisplayAllAdults();
            displayCommands.DisplayAllChildren();
        }
    }
}
