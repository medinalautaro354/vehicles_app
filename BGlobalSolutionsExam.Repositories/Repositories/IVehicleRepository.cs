using BGlobalSolutionsExam.Model.Entities;
using BGlobalSolutionsExam.Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BGlobalSolutionsExam.Repositories.Repositories
{
    public interface IVehicleRepository : IRepository<IVehicle, IVehicleAdd>, IVehicleReadOnlyRepository
    {

    }
    public interface IVehicleReadOnlyRepository 
    {
        Task<IEnumerable<IVehicle>> GetActives();
    }
}
