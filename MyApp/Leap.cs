namespace MyApp;
using System;

public class Leap{

   public static bool IsLeapYear(int year){

    if(year % 4==0){
        if(year % 100 == 0){
            if(year % 400 == 0){
                return true;
            }
                return false;
            }
            return true;
        } else {
            return false;
        }
    }

    public static void IsLeapYearString(String input){

        try{
            var year = Int32.Parse(input);
            if(year < 1582){
                Console.WriteLine("Please input a year after year 1581");
            }
            else if(IsLeapYear(year)){    
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("false");
        }
        } catch {
            Console.WriteLine("Please input a valid number and try again");
        }  
        
    }


    // public static void IsLeapYearInput(){

    //     Console.WriteLine("Input a number please: ");
    //     var input = Console.ReadLine();

    //     // Assert.Throws();

    //     try{
    //         var year = Int32.Parse(input);
    //         if(IsLeapYear(year)){
    //             Console.WriteLine("yay");
    //         } else {
    //             Console.WriteLine("false");
    //     }
    //     } catch (Exception e){
    //         Console.WriteLine("Please input a valid number and try again");
    //     }
    // }

}


