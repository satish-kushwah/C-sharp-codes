using System;
class divisibility_Test {
  static void Main() {
    Console.WriteLine("Enter an integer: ");
    int n=Convert.ToInt32(Console.ReadLine());
    int d=0;
    if(n%5==0)
        d=5;
    if(n%3==0)
        d=3;
    if(n%2==0)
        d=2;
 
    switch(d) 
    {
      case 2:
        Console.WriteLine("This number is divisible by 2");
        break;
      case 3:
        Console.WriteLine("This number is divisible by 3");
        break;
      case 5:
        Console.WriteLine("This number is divisible by 5");
        break; 
      default:
        Console.WriteLine("This number is undetermined");
        break;
    }
  }
}
