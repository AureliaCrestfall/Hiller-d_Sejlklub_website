using Hillerød_Sejlklub_website.Model;
using Hillerød_Sejlklub_website.Repository;
using Microsoft.Extensions.Logging;

namespace Hillerød_Sejlklub_website.Service
{
    public class EventService
    {
        IEventRepo _eventRepo;

        public void Add(Event vent)
        {

            _eventRepo.Add(vent);
        }
        public void Remove(int name)
        {
            _eventRepo.Remove(name);
        }
        public List<Event> GetAll()
        {
            return _eventRepo.GetAll();

        }
        public void Update(Event updatedEvent)
        {

        }


    }
}
