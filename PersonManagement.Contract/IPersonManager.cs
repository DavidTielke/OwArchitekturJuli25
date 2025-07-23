using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Logic.PersonManagement.Contract;

public interface IPersonManager
{
    List<Person> GetAllAdults();
    List<Person> GetAllChildren();
}