using System; 
using System.Linq; 
 
namespace PrimeNumbers 
{ 
 public static class Program 
 { 
  public static void Main(string[] args) 
  { 
   Console.WriteLine("Enter Num 1"); 
   int Number1 = int.Parse(Console.ReadLine()); 
    
   Console.WriteLine("Enter Num 2"); 
   int Number2 = int.Parse(Console.ReadLine()); 
    
   Console.WriteLine(" Theses are the Numbers"); 
   for(int M = Number1 ; M <= Number2 ; M++) 
   { 
    int counter = 0 ; 
    for (int A = 2 ; A<= M/2; A++ ) 
    { 
     if(M % A == 0) 
    { 
     counter++; 
     break;
    } 
   } 
      if (counter == 0 && M != 1) 
          { 
              Console.WriteLine("{0}", M ) ; 
 
} 
} 
}
}
}
