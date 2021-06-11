using System;
using Business.Adapters;
using Entities.Concretes;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new();
            NanoSIMCardAdapter nanoSımCardAdapter = new(new NanoSIMCard());
            nanoSımCardAdapter.Write(new Data{Message = "Fatma beni uyuz etme"});
            smartPhone.simCardSocket.Insert(nanoSımCardAdapter);
        }
    }
}