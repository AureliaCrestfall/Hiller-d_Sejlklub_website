using Hillerød_Sejlklub_website.Model;
using Microsoft.Extensions.Logging;
using static System.Net.Mime.MediaTypeNames;

namespace Hillerød_Sejlklub_website.Repository
{
    public class MemberRepo:IMemberRepo
    {
        List<Member> _members;
        //  List<Member> Members
        //{
        //    get { return _members; }
        //     set { _members = value; }
        //    }
        public List<Member> GetAll()
        {
            return _members;
        }
        public void Add(Member member)
        {
            _members.Add(member);
        }
        public Member Get(string name)
        {
            foreach( Member member in _members)
            {
                if (name == member.Name)
                {
                    return member;
                }
            }
            return null;
        }

       

        public void Remove(int member)
        {
            _members.RemoveAt(member);
        }
         
        public MemberRepo()
        {
            _members = new List<Member>();
            _members.Add(new Member("Pedro Dunhammer", "PedroProfil.png", "51533591", "HaderEfternavn@hotmail.com"));
            _members.Add(new Member("Danny Dunhammer", "DannyProfil.png", "40538791", "DirtyDanny@hotmail.com"));
            _members.Add(new Member("Fie Formandsen", "FieProfil.png", "44528579", "BoatMomma@hotmail.com"));

        }




        //public void MakeBoardMember(bool board)
        //{
        //    BoardMember.Add();
        //}

    }
}
