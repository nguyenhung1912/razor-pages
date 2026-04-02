using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages.Pages.Login
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; } = string.Empty;
        [BindProperty]
        public string Password { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public void OnGet() { }

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