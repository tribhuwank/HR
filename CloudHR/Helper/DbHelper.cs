using CloudHR.Data;
using Microsoft.Extensions.Logging;
using System;

namespace CloudHR.Helper
{
    public partial class DbHelper : IDisposable
    {
        private readonly ApplicationDbContext _context;

        private string query { get; set; }
        //public  ILogger Logger { get; set; }

        public DbHelper(ApplicationDbContext context)
        {
            _context = context;
        }

      

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

