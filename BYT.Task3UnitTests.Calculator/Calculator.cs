namespace BYT.Task3UnitTests.Calculator;

public class Calculator(double a, double b, char @operator)
{
    private readonly Dictionary<char, Func<double, double, double>> _operations = new()
    {
        ['+'] = (x, y) => x + y,
        ['-'] = (x, y) => x - y,
        ['*'] = (x, y) => x * y,
        ['/'] = (x, y) =>
        {
            if (y == 0)
            {
                throw new InvalidOperationException("Cannot divide by zero.");
            }
            return x / y;
        },
    };
    private readonly ValueTuple<double, double> _inputs = (a, b);

    public double Calculate()
    {
        var (a, b) = _inputs;
        return GetOperation()(a, b);
    }

    private Func<double, double, double> GetOperation()
        => _operations.GetValueOrDefault(@operator) ?? throw new InvalidOperationException($"Operator '{@operator}' is not supported."); 
}