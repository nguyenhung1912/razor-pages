using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using learn_razor_pages.Models;

namespace learn_razor_pages.Pages_Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly learn_razor_pages.Models.ContosoUniversityContext _context;

        public IndexModel(learn_razor_pages.Models.ContosoUniversityContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Enrollment = await _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Student).ToListAsync();
        }
    }
}
