using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerRegistrationApp.Models
{
    public class VolunteersContext : DbContext
    {
        public VolunteersContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<VolunteersRegistrationform> VolunteersRegistrationform { get; set; }
    }
}
