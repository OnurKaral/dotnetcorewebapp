using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnetcore.Data;
using dotnetcore.Models;

namespace dotnetcore.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly dotnetcore.Data.dotnetcoreContext _context;

        public IndexModel(dotnetcore.Data.dotnetcoreContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
