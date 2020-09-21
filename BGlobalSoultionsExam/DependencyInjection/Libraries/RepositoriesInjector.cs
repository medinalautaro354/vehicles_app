using BGlobalSolutionsExam.Repositories.EntityFramework.Repositories;
using BGlobalSolutionsExam.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BGlobalSolutionsExam.DependencyInjection.Libraries
{
    class RepositoriesInjector : BaseInjector
    {
        public RepositoriesInjector(IServiceCollection services) : base(services)
        {
        }

        public override void RegisterDependencies()
        {

            RegisterInstancePerRequest<IVehicleRepository, VehicleRepository>();
            RegisterInstancePerRequest<IVehicleReadOnlyRepository, VehicleRepository>();
        }
    }
}
