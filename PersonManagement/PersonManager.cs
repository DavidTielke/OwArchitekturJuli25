using DavidTielke.PMA.CrossCutting.Configuration.Contract;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Logic.PersonManagement.Contract;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly int AGE_TRESHOLD;

    private readonly IPersonRepository _repository;

    public PersonManager(IPersonRepository repository, IConfigurator config)
    {
        _repository = repository;
        AGE_TRESHOLD = config.Get<int>("PersonManagement", "AgeThreshold");
    }

    public List<Person> GetAllAdults()
    {
        return _repository.Load().Where(p => p.Age >= AGE_TRESHOLD).ToList();
    }

    public List<Person> GetAllChildren()
    {
        return _repository.Load().Where(p => p.Age < AGE_TRESHOLD).ToList();
    }
}