using System;
using Microsoft.EntityFrameworkCore;

namespace HomeWork28._05
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<Quote> Quotes {get;set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quote>().HasData(
                new Quote(){Id = 1 , Text = "Случайности не случайные" , Author = "Master Ugvey",InsertDate = DateTime.Parse("12/05/2012")},
                new Quote(){Id = 2 , Text = "Случайности не случайные" , Author = "Master Ugvey",InsertDate = DateTime.Parse("13/06/2013")},
                new Quote(){Id = 3 , Text = "Случайности не случайные" , Author = "Master Ugvey",InsertDate = DateTime.Parse("14/07/2014")},
                new Quote(){Id = 4 , Text = "Случайности не случайные" , Author = "Master Ugvey",InsertDate = DateTime.Parse("15/08/2015")},
                new Quote(){Id = 5 , Text = "Случайности не случайные" , Author = "Master Ugvey",InsertDate = DateTime.Parse("16/09/2016")}
            );
        }
    }
}