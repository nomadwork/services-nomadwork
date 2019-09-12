using NomadWork.Domain.Account;
using System.Collections.Generic;

namespace NomadWork.Domain.Interfaces
{
    public interface IUserDomain<T>
    {
        User Create(T user);
        User Update(T user);
        User Delete(T user);
        List<User> Find(T user);
        List<User> FindNearby(T user);
        User FindById(string id);
    }
}
