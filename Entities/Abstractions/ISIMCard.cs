using Entities.Concretes;

namespace Entities.Abstractions
{
    public interface ISIMCard
    {
        Data Read();
        void Write(Data data);
    }
}