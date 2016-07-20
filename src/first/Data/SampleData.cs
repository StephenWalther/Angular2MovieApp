using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using first.Models;

namespace first.Data
{
    public class SampleData
    {

        public async static Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService<ApplicationDbContext>();
            if (!db.Movies.Any())
            {
                db.Movies.AddRange(
                    new Movie { Title="Star Wars", Director="Lucas" },
                    new Movie { Title = "King Kong", Director = "Jackson" },
                    new Movie { Title = "Memento", Director = "Nolan" }
                );

                db.SaveChanges();
            }
        }

    }
}
