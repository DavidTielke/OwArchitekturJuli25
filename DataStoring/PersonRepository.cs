using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Data.FileStoring.Contract;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IFileReader _fileReader;
    private readonly IPersonParser _personParser;

    public PersonRepository(IFileReader fileReader, IPersonParser personParser)
    {
        _fileReader = fileReader;
        _personParser = personParser;
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