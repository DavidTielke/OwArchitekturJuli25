using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contract;
using DavidTielke.PMA.Logic.PersonManagement.Contract;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _repository;

    public PersonManager(IPersonRepository repository)
    {
        _repository = repository;
    }

    public List<Person> GetAllAdults()
    {
        return _repository.Load().Where(p => p.Age >= 18).ToList();
    }

    public List<Person> GetAllChildren()
    {
        return _repository.Load().Where(p => p.Age < 18).ToList();
    }
}