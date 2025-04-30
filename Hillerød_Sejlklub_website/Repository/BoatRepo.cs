using System.Security.Cryptography.Xml;
using Hillerød_Sejlklub_website.Model;
using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace Hillerød_Sejlklub_website.Repository
{
    public class BoatRepo:IBoatRepo
    {
        List<Boat> _boats;
        List<string> _defect;
        protected List<Boat> Boats
        {
            get { return _boats; }
            set { _boats = value; }
        }

        protected List<string> Defect
        {
            get { return _defect; }
            set { _defect = value; }
        }
        public void Remove(int registrationNumber)
        {
            Boats.RemoveAt(registrationNumber);
        }
        public void Add(Boat boat)
        {
            Boats.Add(boat);
        }
         public void AddDefect(string fail)
        {
           Defect.Add(fail);
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
