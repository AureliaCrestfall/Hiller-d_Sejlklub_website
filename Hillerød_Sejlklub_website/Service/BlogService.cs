using Hillerød_Sejlklub_website.Model;
using Hillerød_Sejlklub_website.Repository;
namespace Hillerød_Sejlklub_website.Service
{
    public class BlogService
    {
        IBlogRepo _blogRepo;

        public void Add(Blog blog)
        {

            _blogRepo.Add(blog);
        }
        public void Remove(int title)
        {
            _blogRepo.Remove(title);
        }
        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll();

        }


        public void Update(Event updatedBlog)
        {

        }

    }
}
