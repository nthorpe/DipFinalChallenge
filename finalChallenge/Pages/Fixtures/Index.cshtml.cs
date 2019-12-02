using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using finalChallenge.Data;
using finalChallenge.Models;

namespace finalChallenge.Pages.Fixtures
{
    public class IndexModel : PageModel
    {
        private readonly finalChallenge.Data.finalChallengeContext _context;

        public IndexModel(finalChallenge.Data.finalChallengeContext context)
        {
            _context = context;
        }

        public IList<Fixture> Fixture { get;set; }

        public async Task OnGetAsync()
        {
            Fixture = await _context.Fixture.ToListAsync();
        }
    }
}
