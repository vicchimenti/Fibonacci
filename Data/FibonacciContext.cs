using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fibonacci.Models;

namespace Fibonacci.Data
{
    public class FibonacciContext : DbContext
    {
        public FibonacciContext (DbContextOptions<FibonacciContext> options)
            : base(options)
        {
        }

        public DbSet<Fibonacci.Models.Series> Series { get; set; }
    }
}
