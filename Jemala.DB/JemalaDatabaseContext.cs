using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jemala.DB
{
    public class JemalDatabaseContext : DbContext, IDatabase
    {
        public DbSet<Jemalik> Jemaliks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=DESKTOP-B8VHOBB\\SQLEXPRESS03;Database=Jemala;Trusted_Connection=True;");

        public string NameToNumber(string name)
        {
            var result = Jemaliks.FirstOrDefault(o => o.Username.ToLower() == name.ToLower());
            return result.Phonenumber;
        }

        public string NumberToName(string number)
        {
            var result = Jemaliks.FirstOrDefault(o => o.Phonenumber == number);
            return result.Username;
        }

    }
}
