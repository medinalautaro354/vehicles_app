using System.Threading.Tasks;

namespace BGlobalSolutionsExam.Repositories.Repositories
{
    public interface IRepository <T, TAdd>
    {
        Task<T> Add(TAdd add);
    }
}
