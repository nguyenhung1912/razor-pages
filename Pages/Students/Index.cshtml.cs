using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Namespace.Models;

namespace MyApp.Namespace.Pages.Students
{
    public class IndexModel : PageModel
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public Student? SelectedStudent { get; set; }

        public void OnGet(int? id)
        {
            Students = new List<Student>
            {
                new Student{Id = 1, Name="Nguyễn Văn A", Age = 21, Major = "Quản trị kinh doanh"},
                new Student{Id = 2, Name="Nguyễn Văn B", Age = 22, Major = "Kế toán"},
                new Student{Id = 3, Name="Nguyễn Văn C", Age = 20, Major = "Ngôn ngữ Anh"},
                new Student{Id = 4, Name="Nguyễn Văn D", Age = 24, Major = "Ngôn ngữ Trung"}
            };

            if (id.HasValue)
            {
                SelectedStudent = Students.FirstOrDefault(s => s.Id == id.Value);
            }
        }
    }
}