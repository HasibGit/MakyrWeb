using Makyr.DataAccess.Repository.IRepository;
using Makyr.Models;

namespace Makyr.DataAccess.Repository
{
    public class GraphicsCardRepository : Repository<GraphicsCard>, IGraphicsCardRepository
    {
        private readonly ApplicationDbContext _db;
        public GraphicsCardRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(GraphicsCard gpu)
        {
            _db.Update(gpu);
        }
    }
}
