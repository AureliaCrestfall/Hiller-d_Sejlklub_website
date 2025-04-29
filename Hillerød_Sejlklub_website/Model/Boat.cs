namespace Hillerød_Sejlklub_website.Model
{
    public class Boat
    {
        string _name;
        string _registrationNumber;
        string _text;
        string _picture;
        bool _avaliability;
        List<string> _defect;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }
        public bool Avaliability
        {
            get { return _avaliability; }
            set { _avaliability = value; }
        }
        public List<string> Defect
        {
            get { return _defect; }
            set { _defect = value; }
        }
    }
}
