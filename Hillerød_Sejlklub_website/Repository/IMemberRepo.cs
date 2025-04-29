using Hillerød_Sejlklub_website.Model;

namespace Hillerød_Sejlklub_website.Repository
{
    public interface IMemberRepo
    {
        void MakeBoardMember(bool board);
        void Remove(string member);
        void Add(Member member);
        List<Member> GetAll();
    }
}
