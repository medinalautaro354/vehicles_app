using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BGlobalSolutionsExam.Repositories.Repositories
{
    public interface IRepository <T, TAdd>
    {
        Task<T> Add(TAdd add);
    }
}
