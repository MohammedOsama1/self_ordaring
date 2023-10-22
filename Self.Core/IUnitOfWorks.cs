using Self.Core.Interfaces;
using Self_ordaring_sys.Models;

namespace Self.Core
{
    public interface IUnitOfWorks : IDisposable
    {
        IBaseRepos<ItemDetails> ItemDetails { get; }
        IBaseRepos<Category> Categories { get; }
        int complete();
    }
}
