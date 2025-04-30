using Hillerød_Sejlklub_website.Model;
using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace Hillerød_Sejlklub_website.Repository
{
    public class MemberRepo:IMemberRepo
    {
        List<Member> _members;
        protected List<Member> Members
        {
            get { return _members; }
            set { _members = value; }
        }
        public List<Member> GetAll()
        {
            return Members;
        }


        public void Add(Member member)
        {
            Members.Add(member);
        }

        public void Remove(int member)
        {
            Members.RemoveAt(member);
        }
        //public void MakeBoardMember(bool board)
        //{
        //    BoardMember.Add();
        //}
    
    }
}
