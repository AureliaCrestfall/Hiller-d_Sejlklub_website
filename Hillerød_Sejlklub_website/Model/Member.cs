namespace Hillerød_Sejlklub_website.Model
{
    public class Member
    {
        string _name;
        string _picture;
        bool _boardMember;
        string _phoneNumber;
        string _emailAddress;
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
        public bool BoardMember
        {
            get { return _boardMember; }
            set { _boardMember = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
    }

}
