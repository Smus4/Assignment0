namespace MyApp;
using System;

public class LeapTest{


    [Fact]
    public void is_the_year_a_leap_year()
    {

        //Arrange
        var leap = new Leap();
        var input = Console.ReadLine();

        if(!int.TryParse(input, out _)){
           Environment.Exit(0);
        }
        var year = Int32.Parse(input);
        
        //Act
        var result = leap.IsLeapYear(year);

        //Assert
        result.Should().Be("yay");            
        
    }
}