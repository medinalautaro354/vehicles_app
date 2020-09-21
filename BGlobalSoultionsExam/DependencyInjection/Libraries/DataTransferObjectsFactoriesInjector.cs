using BGlobalSolutionsExam.DataTransferObjects.Factories.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace BGlobalSolutionsExam.DependencyInjection.Libraries
{
    class DataTransferObjectsFactoriesInjector : BaseInjector
    {
        public DataTransferObjectsFactoriesInjector(IServiceCollection services) : base(services)
        {
        }

        public override void RegisterDependencies()
        {
            RegisterInstancePerRequest<VehicleDtoFactory>();
        }
    }
}
