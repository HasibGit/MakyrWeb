using Makyr.Models;

namespace Makyr.DataAccess.Repository.IRepository
{
    public interface IGraphicsCardRepository : IRepository<GraphicsCard>
    {
        void Update(GraphicsCard gpu);
        void Save();
    }
}
