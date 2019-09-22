namespace Nomadwork.Infra.Interfaces
{
    public interface Read<I, O>
    {

        I Convert(O toConvert);
        O Convert(I toConvert);
    }
}