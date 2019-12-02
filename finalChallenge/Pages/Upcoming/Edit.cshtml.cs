using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using finalChallenge.Data;
using finalChallenge.Models;

namespace finalChallenge.Pages.Upcoming
{
    public class EditModel : PageModel
    {
        private readonly finalChallenge.Data.finalChallengeContext _context;

        public EditModel(finalChallenge.Data.finalChallengeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fixture Fixture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fixture = await _context.Fixture.FirstOrDefaultAsync(m => m.ID == id);

            if (Fixture == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Fixture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FixtureExists(Fixture.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FixtureExists(int id)
        {
            return _context.Fixture.Any(e => e.ID == id);
        }
    }
}
