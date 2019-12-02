using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using finalChallenge.Data;
using finalChallenge.Models;

namespace finalChallenge.Pages.Upcoming
{
    public class IndexModel : PageModel
    {
        private readonly finalChallenge.Data.finalChallengeContext _context;
        

        public IndexModel(finalChallenge.Data.finalChallengeContext context)
        {
            _context = context;
        }

        public IList<Fixture> Fixture { get;set; }
        public View ViewSelection { get; set; }

        public async Task OnGetAsync(View viewSelection = View.Upcoming)
        {
            ViewSelection = viewSelection;

            if(viewSelection == View.Upcoming)
            {
                Fixture = await _context.
                    Fixture.Where(yes => yes.Date > DateTime.Now).ToListAsync();
            }
        }

        public enum View
        {
            Fixture,
            Upcoming,
        }
    }
}
