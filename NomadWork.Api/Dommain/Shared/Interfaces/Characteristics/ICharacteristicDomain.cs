using NomadWork.Domain.Characteristics;
using System.Collections.Generic;

namespace NomadWork.Domain.Interfaces.Characteristics
{
    public interface ICharacteristicDomain<T>
    {
        Characteristic Create(T characteristic);
        Characteristic Update(T characteristic);
        Characteristic Delete(T characteristic);
        List<Characteristic> Find(T characteristic);
        List<Characteristic> FindNearby(T characteristic);
        Characteristic FindById(string id);
    }
}
