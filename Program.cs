namespace DelegateTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 200;
            int y = 40;

            MathOperation operation;

            operation = MathOperations.Add;
            Console.WriteLine($"Add:  { operation(x, y)}");

            operation = MathOperations.Subtract;
            Console.WriteLine($"Subtract:  {operation(x, y)}");

            operation = MathOperations.Multiply;
            Console.WriteLine($"Multiply:  {operation(x, y)}");

            operation = MathOperations.Divide;
            Console.WriteLine($"Divide:  {operation(x, y)}");
        }
    }
}
