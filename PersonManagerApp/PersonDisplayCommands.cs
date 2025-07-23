using DavidTielke.PMA.Logic.PersonManagement.Contract;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonDisplayCommands : IPersonDisplayCommands
{
    private readonly IPersonManager _personManager;

    public PersonDisplayCommands(IPersonManager personManager)
    {
        _personManager = personManager;
    }

    public void DisplayAllAdults()
    {
        var adults = _personManager.GetAllAdults();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(p => Console.WriteLine($"{p.Id}: {p.Name}, {p.Age}"));
    }

    public void DisplayAllChildren()
    {
        var children = _personManager.GetAllChildren();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(p => Console.WriteLine($"{p.Id}: {p.Name}, {p.Age}"));
    }
}