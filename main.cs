using System;
class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("pick a number bewteen 1 and 10,000");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 1 || number > 10000)
    {
       Console.WriteLine("invalid input");
      return;
    }
    if (IsPerfectNumber(number))
    {
      Console.WriteLine("perfect Number");
      
    }
    else {
      Console.WriteLine("not a perfect Number");
    }
  }  
    static bool IsPerfectNumber(int num)
    {
      int sum = 0;
      for (int i = 1; i < num; i++)
      {
        if (num % i == 0)
        {
          sum += i;
        }
      }
      return sum == num;
    
    
  }
}