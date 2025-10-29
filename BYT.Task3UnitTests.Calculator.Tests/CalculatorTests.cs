namespace BYT.Task3UnitTests.Calculator.Tests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Calculate_UnknownOperator_InvalidOperationExceptionThrown()
    {
        var calculator = new Calculator(5, 5, 'x');
        
        var exception = Assert.Throws<InvalidOperationException>(() => calculator.Calculate());
        Assert.That(exception, Is.TypeOf<InvalidOperationException>());
    }
    
    [Test]
    public void Calculate_DivisionOperatorSecondParameterZero_InvalidOperationExceptionThrown()
    {
        var calculator = new Calculator(5, 0, '/');
        
        var exception = Assert.Throws<InvalidOperationException>(() => calculator.Calculate());
        Assert.That(exception, Is.TypeOf<InvalidOperationException>());
    }
    
    [TestCase(5, 5, '+', 10)]
    [TestCase(5, 5, '-', 0)]
    [TestCase(5, 5, '*', 25)]
    [TestCase(5, 5, '/', 1)]
    public void Calculate_ValidOperator_CorrectlyCalculated(
        double a,
        double b,
        char operation,
        double expectedResult)
    {
        var calculator = new Calculator(a, b, operation);

        var result = calculator.Calculate();

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}