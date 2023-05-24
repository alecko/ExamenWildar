using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public decimal CalcularArea()
        {
            return (decimal)(Math.PI * Math.Pow((double)_radio, 2));
        }

        public decimal CalcularPerimetro()
        {
            return 2m * (decimal)Math.PI * _radio;
        }
    }
}
