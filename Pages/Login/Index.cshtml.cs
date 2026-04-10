using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace razor_pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Display(Name = "Tên đăng nhập")]
        public string? Username { get; set; }

        [BindProperty]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }

        public string? Message { get; set; }

        public void OnGet()
        {
            Message = "";
        }

        public void OnPost()
        {
            if (Username == "admin" && Password == "123")
            {
                Message = "Đăng nhập thành công!";
            }
            else
            {
                Message = "Sai tên đăng nhập hoặc mật khẩu.";
            }
        }
    }
}