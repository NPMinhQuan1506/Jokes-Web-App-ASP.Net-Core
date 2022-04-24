#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokeWebAppMVC.Models;

namespace JokeWebAppMVC.Data
{
    public class JokeWebAppMVCContext : DbContext
    {
        public JokeWebAppMVCContext (DbContextOptions<JokeWebAppMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JokeWebAppMVC.Models.Joke> Joke { get; set; }
    }
}
