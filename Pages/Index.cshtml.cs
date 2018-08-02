using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.DataAccess;
using CoreApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public User Users { get; set; }

        public List<User> UserList { get; set; }
        public IndexModel(IUserService userService)
        {
            _userService = userService;
            
        }

        public void OnGet()
        {
           UserList =  _userService.GetUser();
        }

        public IActionResult OnPost()
        {
            _userService.AddUser(Users);
            return RedirectToAction("OnGet");
        }
    }
}
