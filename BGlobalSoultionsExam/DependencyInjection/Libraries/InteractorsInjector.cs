using BGlobalSolutionsExam.Interactors;
using BGlobalSolutionsExam.Interactors.Persistances;
using Microsoft.Extensions.DependencyInjection;

namespace BGlobalSolutionsExam.DependencyInjection.Libraries
{
    class InteractorsInjector : BaseInjector
    {
        public InteractorsInjector(IServiceCollection services) : base(services)
        {
        }

        public override void RegisterDependencies()
        {
            RegisterPersistancesInteractors();
            RegisterInteractors();
        }

        private void RegisterPersistancesInteractors()
        {
            RegisterInstancePerRequest<AddVehicleInteractor>();
        }

        private void RegisterInteractors()
        {
            RegisterInstancePerRequest<BrandInteractor>();
            RegisterInstancePerRequest<VehicleInteractor>();
        }
    }
}
