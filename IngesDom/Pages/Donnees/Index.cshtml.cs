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
    public class IndexModel : PageModel
    {
        private readonly IngesDom.Datacontext _context;

        public IndexModel(IngesDom.Datacontext context)
        {
            _context = context;
        }

        public new IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
