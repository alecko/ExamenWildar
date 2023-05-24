using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        private readonly decimal _ladoMenor;
        private readonly decimal _ladoMayor;

        public Rectangulo(decimal ladoMenor, decimal ladoMayor)
        {
            _ladoMenor = ladoMenor;
            _ladoMayor = ladoMayor;
        }

        public decimal CalcularArea()
        {
            return _ladoMenor * _ladoMayor;
        }

        public decimal CalcularPerimetro()
        {
            return _ladoMenor * 2 + _ladoMayor * 2;
        }
    }
}
