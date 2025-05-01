using Hillerød_Sejlklub_website.Model;
using Hillerød_Sejlklub_website.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hillerød_Sejlklub_website.Pages
{
    public class AddMemberModel : PageModel
    {
        public void OnGet()
        {
        }
        
        private MemberService _ms;
        [BindProperty]
        public Member member { set; get; }

        public AddMemberModel(MemberService ms)
        {
           member = new Member();
           _ms = ms;
        }
        public IActionResult OnPost()
        {
            _ms.Add(member);
            return RedirectToPage("/Members");
        }
    }
}
