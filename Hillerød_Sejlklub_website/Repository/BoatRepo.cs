using Hillerød_Sejlklub_website.Model;
using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace Hillerød_Sejlklub_website.Repository
{
    public class BoatRepo:IBoatRepo
    {
        List<Boat> _boats;
        protected List<Boat> Boats
        {
            get { return _boats; }
            set { _boats = value; }
        }
        public void Remove(string registrationNumber)
        {

        }
        public void Add(Boat boat)
        {
            Boats.Add(boat);
        }
         public void AddDefict(string fail)
        {

        }
        public List<Boat> GetAll()
        {
            return Boats;
        }
        public void status(bool status)
        {

        }

    }
}
