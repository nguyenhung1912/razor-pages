using System.ComponentModel.DataAnnotations;

namespace razor_pages.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Username là bắt buộc")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [EmailAddress(ErrorMessage = "Địa chỉ Email không hợp lệ")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Password")]
        [MinLength(6)]
        public string? Password { get; set; }
    }
}