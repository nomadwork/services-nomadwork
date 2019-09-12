using NomadWork.Domain.Account.Location;
using System.Collections.Generic;

namespace NomadWork.Domain.Interfaces.Addresses
{
    public interface IAddressDomain<T>
    {
        Address Create(Address address);
        Address Update(Address address);
        Address Delete(Address address);
        List<Address> Find(Address address);
        List<Address> FindNearby(Address address);
        Address FindById(string id);
        Address ToConvert(T address);
        T ToConvert(Address address);
    }
}
