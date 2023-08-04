using Microsoft.EntityFrameworkCore;

namespace Jacket_Store.DAL
{
    public class JacketContext : DbContext
    {

        public JacketContext(DbContextOptions<JacketContext> options) : base(options)
        {}

    }
}
