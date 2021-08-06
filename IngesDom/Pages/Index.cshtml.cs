using IngesDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngesDom.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Datacontext ctx;

        public IndexModel(ILogger<IndexModel> logger, Datacontext ctx)
        {
            _logger = logger;
            this.ctx = ctx;
        }

        public void OnGet()
        {
            var user = new User()
            {
               Name = "Roamba",
               Firstname = "Epaphras",
               Email = "roamba@inges.ci",
               Sexe = SexeEmum.Masculin
            };

            //ctx.Users.Add(user);

            ctx.SaveChanges();
        }
    }
}
