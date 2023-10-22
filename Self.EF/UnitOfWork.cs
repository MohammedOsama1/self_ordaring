using Self.Core;
using Self.Core.Interfaces;
using Self.EF.Repos;
using Self_ordaring_sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self.EF
{
    public class UnitOfWork : IUnitOfWorks
    {
        public IBaseRepos<ItemDetails> ItemDetails { get; private set; }
        public IBaseRepos<Category> Categories { get; private set; }



        ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ItemDetails = new BaseRepos<ItemDetails>(_context);
            Categories = new BaseRepos<Category>(_context);
            
        }
        public int complete()
        {
            return 1;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
