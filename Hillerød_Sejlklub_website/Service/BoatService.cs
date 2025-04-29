using Hillerød_Sejlklub_website.Model;
using Hillerød_Sejlklub_website.Repository;
using System.Security.Cryptography.X509Certificates;
namespace Hillerød_Sejlklub_website.Service
{
    public class BoatService
    {
        IBoatRepo _boatRepo;

        public void Add(Boat boat)
        {

            _boatRepo.Add(boat);
        }
        public void Remove(string name)
        {

        }
        public List<Boat> GetAll()
        {
            return _boatRepo.GetAll();

        }
        public void Status(bool status)
        {

        }
        public void AddDefict(string fail)
        {

        }

        public void Update(Event updatedBoat)
        {

        }
    }
}
