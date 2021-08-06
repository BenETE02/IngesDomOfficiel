using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IngesDom;
using IngesDom.Models;

namespace IngesDom.Pages.Donnees
{
    public class DetailsModel : PageModel
    {
        private readonly IngesDom.Datacontext _context;

        public DetailsModel(IngesDom.Datacontext context)
        {
            _context = context;
        }

        public new User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FirstOrDefaultAsync(m => m.UserID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
