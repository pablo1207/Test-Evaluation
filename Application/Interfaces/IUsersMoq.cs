using Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IUsersMoq
    {
        IEnumerable<User> Get();
        IEnumerable<User> Find(Expression<Func<User, bool>> expression);

    
    }
}