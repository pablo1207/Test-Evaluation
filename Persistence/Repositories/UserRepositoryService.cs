using Application.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Persistence.Repositories
{
    public class UserRepositoryService : IBaseRepositoryService<User>
    {
        private readonly IUsersMoq _usersMoq;

        public UserRepositoryService(IUsersMoq usersMoq)
        {
            _usersMoq = usersMoq;
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> expression)
        {
            return _usersMoq.Find(expression);
        }

        public IEnumerable<User> Get()
        {
            return _usersMoq.Get();
        }
    }
}
