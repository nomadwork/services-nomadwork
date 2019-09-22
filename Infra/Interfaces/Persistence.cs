namespace Nomadwork.Infra.Interfaces
{
    public interface Persistence<T, C>
    {
        void Update(T toUpdate);
        void Insert(T toInsert);
        C Convert(T toConvert);
        C Convert(C toConvert);
    }
}