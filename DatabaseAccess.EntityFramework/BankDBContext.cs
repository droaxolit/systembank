using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.EntityFramework
{
    public partial class BankDBContext : DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options)
        : base(options) 
        { }
    }
}
