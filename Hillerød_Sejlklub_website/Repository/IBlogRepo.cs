using Hillerød_Sejlklub_website.Model;

namespace Hillerød_Sejlklub_website.Repository
{
    public interface IBlogRepo
    {
        List<Blog> GetAll();
        void Add(Blog blog);
       void Remove(int title);
    }
}
