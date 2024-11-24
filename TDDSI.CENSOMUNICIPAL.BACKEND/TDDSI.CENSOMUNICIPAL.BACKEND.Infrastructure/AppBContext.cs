using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Entities;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Infrastructure;
public class AppBContext : DbContext {
    public AppBContext( DbContextOptions<AppBContext> options ) : base( options ) { }

    public DbSet<Citizen> Citizens { get; set; }
}
