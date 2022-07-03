using System;
using CalculatorLib.Lib;
using Xunit;

namespace CalculatorLib.Test;

public class PersonTest
{
    private Person CreatePerson()
    {
        return new Person()
        {
            Id = 1,
            FirstName = "Andrey",
            LastName = "Starinin"
        };
    }
    
    private Person CreateBadPerson()
    {
        return new Person()
        {
            Id = -1,
            FirstName = "Andrey",
            LastName = "Starinin"
        };
    }
    
    [Fact]
    public void Id_Test()
    {
        var expected = 1;
        
        var actual = new Person()
        {
            Id = 1
        };
        
        Assert.Equal(expected, actual.Id);
    }

    [Fact]
    public void Id_Exception_Test()
    {
        Assert.Throws<ArgumentException>(() => new Person { Id = -1 } );
    }

    [Fact]
    public void FirstName_Test()
    {
        var expected = "Andrey";

        var actual = new Person { FirstName = "Andrey"};
        
        Assert.Equal(expected, actual.FirstName);
    }
    
    [Fact]
    public void LastName_Test()
    {
        var expected = "Starinin";

        var actual = new Person { LastName = "Starinin"};
        
        Assert.Equal(expected, actual.LastName);
    }
    
    [Fact]
    public void FullName_Test()
    {
        var expected = "Starinin Andrey";

        var person = new Person
        {
            FirstName = "Andrey", 
            LastName = "Starinin"
        };
        var actual = person.FullName;
        
        Assert.Equal(expected, actual);
    }
}