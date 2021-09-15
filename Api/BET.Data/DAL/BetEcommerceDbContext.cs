using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BET.Data.DAL
{
    public class BetEcommerceDbContext : DbContext
    {
        public BetEcommerceDbContext(DbContextOptions<BetEcommerceDbContext> options) : base(options) { }

        // TODO Seed products and orders here.
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
