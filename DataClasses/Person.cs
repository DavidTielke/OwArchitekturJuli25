namespace DavidTielke.PMA.CrossCutting.DataClasses;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {

    }

    public Person(string name, int age, int id)
    {
        Name = name;
        Age = age;
        Id = id;
    }

    public int Id
    {
        get;
        set;
    }
}