using System;
using CalculatorLib.Lib;
using Xunit;

namespace CalculatorLib.Test;

public class CalculatorTest
{
    private const double x = 5;
    private const double y = 10;
    private const double zero = 0;
    
    [Fact]
    public void Test_Add()
    {
        var expected = x + y;
        
        var actual = Calculator.Add(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Sub()
    {
        var expected = x - y;
        
        var actual = Calculator.Sub(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Mul()
    {
        var expected = x * y;
        
        var actual = Calculator.Mul(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Div()
    {
        var expected = x / y;
        
        var actual = Calculator.Div(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test_Div_Exception()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Div(x, zero));
    }
}