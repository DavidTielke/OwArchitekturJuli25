using DavidTielke.PMA.CrossCutting.Configuration.Contract;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Data.FileStoring.Contract;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly string CSV_PATH;

    private readonly IFileReader _fileReader;
    private readonly IPersonParser _personParser;
    private readonly IConfigurator _config;

    public PersonRepository(IFileReader fileReader, IPersonParser personParser, IConfigurator config)
    {
        _fileReader = fileReader;
        _personParser = personParser;
        _config = config;

        CSV_PATH = _config.Get<string>("DataStoring", "CsvPath");
    }

    public IQueryable<Person> Load()
    {
        var dataLines = _fileReader.ReadLines("data.csv");
        var persons = dataLines
            .Select(line => _personParser.Parse(line))
            .AsQueryable();

        return persons;
    }
}