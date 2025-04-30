using Hillerød_Sejlklub_website.Model;

namespace Hillerød_Sejlklub_website.Repository
{
    public interface IBoatRepo
    {
        void Remove(int registrationNumber);
        void Add(Boat boat);
        void AddDefect(string fail);
        List<Boat> GetAll();
        void status(bool status);
    }
}
