using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class BookContext:DbContext
    {
        public BookContext() : base("BookContext") { }
        public DbSet<Book> Books {get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
