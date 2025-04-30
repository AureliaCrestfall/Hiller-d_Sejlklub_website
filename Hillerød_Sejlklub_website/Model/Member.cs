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

        public Member()
        {
            _name = "test";
            _phoneNumber = "88 88 88 88";
            _emailAddress = "test@test.test";
            _picture = "test.png";
            _boardMember = false;



        }
        public Member(string name, string picture, string phoneNumber,string email):this()
        {

            _name = name;
            _phoneNumber = phoneNumber;
            _emailAddress = email;
            _picture = picture;

        }
        public Member(string name, string picture, string phoneNumber, string email, bool boardmember) : this( name,  picture,  phoneNumber,  email)
        {
      
            _boardMember = boardmember;
        }




    }

}
