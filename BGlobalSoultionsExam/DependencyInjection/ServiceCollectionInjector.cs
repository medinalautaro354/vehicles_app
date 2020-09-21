using BGlobalSolutionsExam.DependencyInjection.Libraries;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BGlobalSolutionsExam.DependencyInjection
{
    class ServiceCollectionInjector
    {
        private readonly IServiceCollection _services;

        public ServiceCollectionInjector(IServiceCollection services)
        {
            _services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public void InjectDependencies()
        {
            new InteractorsInjector(_services).RegisterDependencies();
            new RepositoriesInjector(_services).RegisterDependencies();
            new DataTransferObjectsFactoriesInjector(_services).RegisterDependencies();
        }
    }
}
