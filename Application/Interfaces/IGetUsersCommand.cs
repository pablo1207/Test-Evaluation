using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGetUsersCommand
    {
        Task<IEnumerable<User>> Get();
        Task<User> FindById(Guid id);

        Task<IEnumerable<User>> GetByDepartament(string departament);
    }
}