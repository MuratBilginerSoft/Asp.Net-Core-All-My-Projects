using Basic_Math.Interfaces;

namespace Basic_Math.Services
{
    public class MathService : IMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Divide(float a, float b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
