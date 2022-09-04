namespace MyApp;


public class Leap{


   public string IsLeapYear(int year){
        if(year % 4==0){
            if(year % 100 == 0){
                if(year % 400 == 0){
                    return "yay";
                }
                return "nay";
            }
            return "yay";
        }else{
            return "nay";
        }
    }
}
