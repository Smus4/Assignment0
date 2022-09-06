namespace MyApp.Tests;
using System;
using System.IO;
using System.Text;

public class LeapTest{

    [Fact]
    public void is_2000_a_leap_year()
    {
        //Arrange
        //Act
        var result = Leap.IsLeapYear(2000);

        //Assert
        result.Should().Be(true);            
    }

    [Fact]
    public void is_1600_a_leap_year()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        Leap.IsLeapYearString("1600");

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");                
    }

    [Fact]
    public void is_hej_a_leap_year()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        Leap.IsLeapYearString("hej");

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Please input a valid number and try again");                
    }

    [Fact]
    public void is_1581_a_leap_year()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        Leap.IsLeapYearString("1581");

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Please input a year after year 1581");                
    }


    [Fact]
    public void is_the_year_a_leap_year_hardcode_true()
    {
        //Arrange
        var leap = new Leap();        

        //Act
        var result0 = Leap.IsLeapYear(2012);
        
        //Assert
        result0.Should().Be(true);       
    }
}