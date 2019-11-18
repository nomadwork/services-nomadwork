using Nomadwork.Infra.Data.Contexts;

namespace Nomadwork.Infra.Repository
{
    interface IData<out T>
    {
        T GetInstance(NomadworkDbContext context);
    }
}
