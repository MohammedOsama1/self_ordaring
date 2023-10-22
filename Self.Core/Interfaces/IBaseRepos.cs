using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self.Core.Interfaces
{
    public interface IBaseRepos <T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();


    }
}
