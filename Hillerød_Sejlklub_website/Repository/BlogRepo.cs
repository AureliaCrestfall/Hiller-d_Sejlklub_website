using Hillerød_Sejlklub_website.Model;
using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace Hillerød_Sejlklub_website.Repository
{
    public class BlogRepo:IBlogRepo
    {
        List<Blog> _blogs;
        protected List<Blog> Blogs
        {
            get { return _blogs; }
            set { _blogs = value; }
        }

        public List<Blog> GetAll()
        {
            return Blogs;
        }
        public void Add(Blog blog)
        {
            Blogs.Add(blog);

        }
        public void Remove(string title)
        {

        }
    }
}
