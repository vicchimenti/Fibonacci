using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fibonacci.Data;
using Fibonacci.Models;

namespace Fibonacci
{
    public class DetailsModel : PageModel
    {
        private readonly Fibonacci.Data.FibonacciContext _context;

        public DetailsModel(Fibonacci.Data.FibonacciContext context)
        {
            _context = context;
        }

        public Series Series { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Series = await _context.Series.FirstOrDefaultAsync(m => m.ID == id);

            if (Series == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
