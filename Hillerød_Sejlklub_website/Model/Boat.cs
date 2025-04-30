namespace Hillerød_Sejlklub_website.Model
{
    public class Boat
    {
        private static int _tempID = 0;
        string _name;
        string _registrationNumber;
        string _text;
        string _picture;
        bool _avaliability;
        int _id;
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
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Boat()
        {
            _name = "test";
            _registrationNumber = "test";
            _text = "test";
            _picture = "test";
            _avaliability = true;
            _id = _tempID++;
        }
        public Boat(string name,string regnumber,string text,string picture) : this()
        {
            _name = name;
            _registrationNumber = regnumber;
            _text = text;
            _picture = picture;
        }
        public Boat(string name, string regnumber, string text, string picture,bool avaliabilty):this( name,  regnumber,  text, picture)
        {
            _avaliability = avaliabilty;

        }

    }
}
