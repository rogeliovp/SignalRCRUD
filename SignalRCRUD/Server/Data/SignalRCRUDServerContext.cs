using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalRCRUD.Shared;

namespace SignalRCRUD.Server.Data
{
    public class SignalRCRUDServerContext : DbContext
    {
        public SignalRCRUDServerContext (DbContextOptions<SignalRCRUDServerContext> options)
            : base(options)
        {
        }

        public DbSet<SignalRCRUD.Shared.ProgrammingLanguage> ProgrammingLanguage { get; set; }
    }
}
