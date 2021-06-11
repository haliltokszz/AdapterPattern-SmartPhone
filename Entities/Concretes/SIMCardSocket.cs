using System;
using Entities.Abstractions;

namespace Entities.Concretes
{
    public class SIMCardSocket
    {
        private ISIMCard _simCard { get; set; }
        
        public void Insert(ISIMCard simCard)
        {
            _simCard = simCard;
            Console.WriteLine($"SIM Card insert. SIM Card data message: {_simCard.Read().Message}");
        }
    }
}