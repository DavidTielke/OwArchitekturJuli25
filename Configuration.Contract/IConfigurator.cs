namespace DavidTielke.PMA.CrossCutting.Configuration.Contract
{
    public interface IConfigurator
    {
        TItem Get<TItem>(string category, string key);
        void Set(string category, string key, object value);
    }
}
