using Application.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Commands.Users
{
    public class GetUsersCommand : IGetUsersCommand
    {
        private readonly IBaseRepositoryService<User> _userService;

        public GetUsersCommand(IBaseRepositoryService<User> userService)
        {
            _userService = userService;
        }

        public Task<User> FindById(Guid id)
        {
            Expression<Func<User, bool>> expression = x => x.Id == id;
            return Task.Run(() => _userService.Find(expression).FirstOrDefault());
        }

        public Task<IEnumerable<User>> Get()
        {
            return Task.Run(()=> _userService.Get());
        }

        public Task<IEnumerable<User>> GetByDepartament(string departament)
        {
            Expression<Func<User, bool>> expression = x => x.Departament == departament;
            return Task.Run(() => _userService.Find(expression));
        }
    }
}
