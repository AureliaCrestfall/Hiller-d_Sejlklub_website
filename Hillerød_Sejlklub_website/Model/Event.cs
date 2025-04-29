namespace Hillerød_Sejlklub_website.Model
{
    public class Event
    {
        string _name;
        string _picture;
        DateTime _startTime;
        DateTime _endTime;
        string _location;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }
        public DateTime StartTime 
        { 
            get { return _startTime; }
            set { _startTime = value; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
