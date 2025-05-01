using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hillerød_Sejlklub_website.Model;
using Hillerød_Sejlklub_website.Service;
using Hillerød_Sejlklub_website.Repository;




namespace Hillerød_Sejlklub_website.Pages
{
    public class MembersModel : PageModel
    {
        ///List<Member> _members;

        private readonly MemberService _ms;

        public MembersModel(MemberService ms)
        {
            _ms = ms;
        }
        public List<Member> Members { set; get; }
       
        
        public void OnGet()
        {
            Members = _ms.GetAll();
        }
    }
}
