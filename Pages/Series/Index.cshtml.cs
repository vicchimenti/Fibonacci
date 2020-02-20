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
    public class IndexModel : PageModel
    {
        private readonly Fibonacci.Data.FibonacciContext _context;

        public IndexModel(Fibonacci.Data.FibonacciContext context)
        {
            _context = context;
        }

        public IList<Series> Series { get;set; }

        public async Task OnGetAsync()
        {
            Series = await _context.Series.ToListAsync();
        }
    }
}
