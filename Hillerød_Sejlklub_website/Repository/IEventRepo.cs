using Hillerød_Sejlklub_website.Model;

namespace Hillerød_Sejlklub_website.Repository
{
    public interface IEventRepo
    {
        List<Event> GetAll();
        void Add(Event test);
        void Remove(string name);
    }
}
