using Meritios.data;
using Meritios.Moudels.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meritios.Pages.Users
{
    public class listusersModel : PageModel
    {
        private readonly usersdbcontext DbContext;
        public List<users> _Users { get; set; } 

        public listusersModel(usersdbcontext context)
        {
            this.DbContext= context;
        }
        public void OnGet()
        {
            _Users = DbContext._Users.ToList();
        }
    }
}
