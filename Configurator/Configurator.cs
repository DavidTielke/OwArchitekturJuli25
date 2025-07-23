using DavidTielke.PMA.CrossCutting.Configuration.Contract;

namespace Configurator
{
    public class Configurator : IConfigurator
    {
        private readonly Dictionary<string, object> _items;

        public Configurator()
        {
            _items= new Dictionary<string, object>();
        }

        public TItem Get<TItem>(string category, string key)
        {
            return (TItem)_items[category + "." + key];
        }

        public void Set(string category, string key, object value)
        {
            _items[category + "." + key] = value;
        }
    }
}
