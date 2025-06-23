using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Model.TablesClass;

namespace Web.Model.WebContext
{
    public class WebPersonalContext : DbContext
    {
        public WebPersonalContext(DbContextOptions<WebPersonalContext> options) : base(options)
        {
        }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<AwardCertificate> AwardCertificates { get; set; }
        public DbSet<Interes> Intereses { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experiance> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }


    }
}
