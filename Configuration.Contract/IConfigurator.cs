namespace DavidTielke.PMA.CrossCutting.Configuration.Contract
{

    // Pro
    // + Gut lesbar
    // + Stark typisiert
    // Negativ
    // - Alle Configwerte der gesamten Domäne
    public interface IConfigurator1
    {
        string GetPath();
        int GetAgeLimit();
    }

    public interface IConfigurator2
    {

    }
    public interface IConfigurator3
    {

    }
}
