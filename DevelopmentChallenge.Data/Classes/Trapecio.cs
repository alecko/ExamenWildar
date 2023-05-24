using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMenor;
        private readonly decimal _baseMayor;
        private readonly decimal _lateral1;
        private readonly decimal _lateral2;
        private readonly decimal _altura;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal lateral1, decimal lateral2, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _lateral1 = lateral1;
            _lateral2 = lateral2;
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura / 2m);
        }

        public decimal CalcularPerimetro()
        {
            return _baseMenor + _baseMayor + _lateral1 + _lateral2;
        }
    }
}
