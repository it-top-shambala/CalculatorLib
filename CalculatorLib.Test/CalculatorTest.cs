using System;
using CalculatorLib.Lib;
using Xunit;

namespace CalculatorLib.Test;

public class CalculatorTest
{
    private const double X = 5;
    private const double Y = 10;
    private const double ZERO = 0;
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(10, 0, 10)]
    [InlineData(0, 10, 10)]
    [InlineData(5, 7, 12)]
    public void Test_Add(double x, double y, double expected)
    {
        var actual = Calculator.Add(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Sub()
    {
        var expected = X - Y;
        
        var actual = Calculator.Sub(X, Y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Mul()
    {
        var expected = X * Y;
        
        var actual = Calculator.Mul(X, Y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Div()
    {
        var expected = X / Y;
        
        var actual = Calculator.Div(X, Y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Div_Exception()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Div(X, ZERO));
    }
}