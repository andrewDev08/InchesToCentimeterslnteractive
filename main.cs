using System;

class Program {
  public static void Main (string[] args) {
    double conversionRate = 2.54;
    int inchValue = 5;
    
    double centiValue = inchValue * conversionRate;
    
    Console.WriteLine("{0} Inches", inchValue );
    Console.WriteLine("{0} Centimeters", centiValue );
  }
}