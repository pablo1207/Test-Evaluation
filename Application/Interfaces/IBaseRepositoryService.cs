using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IBaseRepositoryService<T>
    {
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        IEnumerable<T> Get();
    }
}
