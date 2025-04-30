using Hillerød_Sejlklub_website.Model;
using Hillerød_Sejlklub_website.Repository;
namespace Hillerød_Sejlklub_website.Service
{
    public class MemberService
    {
        IMemberRepo _memberRepo;

        public void Add(Member member)
        {

            _memberRepo.Add(member);
        }
        public void Remove(int name)
        {
            _memberRepo.Remove(name);
        }
        public List<Member> GetAll()
        {
            return _memberRepo.GetAll();

        }
        //public void MakeBoardMEmber()
        //{

        //}
        public void Update(Event updatedMember)
        {

        }
    }
}
