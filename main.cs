using System;

class Program {
  public static void Main (string[] args) {
    double conversionRate = 2.54;
    
    Console.WriteLine("Please enter the number of inches: ");
    var x = Console.ReadLine();

    int inchValue;
    if (int.TryParse(x, out inchValue))
    {
      double centiValue = inchValue * conversionRate;
      Console.WriteLine("{0} Centimeters", centiValue );
    }
    else {
      Console.WriteLine("Please only put the number" );
    }
  }
}