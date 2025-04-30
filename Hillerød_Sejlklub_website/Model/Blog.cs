namespace Hillerød_Sejlklub_website.Model
{
    public class Blog
    {
        string _title;
        string _text;
        string _picturepath;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Picturepath
        {
            get { return _picturepath; }
            set { _picturepath = value; }
        }
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        public Blog()
        {
             _title= "test";
             _text="test";
             _picturepath="test";

        }
        public Blog(string title,string text,string picture):this()
        {
            _title = title;
            _text = text;
            _picturepath = picture;
        }


    }
}
