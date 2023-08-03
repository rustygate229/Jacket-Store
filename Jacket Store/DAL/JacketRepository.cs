using System.Data.Entity;

namespace Jacket_Store.DAL
{
    public class JacketRepository : DbContext, JacketRepositoryInterface
    {
        void IDisposable.Dispose() {}
    }
}
