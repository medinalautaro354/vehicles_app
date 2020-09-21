using BGlobalSolutionsExam.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BGlobalSolutionsExam.Interactors.Tests
{
    public class ConfigureDatabaseOptionsTest
    {
        protected ConfigureDatabaseOptionsTest(DbContextOptions<BGlobalSolutionsContext> contextOptions)
        {
            ContextOptions = contextOptions;
        }

        protected DbContextOptions<BGlobalSolutionsContext> ContextOptions { get; }

    }
}
