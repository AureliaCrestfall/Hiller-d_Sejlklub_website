using Hillerød_Sejlklub_website.Model;

namespace Hillerød_Sejlklub_website.Repository
{
    public class EventRepo :IEventRepo
    {
        List<Event> _events;
        protected List<Event> Events
        {
            get { return _events; }
             set {  _events = value; }
        } 
        public List<Event> GetAll()
        {
            return Events;
        }
        public void Add(Event test)
        {
             Events.Add(test);
        }
        public void Remove(string name)
        {

        }
        public EventRepo()
        {

        }


    }
}
