using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fri_am_api.Models
{
    public class MusicStoreModel : DbContext
    {
        // constructor that reads the db connection string
        public MusicStoreModel(DbContextOptions<MusicStoreModel>options): base(options)
        {
        }

        // grant the db class access to the Album model (auto-generated in the web app)
        public DbSet<Album> Albums { get; set; }
    }
}
