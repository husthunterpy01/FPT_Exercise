using Mock_2.Data;
using Mock_2.Interface.IRepositories;
using Mock_2.Model.Entity;

namespace Mock_2.Repository.Base
{
    public class RoomTypeRepository : GenericRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(HouseRentalDbContext _db) : base(_db)
        {

        }
    }
}
