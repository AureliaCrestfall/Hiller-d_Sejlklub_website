using Hillerød_Sejlklub_website.Model;

namespace Hillerød_Sejlklub_website.Repository
{
    public class EventRepo :IEventRepo
    {
        List<Event> _events;

        //private List<Event> Events
        //{
        //    get { return _events; }
        //     set {  _events = value; }
        //} 
        public EventRepo()
        {
            _events = new List<Event>();

        }
        public List<Event> GetAll()
        {
            return _events;
        }
        public void Add(Event test)
        {
            _events.Add(test);
        }
        public void Remove(int name)
        {
            _events.RemoveAt(name);
        }
        


    }
}
