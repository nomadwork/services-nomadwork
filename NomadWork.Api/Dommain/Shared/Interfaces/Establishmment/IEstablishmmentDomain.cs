using NomadWork.Domain.Business;
using System.Collections.Generic;

namespace NomadWork.Domain.Interfaces
{
    public interface IEstablishmmentDomain<T>
    {
        Establishmment Create(T establishmment);
        Establishmment Update(T establishmment);
        Establishmment Delete(T establishmment);
        List<Establishmment> Find(T establishmment);
        List<Establishmment> FindNearby(T establishmment);
        Establishmment FindById(string id);

    }
}
