using Meritios.data;
using Meritios.Moudels.Domain;
using Meritios.Moudels.view;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Meritios.Pages.Users
{

	public class addModel : PageModel

	{
		private readonly usersdbcontext DbContext;
		[BindProperty]
		public addview addviewRequest { get; set; }	

		public addModel (usersdbcontext dbcontext)
		{
			DbContext= dbcontext;
		}
		public void OnGet()
		{
		}
		public void OnPost()
		{
			var userDomainModel = new users

			{
				name = addviewRequest.name,
				email= addviewRequest.email,	
				skola= addviewRequest.skola,	
				city= addviewRequest.city,	
				utbildning= addviewRequest.utbildning,
				phone= addviewRequest.phone	



			};

			DbContext._Users.Add(userDomainModel);	
			DbContext.SaveChanges();

		}
	}
}
