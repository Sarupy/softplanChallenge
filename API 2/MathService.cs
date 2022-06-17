namespace API_2
{
    public class MathService
    {
        public double CalcularJurosCompostos(float valorinicial, double juros, int meses)
        {
            return Math.Round(valorinicial * Math.Pow((1 + juros), meses), 2);
        }
    }
}
