namespace Essentials2.Library
{
    public interface IMapper<S, T>
    {
        T Map(S source);
    }
}
