using Microsoft.EntityFrameworkCore;
using Self.Core.Interfaces;
using Self_ordaring_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self.EF.Repos
{
    public class BaseRepos<T> : IBaseRepos<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public BaseRepos(ApplicationDbContext context ) {
            
            _context = context;
        }
       
        

      public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
