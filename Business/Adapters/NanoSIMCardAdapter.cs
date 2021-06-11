using Entities.Abstractions;
using Entities.Concretes;

namespace Business.Adapters
{
    public class NanoSIMCardAdapter : ISIMCard
    {
        private NanoSIMCard _nanoSIMCard { get; set; }

        public NanoSIMCardAdapter(NanoSIMCard nanoSımCard)
        {
            _nanoSIMCard = nanoSımCard;
        }
        public Data Read()
        {
            return _nanoSIMCard.Read();
        }

        public void Write(Data data)
        {
            _nanoSIMCard.Write(data);
        }
    }
}