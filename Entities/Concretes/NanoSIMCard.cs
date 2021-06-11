namespace Entities.Concretes
{
    public class NanoSIMCard
    {
        private Data _data { get; set; }
        public Data Read()
        {
            return _data;
        }

        public void Write(Data data)
        {
            _data = data;
        }
    }
}