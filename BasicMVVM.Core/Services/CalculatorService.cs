namespace BasicMVVM.Core.Services
{
    /// <summary>
    ///     Test service for auto test with <see href="https://github.com/xunit/xunit">XUnit</see>.
    /// </summary>
    public class CalculatorService
    {
        public double Add(double variavel1, double variavel2)
        {
            return variavel1 + variavel2;
        }

        public double Multiply(double variavel1, double variavel2)
        {
            return variavel1 * variavel2;
        }

        public double Division(double variavel1, double variavel2)
        {
            return variavel1 / variavel2;
        }

        public double Subtract(double variavel1, double variavel2)
        {
            return variavel1 / variavel2;
        }
    }
}